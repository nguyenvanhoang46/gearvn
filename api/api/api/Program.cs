using System.Net;
using System.Text;
using api.Context;
using api.Models;
using api.Models.Dtos.Response;
using api.Repository;
using api.Repository.IRepo;
using api.Services;
using api.Services.IServices;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSignalR();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddHttpContextAccessor();
builder.Services.AddMvc(options => { options.Filters.Add(typeof(CustomException)); });
builder.Services.Configure<ApiBehaviorOptions>(options => { options.SuppressModelStateInvalidFilter = true; });
var connectionString = builder.Configuration.GetConnectionString("Default");
builder.Services.AddDbContext<AppDbContext>(options =>
{
  options.UseMySql(connectionString!, ServerVersion.AutoDetect(connectionString));
});

builder.Services.AddIdentity<User, Role>(options => { options.User.RequireUniqueEmail = true; })
  .AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();

builder.Services.AddSingleton<IJwtService, JwtService>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<IUserRepo, UserRepo>();
builder.Services.AddScoped<IProductRepo, ProductRepo>();
builder.Services.AddScoped<ICategoryRepo, CategoryRepo>();
builder.Services.AddSingleton<IMetaService>(o =>
{
  var accessor = o.GetRequiredService<IHttpContextAccessor>();
  var request = accessor.HttpContext?.Request;
  var uri = string.Concat(request?.Scheme, "://", request?.Host.ToUriComponent());
  Console.WriteLine($"Request Scheme : {request?.Scheme}");
  Console.WriteLine($"Request Host: {request?.Host.ToUriComponent()}");
  return new MetaService(uri);
});


builder.Services.AddAuthentication(options =>
{
  options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
  options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
  options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(options =>
{
  options.SaveToken = true;
  options.RequireHttpsMetadata = false;
  options.TokenValidationParameters = new TokenValidationParameters
  {
    ValidateIssuer = true,
    ValidateAudience = true,
    ValidAudience = builder.Configuration["JWT:ValidAudience"],
    ValidIssuer = builder.Configuration["JWT:ValidIssuer"],
    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JWT:Secret"]))
  };
});

builder.Services.AddSwaggerGen(opt =>
{
  opt.SwaggerDoc("v1", new OpenApiInfo { Title = "MyAPI", Version = "v1" });
  opt.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
  {
    In = ParameterLocation.Header,
    Description = "Please enter token",
    Name = "Authorization",
    Type = SecuritySchemeType.Http,
    BearerFormat = "JWT",
    Scheme = "bearer"
  });
  opt.AddSecurityRequirement(new OpenApiSecurityRequirement
  {
    {
      new OpenApiSecurityScheme
      {
        Reference = new OpenApiReference
        {
          Type = ReferenceType.SecurityScheme,
          Id = "Bearer"
        }
      },
      new string[] { }
    }
  });
});

builder.Services.AddFluentValidationAutoValidation();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
  app.UseSwagger();
  app.UseSwaggerUI();
}

app.Use(async (context, next) =>
{
  await next();

  if (context.Response.StatusCode == (int)HttpStatusCode.Unauthorized)
  {
    await context.Response.WriteAsJsonAsync(new UnAuthorizedDto());
  }

  if (context.Response.StatusCode == (int)HttpStatusCode.Forbidden)
  {
    await context.Response.WriteAsJsonAsync(new ForbiddenDto());
  }
});

app.UseCors(
  options => options
    .AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader()
);

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
