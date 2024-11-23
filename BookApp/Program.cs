using DATA.Data;
using DATA.Data.Entity;
using DATA.Extensions;
using DomainLayer;
using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;

var builder = WebApplication.CreateBuilder(args);
var services=builder.Services;
var configuration=builder.Configuration;
services.AddControllers();
services.AddEndpointsApiExplorer();
services.AddSwaggerGen();
services.AddDomainLayer();

builder.Services.AddServices(configuration);

builder.Services.AddIdentity<User,Role>(options =>
{
    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
    options.Lockout.MaxFailedAccessAttempts = 5;
    options.Lockout.AllowedForNewUsers = true;
    options.Password.RequireDigit = true;          
    options.Password.RequiredLength = 8;            
    options.Password.RequireNonAlphanumeric = true; 
    options.Password.RequireUppercase = true;      
    options.Tokens.EmailConfirmationTokenProvider = TokenOptions.DefaultEmailProvider; //Burada DefaultEmailProvider ASP.NET Core Identity t?r?find?n
                                                                                       //t?yin olunan standart e-po�t t?sdiqi token provayderidir.
                                                                                       //?stifad?�i qeydiyyatdan ke�dikd?n sonra sistem avtomatik olaraq
                                                                                       //bu tokeni yarad?r v? e-po�t vasit?sil? istifad?�iy? g�nd?rir.
                                                                                       //?stifad?�i e-po�tunu t?sdiql?dikd?n sonra hesab aktivl??ir.
    
    options.Tokens.PasswordResetTokenProvider = TokenOptions.DefaultProvider;  //DefaultProvider burada ?ifr? s?f?rlama tokeni ���n standart
                                                                               //t?minat�?d?r. ?stifad?�i �?ifr?mi unutdum� funksiyas?ndan
                                                                               //istifad? etdikd?, bu token e-po�t vasit?sil? g�nd?rilir v?
                                                                               //istifad?�i tokeni daxil ed?r?k yeni ?ifr? t?yin ed? bilir.
    
    options.Tokens.AuthenticatorTokenProvider = TokenOptions.DefaultAuthenticatorProvider; //DefaultAuthenticatorProvider iki faktorlu do?rulama
                                                                                           //tokeni yarad?r. Bu token, istifad?�i giri? etm?k
                                                                                           //ist?dikd? do?rulama t?tbiqi il? yarad?lan unikal
                                                                                           //bir kod vasit?sil? t?sdiql?nir. Bu, hesab?n
                                                                                           //t?hl�k?sizliyini art?rmaq ���n ?lav? bir add?md?r.

}).AddEntityFrameworkStores<BookDbContext>().AddDefaultTokenProviders();
services.AddMvc().AddNewtonsoftJson(options => { options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore; });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
