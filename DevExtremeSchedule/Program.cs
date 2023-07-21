using DevExtremeSchedule.BL.Implementations;
using DevExtremeSchedule.BL.Interfaces;
using DevExtremeSchedule.DAL.Implementations;
using DevExtremeSchedule.DAL.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services
    .AddRazorPages()
    .AddJsonOptions(options => options.JsonSerializerOptions.PropertyNamingPolicy = null);

builder.Services.AddSingleton<IAppointmentDAL, AppointmentDAL>();
builder.Services.AddSingleton<IAppointmentBL, AppointmentBL>();
builder.Services.AddSingleton<IDBConnection, DBConnection>();

var app  = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllers();
app.MapDefaultControllerRoute();
app.MapRazorPages();

app.Run();
