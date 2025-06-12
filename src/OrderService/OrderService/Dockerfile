# Используем официальный .NET 9 SDK образ для сборки
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

# Копируем файлы решения и настройки пакетов
COPY OrderProcessingSystem.sln ./
COPY Directory.Packages.props ./

# Копируем все файлы проектов для восстановления зависимостей
COPY src/OrderService/OrderService/*.csproj ./src/OrderService/OrderService/
COPY src/OrderService/Application/OrderService.Application.Models/*.csproj ./src/Application/OrderService.Application.Models/
COPY src/OrderService/Application/OrderService.Application/*.csproj ./src/Application/OrderService.Application/
COPY src/OrderService/Application/OrderService.Application.Contracts/*.csproj ./src/Application/OrderService.Application.Contracts/
COPY src/OrderService/Application/OrderService.Application.Abstractions/*.csproj ./src/Application/OrderService.Application.Abstractions/
COPY src/OrderService/Presentation/OrderService.Presentation.Controllers/*.csproj ./src/Presentation/OrderService.Presentation.Controllers/
COPY src/OrderService/Infrastructure/OrderService.Infrastructure.Persistence/*.csproj ./src/Infrastructure/OrderService.Infrastructure.Persistence/

# Восстанавливаем зависимости
RUN dotnet restore "./src/OrderService/OrderService/OrderService.csproj"

# Копируем весь исходный код
COPY . .

# Собираем приложение
WORKDIR /src/src/OrderService/OrderService
RUN dotnet build "OrderService.csproj" -c Release -o /app/build

# Публикуем приложение
FROM build AS publish
RUN dotnet publish "OrderService.csproj" -c Release -o /app/publish /p:UseAppHost=false

# Используем .NET 9 runtime образ для финального контейнера
FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS final
WORKDIR /app

# Создаем непривилегированного пользователя
RUN adduser --disabled-password --gecos "" --uid 1001 appuser

# Копируем опубликованное приложение
COPY --from=publish /app/publish .

# Меняем владельца файлов
RUN chown -R appuser:appuser /app
USER appuser

# Настраиваем переменные окружения
ENV ASPNETCORE_URLS=http://+:8080
ENV ASPNETCORE_ENVIRONMENT=Production

# Открываем порт
EXPOSE 8080

# Проверка здоровья приложения
HEALTHCHECK --interval=30s --timeout=3s --start-period=5s --retries=3 \
    CMD curl -f http://localhost:8080/health || exit 1

# Точка входа
ENTRYPOINT ["dotnet", "OrderService.dll"]