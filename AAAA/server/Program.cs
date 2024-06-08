using ArangoDBNetStandard;
using ArangoDBNetStandard.DocumentApi.Models;
using ArangoDBNetStandard.Transport.Http;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

var Transport = HttpApiTransport.UsingBasicAuth(new Uri("http://localhost:8529/"), "_system", "root", "1234");
var Adb = new ArangoDBClient(Transport);

app.MapGet("/getCatFacts", async () =>
{
    var response = await Adb.Cursor.PostCursorAsync<CatFact>(
        @"FOR doc IN catFacts 
        RETURN doc");
    return Results.Json(response);
})
.WithName("GetCatFacts")
.WithOpenApi();

app.Run();