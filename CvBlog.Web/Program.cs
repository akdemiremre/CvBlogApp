using CvBlog.Data.Abstract;
using CvBlog.Data.Concrete;
using CvBlog.Data.Concrete.EntityFramework.Contexts;
using CvBlog.Data.Concrete.EntityFramework.Mappings;
using CvBlog.Entities.Concrete;
using CvBlog.Services.Abstract;
using CvBlog.Services.AutoMapper.Profiles;
using CvBlog.Services.Concrete;
using CvBlog.Web.AutoMapper.Profiles;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
builder.Services.AddRazorPages();
// AddControllersWithViews => MVC Uygulamas� olarak �al��aca��n� belirttik.
// AddRazorRuntimeCompilation => Frontend taraf�nda her de�i�iklikte uygulamay� derlemeye gerek kalmayacak
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();
builder.Services.AddSession();
//builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddAutoMapper(typeof(ArticleProfile),typeof(CategoryProfile), typeof(SkillProfile), typeof(SocialMediaProfile), typeof(ServiceProfile), typeof(EducationProfile), typeof(ExperienceMap), typeof(MyLanguageMap), typeof(PortfolioMap), typeof(UserProfile));
#region serviceCollection
builder.Services.AddDbContext<CvBlogAppContext>();// AddDbContext -> �z�nde bir scope dur.
// scoped => Yap�lan her request'te nesne tekrar olu�ur ve bir request i�erisinde sadce bir tane nesne kullan�l�r. Bu y�ntem i�in AddScoped() metodu kullan�l�r.
// Transient ve scoped kullan�m �ekilleri nesne olu�turma zamanlar� a��s�ndan biraz kar��t�r�labilir.
// Transient 'te her nesne �a�r�m�nda yeni bir instance olu�turulurken, Scoped'da ise request esnas�nda yeni bir instance olu�ur ve o request sonlanana kadar ayn� nesne kullan�l�r.
// Request baz�nda statelss nesne kullan�lmas� istenen durumlarda Scoped ba��ml�l�klar� olu�turabiliriz.
// Kaynak: http://umutluoglu.com/2017/01/asp-net-core-dependency-injection/
builder.Services.AddIdentity<User, Role>(options =>
{
    // User Password Options
    options.Password.RequireDigit = true; // �ifre say�sal de�er i�ersin
    options.Password.RequiredLength = 6; // �ifre en az 6 karakter olsun.
    options.Password.RequiredUniqueChars = 2; // �ifre i�erisinde 2 farkl� �zel karakter olsun. �rne�in : �zel karakter olarak 2 tane @ i�areti kullanmaya izin vermez. 
    options.Password.RequireNonAlphanumeric = true; // @,!,?,$ vb �zel karakterlerin bulunmas�n� sa�lar.
    options.Password.RequireLowercase = true;
    options.Password.RequireUppercase = true;
    // User Username and Email Options
    options.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+$"; // kullan�c� ad�nda sadece buradaki karakterler kullan�labilecek.
    options.User.RequireUniqueEmail = true;
}).AddEntityFrameworkStores<CvBlogAppContext>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<IArticleService, ArticleManager>();
builder.Services.AddScoped<ICategoryService, CategoryManager>();
builder.Services.AddScoped<ISkillService, SkillManager>();
builder.Services.AddScoped<IServiceService, ServiceManager>();
builder.Services.AddScoped<IEducationService, EducationManager>();
builder.Services.AddScoped<IExperienceService, ExperienceManager>();
builder.Services.AddScoped<IMyLanguageService, MyLanguageManager>();
builder.Services.AddScoped<IPortfolioService, PortfolioManager>();
builder.Services.AddScoped<IUserService, UserManager>();
#endregion
builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = new PathString("/admin/kullanici/giris-yap");
    options.LogoutPath = new PathString("/Admin/User/Logout");
    options.Cookie = new CookieBuilder
    {
        Name = "CvBlog",
        HttpOnly = true, // kullan�c�lar�n js kodlar�yla cookie bilgilerini g�rmesini engeller. Yani XSS(cross-site-scripting) sald�r�lar�ndan korur.
        SameSite = SameSiteMode.Strict, // cookie bilgilerimizin sadece kendi sitemizden geldi�inde i�lenmesini sa�lar.-> strict vermezsek farkl� bir siteden gelse bile cookie de�erleri do�ruysa i�leme al�r. -> Cross Site Request Forgery (CSRF veya XSRF -> Session Riding olarak da bilinir.) 
        //SecurePolicy = CookieSecurePolicy.SameAsRequest // Cookie G�venlik De�eri...  CookieSecurePolicy.SameAsRequest : �stek http gelirse http �zerinden, https �zerinden gelirse https �zerinden bilgiler aktar�l�r... CookieSecurePolicy.Always kullan�lmal�d�r. Yani https �zerinden i�leme al�nmal�d�r.
        SecurePolicy = CookieSecurePolicy.Always // Cookie G�venlik De�eri...  CookieSecurePolicy.SameAsRequest : �stek http gelirse http �zerinden, https �zerinden gelirse https �zerinden bilgiler aktar�l�r... CookieSecurePolicy.Always kullan�lmal�d�r. Yani https �zerinden i�leme al�nmal�d�r.
    };
    options.SlidingExpiration = true; // Kullan�c�ya giri� yapt�ktan sonra belirli bir s�re tan�yoruz. �rne�in 1 g�n.. Bu s�re i�erisinde giri� yaparsa tekrar giri� bilgileri istenmez.  Kullan�c� login olduktan 2 saat sonra girerse s�resini tekrar 1 g�n uzatm�� oluyoruz.
    options.ExpireTimeSpan = System.TimeSpan.FromDays(1); // oturum s�resini 1 g�n belirledik.
    //options.AccessDeniedPath = new PathString("/Admin/Auth/AccessDenied");  // kulan�c� yetkisi olmayan bi yere giri� yaparsa nereye y�nlendirilece�i...
    options.AccessDeniedPath = new PathString("/Admin/User/AccessDenied");  // kulan�c� yetkisi olmayan bi yere giri� yaparsa nereye y�nlendirilece�i...
}); // Idendity den sonra tan�mlad�k.
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
app.UseSession(); // UseAuthentication ve UseAuthorization yap�lar� session yap�s�n� kulland��� i�in ilk olarak session yap�s�n� aktifle�tirdik.
app.UseHttpsRedirection();
app.UseStaticFiles(); // resimler,css ya da js dosyalar�
app.UseRouting();
app.UseAuthentication(); // ilk i�lem kimlik do�rulama
app.UseAuthorization(); // ikinci i�lem yetkilendirme
//app.MapRazorPages(); // kendi layout umuzun a��lmas� i�in pasife ald�m.
app.UseEndpoints(endpoints =>
{
    // Admin Area i�in routeMap ekledik
    endpoints.MapAreaControllerRoute(
        name: "Admin",
        areaName: "Admin",
        pattern: "Admin/{controller=Home}/{action=index}/{id?}"
        );
    // 1 den fazla area vars mapControllerRoute kullanabiliriz

    endpoints.MapDefaultControllerRoute();
    // Uygulama herhangi bir istek geldi�inde nereye gidece�ini bilmedi�i i�in yazd�m. Varsay�lan olarak Home/Index e gidecek
});
app.Run();
