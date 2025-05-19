using MainService.Clients;

var builder = WebApplication.CreateBuilder(args);

// Добавление поддержки контроллеров
builder.Services.AddControllers();

// Добавление Swagger/OpenAPI
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Регистрация HTTP-клиентов для микросервисов
builder.Services.AddHttpClient<NumberClient>();
builder.Services.AddHttpClient<TextClient>();

var app = builder.Build();

// Конфигурация HTTP-конвейера
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers(); // Включает маршруты контроллеров

app.Run();