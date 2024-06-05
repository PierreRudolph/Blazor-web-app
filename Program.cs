using Blazor_App.Components;
using Microsoft.AspNetCore.Mvc;
using Radzen;
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

app.UseStatusCodePagesWithReExecute("/StatusCode/{0}");//is used to get 404 status code, and redirect to custom 404 NotFound site

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
static void ConfigureServices(IServiceCollection services)
{
    services.AddScoped<DialogService>();
    services.AddScoped<RadzenComponent>();
    services.AddScoped<NotificationService>();
    services.AddScoped<TooltipService>();
    services.AddScoped<ContextMenuService>();

    services.AddRazorComponents()
        .AddInteractiveServerComponents();
    //services.AddSingleton<ContactService>();//adds a Singleton service
    //services.AddTransient<ContactService>();//adds a Transient service
    services.AddSingleton<IContactService, ContactServiceTesting>();//service über ein interface einbinden ist die empfohlene variante
    services.AddSingleton<MemberService>();
    //adds Singleton IContactService und ContactService oder anstatt ContactService, ContactServiceTesting eingeben wenn servide geändert werden soll
}