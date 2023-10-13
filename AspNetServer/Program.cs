using AspNetServer.Data;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors(options => 
{
    options.AddPolicy("CORSPolicy", builder =>
    {
        var reactUrl = "http://localhost:3000";
        var azureUrl = "https://appname.azurestaticapps.net";
        builder.AllowAnyMethod().AllowAnyHeader().WithOrigins(reactUrl, azureUrl);
    });
});


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(SwaggerGenOptions => {
    SwaggerGenOptions.SwaggerDoc("v1", new OpenApiInfo{ Title = "ASP.NET React Tutorial", Version = "v1"});
});

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI(SwaggerUIOptions => {
    SwaggerUIOptions.DocumentTitle = "ASP.NET React Tutorial";
    SwaggerUIOptions.SwaggerEndpoint("swagger/v1/swagger.json", "Web API serving a very simple Post model");
    SwaggerUIOptions.RoutePrefix = string.Empty;
});

app.UseHttpsRedirection();

app.UseCors("CORSPolicy");

app.MapGet("/get-all-posts", async () => await PostsRepository.GetPostsAsync())
    .WithTags("Posts Endpoints");

app.MapGet("/get-post-by-id/{postId}", async (int postId) =>
{
    var postToReturn = await PostsRepository.GetPostByIdAsync(postId);

    if (postToReturn != null)
    {
        return Results.Ok(postToReturn);
    }
    else
    {
        return Results.BadRequest();
    }
}).WithTags("Posts Endpoints");


app.MapPost("/create-post", async (Post postToCreate) =>
{
    bool createSuccesful = await PostsRepository.CreatePostAsync(postToCreate);

    if (createSuccesful)
    {
        return Results.Ok("Create Succesful");
    }
    else
    {
        return Results.BadRequest();
    }
}).WithTags("Posts Endpoints");


app.MapPut("/update-post", async (Post postToUpdate) =>
{
    bool updateSuccesful = await PostsRepository.UpdatePostAsync(postToUpdate);

    if (updateSuccesful)
    {
        return Results.Ok("Update Succesful");
    }
    else
    {
        return Results.BadRequest();
    }
}).WithTags("Posts Endpoints");

app.MapDelete("/delete-post-by-id/{postId}", async (int postId) =>
{
    bool deleteSuccesful = await PostsRepository.DeletePostAsync(postId);

    if (deleteSuccesful)
    {
        return Results.Ok("Delete Succesful");
    }
    else
    {
        return Results.BadRequest();
    }
}).WithTags("Posts Endpoints");

app.Run();



