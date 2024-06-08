using System.Net;
using ArangoDBNetStandard;
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

var ArangoPass = Environment.GetEnvironmentVariable("ARANGO_ROOT_PASSWORD");
var Transport = HttpApiTransport.UsingBasicAuth(new Uri("http://localhost:8529/"), "_system", "root", ArangoPass);
var Adb = new ArangoDBClient(Transport);

app.MapGet("/getCatFacts", async () =>
{
    var CatFactsResult = await Adb.Cursor.PostCursorAsync<CatFact>("FOR doc IN catFacts RETURN doc");
    if(CatFactsResult.Error){
        Console.WriteLine("Failed to get catFacts");
        return Results.StatusCode((int)HttpStatusCode.InternalServerError);
    }

    return Results.Json(CatFactsResult.Result);
})
.WithName("GetCatFacts")
.WithOpenApi();

app.Run();