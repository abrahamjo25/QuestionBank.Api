//var builder = WebApplication.CreateBuilder(args);

//// Add services to the container.

//builder.Services.AddControllers();
//// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

//var app = builder.Build();

//// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

//app.UseHttpsRedirection();

//app.UseAuthorization();

//app.MapControllers();

//app.Run();
using QuestionBank.Api.Extensions;

var builder = WebApplication.CreateBuilder(args);
//builder.Services.AddControllers().AddJsonOptions(x =>
//                x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
//services.AddDbContext<ApplicationDbContext>(options =>
//    options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

builder.RegisterServices(typeof(Program));
var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

var app = builder.Build();
app.UseDeveloperExceptionPage();
app.RegisterPipelineComponents(typeof(Program));
app.UseSession();

app.UseCors(MyAllowSpecificOrigins);
app.Run();
