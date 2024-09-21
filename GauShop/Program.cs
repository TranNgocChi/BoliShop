using BusinessObject.Models;
using DataAccess.Context;
using GauShop.ExternalServices;
using GauShop.ExternalServices.MailService;
using GauShop.ExternalServices.MailUtils;
using GauShop.ExternalServices.VnPayService;
using GauShop.Helpers;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

var Configuration = builder.Configuration;

// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllOrigins",
        builder =>
        {
            builder.WithOrigins("https://boligo.azurewebsites.net/")
                   .AllowAnyHeader()
                   .AllowAnyMethod();
        });
});

//Add to use SignInManager
builder.Services.AddScoped<UserManager<User>>();
builder.Services.AddScoped<MongoDBContext>();
builder.Services.AddScoped<SignInManager<User>>();

builder.Services.AddIdentity<User, IdentityRole>()
    .AddUserManager<UserManager<User>>()
    .AddSignInManager<SignInManager<User>>()
    .AddEntityFrameworkStores<MongoDBContext>()
    .AddDefaultTokenProviders();

//Inject Helpers Services
builder.Services.AddScoped<SessionHelper>();

builder.Services.AddLogging(config =>
{
    config.AddConsole();
    config.AddDebug();
});


//Add Service to login gg/fb
builder.Services.Configure<CookiePolicyOptions>(options =>
{
    options.MinimumSameSitePolicy = SameSiteMode.None;
    options.Secure = CookieSecurePolicy.Always; // Đảm bảo rằng Secure luôn được bật
});

builder.Services.ConfigureApplicationCookie(options =>
{
    options.Cookie.SameSite = SameSiteMode.None;
    options.Cookie.SecurePolicy = CookieSecurePolicy.Always;
});

builder.Services.AddAuthentication(options =>
{
    options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = GoogleDefaults.AuthenticationScheme;
})
.AddCookie()
.AddGoogle(googleOptions =>
{
    IConfigurationSection googleAuthNSection = Configuration.GetSection("Authentication:Google");

    googleOptions.ClientId = googleAuthNSection["ClientId"];
    googleOptions.ClientSecret = googleAuthNSection["ClientSecret"];
    googleOptions.CallbackPath = "/login-google";
})
.AddFacebook(facebookOptions =>
{
    IConfigurationSection facebookAuthNSection = Configuration.GetSection("Authentication:Facebook");
    facebookOptions.AppId = facebookAuthNSection["AppId"];
    facebookOptions.AppSecret = facebookAuthNSection["AppSecret"];
    facebookOptions.CallbackPath = "/login-facebook";
});

//add service to sendMail
var mailSettings = Configuration.GetSection("MailSettings");
builder.Services.Configure<MailSettings>(mailSettings);
builder.Services.AddTransient<ISendGmailService, SendGmailService>();

//register VnPay Service
builder.Services.AddSingleton<IVnPayService, VnPayService>();


//add to use Session
builder.Services.AddDistributedMemoryCache();

// Add Cookie
builder.Services.AddSession((option) =>
{
    option.Cookie.Name = "GauGau";
    option.IdleTimeout = new TimeSpan(0, 30, 0); // 0h 30p 0s
});
builder.Services.AddStackExchangeRedisCache(option =>
{
    option.Configuration = builder.Configuration["CacheConnection:RedisConnectionString"];
});

//Add To Use Redis

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseSession(); // Session - Cookie (ID Session)

app.UseCookiePolicy();
app.UseAuthorization();
app.UseAuthentication();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
