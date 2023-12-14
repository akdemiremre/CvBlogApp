using CvBlog.Data.Abstract;
using CvBlog.Data.Concrete;
using CvBlog.Data.Concrete.EntityFramework.Contexts;
using CvBlog.Services.Abstract;
using CvBlog.Services.AutoMapper.Profiles;
using CvBlog.Services.Concrete;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

// AddControllersWithViews => MVC Uygulamas� olarak �al��aca��n� belirttik.
// AddRazorRuntimeCompilation => Frontend taraf�nda her de�i�iklikte uygulamay� derlemeye gerek kalmayacak
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();
//builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddAutoMapper(typeof(ArticleProfile),typeof(CategoryProfile), typeof(SkillProfile));
#region serviceCollection
builder.Services.AddDbContext<CvBlogAppContext>();// AddDbContext -> �z�nde bir scope dur.
// scoped => Yap�lan her request'te nesne tekrar olu�ur ve bir request i�erisinde sadce bir tane nesne kullan�l�r. Bu y�ntem i�in AddScoped() metodu kullan�l�r.
// Transient ve scoped kullan�m �ekilleri nesne olu�turma zamanlar� a��s�ndan biraz kar��t�r�labilir.
// Transient 'te her nesne �a�r�m�nda yeni bir instance olu�turulurken, Scoped'da ise request esnas�nda yeni bir instance olu�ur ve o request sonlanana kadar ayn� nesne kullan�l�r.
// Request baz�nda statelss nesne kullan�lmas� istenen durumlarda Scoped ba��ml�l�klar� olu�turabiliriz.
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
    app.UseStatusCodePages(); // Hata ald���m�zda beyaz sayfa yerine hata kodunu basmas� i�in yazd�m.
}

app.UseHttpsRedirection();

app.UseStaticFiles(); // resimler,css ya da js dosyalar�

app.UseRouting();

app.UseAuthorization();

//app.MapRazorPages(); // kendi layout umuzun a��lmas� i�in pasife ald�m.
app.UseEndpoints(endpoints =>
{
    endpoints.MapDefaultControllerRoute();
    // Uygulama herhangi bir istek geldi�inde nereye gidece�ini bilmedi�i i�in yazd�m. Varsay�lan olarak Home/Index e gidecek

    // Admin Area i�in routeMap ekledik
    endpoints.MapAreaControllerRoute(
        name: "Admin",
        areaName: "Admin",
        pattern: "Admin/{controller=Home}/{action=index}/{id?}"
        );
    // 1 den fazla area vars mapControllerRoute kullanabiliriz
});

app.Run();
