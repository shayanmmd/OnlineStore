using _0_FrameWork;
using ShopManagement_Infrastructure_Configuration;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("ShopConnection");


#region Services

builder.Services.AddRazorPages();
builder.Services.ConfigureFrameWork();
builder.Services.ShopManagementConfigure(connectionString);

#endregion

var app = builder.Build();

#region Pipelines

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

#endregion



app.Run();
