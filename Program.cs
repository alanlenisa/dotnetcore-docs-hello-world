using Azure.Identity;
using TestAppConfig;

var builder = WebApplication.CreateBuilder(args);


builder.Configuration.AddAzureAppConfiguration(options =>
    options.Connect(
        new Uri("Endpoint=https://ac240307.azconfig.io;Id=rgHW;Secret=3/YZbQLpG/cBVFQawibeB41sQnB/oFyIbLjhYc3oLms="),
        new ManagedIdentityCredential("4d8f0534-d427-46e7-b375-e268f9424bf9")));

builder.Services.Configure<Settings>(builder.Configuration.GetSection("TestApp:Settings"));

// Add services to the container. 
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
