using CvBlog.Data.Abstract;
using CvBlog.Data.Concrete;
using CvBlog.Data.Concrete.EntityFramework.Contexts;
using CvBlog.Services.Abstract;
using CvBlog.Services.AutoMapper.Profiles;
using CvBlog.Services.Concrete;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

// AddControllersWithViews => MVC Uygulamasý olarak çalýþacaðýný belirttik.
// AddRazorRuntimeCompilation => Frontend tarafýnda her deðiþiklikte uygulamayý derlemeye gerek kalmayacak
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();
//builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddAutoMapper(typeof(ArticleProfile),typeof(CategoryProfile), typeof(SkillProfile));
#region serviceCollection
builder.Services.AddDbContext<CvBlogAppContext>();// AddDbContext -> özünde bir scope dur.
// scoped => Yapýlan her request'te nesne tekrar oluþur ve bir request içerisinde sadce bir tane nesne kullanýlýr. Bu yöntem için AddScoped() metodu kullanýlýr.
// Transient ve scoped kullaným þekilleri nesne oluþturma zamanlarý açýsýndan biraz karýþtýrýlabilir.
// Transient 'te her nesne çaðrýmýnda yeni bir instance oluþturulurken, Scoped'da ise request esnasýnda yeni bir instance oluþur ve o request sonlanana kadar ayný nesne kullanýlýr.
// Request bazýnda statelss nesne kullanýlmasý istenen durumlarda Scoped baðýmlýlýklarý oluþturabiliriz.
// Kaynak: http://umutluoglu.com/2017/01/asp-net-core-dependency-injection/
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<IArticleService, ArticleManager>();
builder.Services.AddScoped<ICategoryService, CategoryManager>();
#endregion

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
else
{
    app.UseStatusCodePages(); // Hata aldýðýmýzda beyaz sayfa yerine hata kodunu basmasý için yazdým.
}

app.UseHttpsRedirection();

app.UseStaticFiles(); // resimler,css ya da js dosyalarý

app.UseRouting();

app.UseAuthorization();

//app.MapRazorPages(); // kendi layout umuzun açýlmasý için pasife aldým.
app.UseEndpoints(endpoints =>
{
    endpoints.MapDefaultControllerRoute();
    // Uygulama herhangi bir istek geldiðinde nereye gideceðini bilmediði için yazdým. Varsayýlan olarak Home/Index e gidecek

    // Admin Area için routeMap ekledik
    endpoints.MapAreaControllerRoute(
        name: "Admin",
        areaName: "Admin",
        pattern: "Admin/{controller=Home}/{action=index}/{id?}"
        );
    // 1 den fazla area vars mapControllerRoute kullanabiliriz
});

app.Run();
