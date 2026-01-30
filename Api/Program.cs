using Api.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddScoped<AddingTwoNumbersService>();
builder.Services.AddScoped<AskingQuestionsService>();
builder.Services.AddScoped<GuessItService>();
builder.Services.AddScoped<HelloWorldService>();
builder.Services.AddScoped<MadLibService>();
builder.Services.AddScoped<Magic8BallService>();
builder.Services.AddScoped<OddOrEvenService>();
builder.Services.AddScoped<RestaurantPickerService>();
builder.Services.AddScoped<ReverseItAlphanumericService>();
builder.Services.AddScoped<ReverseItNumbersOnlyService>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
   options.AddPolicy("AllowAllTraffic", policy =>
   {
       policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
   }); 
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("AllowAllTraffic");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
