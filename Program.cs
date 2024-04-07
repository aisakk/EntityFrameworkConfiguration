var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapPost("/ejemplo", (Alumno alumno)=> alumno);
/*app.MapPost("/alumno",()=> );*/
app.Run("http://localhost:3000");
