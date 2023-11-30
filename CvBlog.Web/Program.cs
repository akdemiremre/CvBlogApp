var builder = WebApplication.CreateBuilder(args);

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

//app.MapRazorPages(); // kendi layout umuzun açýlmasý için pasife aldým.
app.UseEndpoints(endpoints =>
{
    endpoints.MapDefaultControllerRoute();
    // Uygulama herhangi bir istek geldiðinde nereye gideceðini bilmediði için yazdým. Varsayýlan olarak Home/Index e gidecek
});

app.Run();
