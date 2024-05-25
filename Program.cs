using Blazor_App.Components;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
ConfigureServices(builder.Services);//alternative um services hinzufügen.
//builder.Services.AddRazorComponents()
//    .AddInteractiveServerComponents();
//own service added
//builder.Services.AddSingleton<ContactService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();

static void ConfigureServices(IServiceCollection services)
{
    services.AddRazorComponents()
    .AddInteractiveServerComponents();
    services.AddSingleton<ContactService>();
}
