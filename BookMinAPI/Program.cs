using BookMinAPI.Data;
using BookMinAPI.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//menambahkan EF
builder.Services.AddDbContext<PubContext>(options => options.UseSqlServer(
builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IAuthor, AuthorDAL>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

//menambahkan minimal api
app.MapGet("api/v1/authors", async (IAuthor authorDal) =>
{
    var authors = await authorDal.GetAll();
    return Results.Ok(authors);
});

app.MapGet("api/v1/authors/{id}", async (IAuthor authorDal, int id) =>
{
    var author = await authorDal.GetById(id);
    if (author == null)
    {
        return Results.NotFound();
    }
    return Results.Ok(author);
});

app.MapPost("api/v1/authors", async (IAuthor authorDal, Author author) =>
{
    var newAuthor = await authorDal.Insert(author);
    return Results.Created($"/api/v1/authors/{newAuthor.AuthorId}", newAuthor);
});

app.MapPut("api/v1/authors/{id}", async (IAuthor authorDal, Author author) =>
{
    var editAuthor = await authorDal.GetById(author.AuthorId);
    if (editAuthor == null)
    {
        return Results.NotFound();
    }

    var updatedAuthor = await authorDal.Update(author);
    return Results.Ok(updatedAuthor);

});

app.MapDelete("api/v1/authors/{id}", async (IAuthor authorDal, int id) =>
{
    var author = await authorDal.GetById(id);
    if (author == null)
    {
        return Results.NotFound();
    }
    await authorDal.Delete(id);
    return Results.NoContent();
});

app.Run();
