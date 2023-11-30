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

//app.MapRazorPages(); // kendi layout umuzun a��lmas� i�in pasife ald�m.
app.UseEndpoints(endpoints =>
{
    endpoints.MapDefaultControllerRoute();
    // Uygulama herhangi bir istek geldi�inde nereye gidece�ini bilmedi�i i�in yazd�m. Varsay�lan olarak Home/Index e gidecek
});

app.Run();
