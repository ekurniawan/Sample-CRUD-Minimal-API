var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

//menggunakan swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

//menggunakan swagger
app.UseSwagger();
app.UseSwaggerUI();

app.MapControllers();
app.Run();
