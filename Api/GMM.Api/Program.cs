using GMM.Api.Filter;
using GMM.Application;
using GMM.Common;
using GMM.ExternalServices.ServiceProgrammed;
using GMM.ExternalServices.AwsS3;
using GMM.ExternalServices.Mail;
using GMM.ExternalServices.ServiceUniversal;
using GMM.Infrastructure;
using Microsoft.AspNetCore.Localization;
using System.Globalization;
using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Reec.Inspection;
using Microsoft.EntityFrameworkCore;
using Reec.Inspection.SqlServer;
using GMM.Api.Services;

var builder = WebApplication.CreateBuilder(args);

ConfigurationManager configuration = builder.Configuration;
IWebHostEnvironment environment = builder.Environment;


configuration.AddJsonFile($"appsettings.{environment.EnvironmentName}.json", optional: false, reloadOnChange: true);


// Add services to the container.
builder.Services.AddControllers();


builder.Services.AddMvc()
    .AddNewtonsoftJson(options =>
    {
        options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
        options.SerializerSettings.ContractResolver = new DefaultContractResolver();

        //options.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
    });

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.OperationFilter<CustomHeaderSwaggerAttribute>();

    // Set the comments path for the Swagger JSON and UI.
    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    c.IncludeXmlComments(xmlPath);

});
builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

builder.Services.AddCommon();
builder.Services.AddApplication();
builder.Services.AddInfrastructure(configuration, environment.IsDevelopment());

builder.Services.AddReecException<DbContextSqlServer>(options =>
        options.UseSqlServer(configuration.GetConnectionString("DEV_STANDAR")),
        new ReecExceptionOptions
        {
            ApplicationName = "GMM.Api",
            EnableMigrations = false,
            HeaderKeysExclude = new List<string> { "code", "header" },
            Schema = "Sgr"
        });

builder.Services.AddServiceProgrammed(() =>
{
    return configuration.GetSection("ServiceProgrammed")
                    .Get<ServiceProgrammedOptions>();
});
builder.Services.AddAwsS3Antamina(() => 
{
    return configuration.GetSection("AwsS3Antamina")
                    .Get<AwsS3AntaminaOptions>();
});

builder.Services.AddMailAntamina(() =>
{
    return configuration.GetSection("ServiceEmail")
                    .Get<MailOptions>();
});

builder.Services.AddServiceUniversal(() =>
{
    return configuration.GetSection("ServiceUniversal")
                    .Get<ServiceUniversalOptions>();
});

builder.Services.AddCors(o => o.AddPolicy("All", builder =>
{
    builder.AllowAnyOrigin()
           .AllowAnyMethod()
           .AllowAnyHeader();
}));

var app = builder.Build();

var supportedCultures = new[] { new CultureInfo("es-PE") };
app.UseRequestLocalization(new RequestLocalizationOptions
{
    DefaultRequestCulture = new RequestCulture("es-PE"),
    SupportedCultures = supportedCultures,
    FallBackToParentCultures = false
});
CultureInfo.DefaultThreadCurrentCulture = CultureInfo.CreateSpecificCulture("es-PE");

//app.UseReecException<DbContextSqlServer>();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
app.UseSwagger();
app.UseSwaggerUI(options =>
{
    options.RoutePrefix = string.Empty;
    string swaggerJsonBasePath = string.IsNullOrWhiteSpace(options.RoutePrefix) ? "." : "..";
    options.SwaggerEndpoint($"{swaggerJsonBasePath}/swagger/v1/swagger.json", "v1");
});

app.UseCors("All");
app.UseRouting();
app.UseAuthorization();
app.MapControllers();


//Habilitar solo si se requiere validar las cabeceras de Core y Header
//app.UseValidationHeader();

app.Run();
