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
// AddControllersWithViews => MVC Uygulamasý olarak çalýþacaðýný belirttik.
// AddRazorRuntimeCompilation => Frontend tarafýnda her deðiþiklikte uygulamayý derlemeye gerek kalmayacak
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();
builder.Services.AddSession();
//builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddAutoMapper(typeof(ArticleProfile),typeof(CategoryProfile), typeof(SkillProfile), typeof(SocialMediaProfile), typeof(ServiceProfile), typeof(EducationProfile), typeof(ExperienceMap), typeof(MyLanguageMap), typeof(PortfolioMap), typeof(UserProfile));
#region serviceCollection
builder.Services.AddDbContext<CvBlogAppContext>();// AddDbContext -> özünde bir scope dur.
// scoped => Yapýlan her request'te nesne tekrar oluþur ve bir request içerisinde sadce bir tane nesne kullanýlýr. Bu yöntem için AddScoped() metodu kullanýlýr.
// Transient ve scoped kullaným þekilleri nesne oluþturma zamanlarý açýsýndan biraz karýþtýrýlabilir.
// Transient 'te her nesne çaðrýmýnda yeni bir instance oluþturulurken, Scoped'da ise request esnasýnda yeni bir instance oluþur ve o request sonlanana kadar ayný nesne kullanýlýr.
// Request bazýnda statelss nesne kullanýlmasý istenen durumlarda Scoped baðýmlýlýklarý oluþturabiliriz.
// Kaynak: http://umutluoglu.com/2017/01/asp-net-core-dependency-injection/
builder.Services.AddIdentity<User, Role>(options =>
{
    // User Password Options
    options.Password.RequireDigit = true; // þifre sayýsal deðer içersin
    options.Password.RequiredLength = 6; // þifre en az 6 karakter olsun.
    options.Password.RequiredUniqueChars = 2; // þifre içerisinde 2 farklý özel karakter olsun. Örneðin : özel karakter olarak 2 tane @ iþareti kullanmaya izin vermez. 
    options.Password.RequireNonAlphanumeric = true; // @,!,?,$ vb özel karakterlerin bulunmasýný saðlar.
    options.Password.RequireLowercase = true;
    options.Password.RequireUppercase = true;
    // User Username and Email Options
    options.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+$"; // kullanýcý adýnda sadece buradaki karakterler kullanýlabilecek.
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
        HttpOnly = true, // kullanýcýlarýn js kodlarýyla cookie bilgilerini görmesini engeller. Yani XSS(cross-site-scripting) saldýrýlarýndan korur.
        SameSite = SameSiteMode.Strict, // cookie bilgilerimizin sadece kendi sitemizden geldiðinde iþlenmesini saðlar.-> strict vermezsek farklý bir siteden gelse bile cookie deðerleri doðruysa iþleme alýr. -> Cross Site Request Forgery (CSRF veya XSRF -> Session Riding olarak da bilinir.) 
        //SecurePolicy = CookieSecurePolicy.SameAsRequest // Cookie Güvenlik Deðeri...  CookieSecurePolicy.SameAsRequest : Ýstek http gelirse http üzerinden, https üzerinden gelirse https üzerinden bilgiler aktarýlýr... CookieSecurePolicy.Always kullanýlmalýdýr. Yani https üzerinden iþleme alýnmalýdýr.
        SecurePolicy = CookieSecurePolicy.Always // Cookie Güvenlik Deðeri...  CookieSecurePolicy.SameAsRequest : Ýstek http gelirse http üzerinden, https üzerinden gelirse https üzerinden bilgiler aktarýlýr... CookieSecurePolicy.Always kullanýlmalýdýr. Yani https üzerinden iþleme alýnmalýdýr.
    };
    options.SlidingExpiration = true; // Kullanýcýya giriþ yaptýktan sonra belirli bir süre tanýyoruz. Örneðin 1 gün.. Bu süre içerisinde giriþ yaparsa tekrar giriþ bilgileri istenmez.  Kullanýcý login olduktan 2 saat sonra girerse süresini tekrar 1 gün uzatmýþ oluyoruz.
    options.ExpireTimeSpan = System.TimeSpan.FromDays(1); // oturum süresini 1 gün belirledik.
    //options.AccessDeniedPath = new PathString("/Admin/Auth/AccessDenied");  // kulanýcý yetkisi olmayan bi yere giriþ yaparsa nereye yönlendirileceði...
    options.AccessDeniedPath = new PathString("/Admin/User/AccessDenied");  // kulanýcý yetkisi olmayan bi yere giriþ yaparsa nereye yönlendirileceði...
}); // Idendity den sonra tanýmladýk.
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
app.UseSession(); // UseAuthentication ve UseAuthorization yapýlarý session yapýsýný kullandýðý için ilk olarak session yapýsýný aktifleþtirdik.
app.UseHttpsRedirection();
app.UseStaticFiles(); // resimler,css ya da js dosyalarý
app.UseRouting();
app.UseAuthentication(); // ilk iþlem kimlik doðrulama
app.UseAuthorization(); // ikinci iþlem yetkilendirme
//app.MapRazorPages(); // kendi layout umuzun açýlmasý için pasife aldým.
app.UseEndpoints(endpoints =>
{
    // Admin Area için routeMap ekledik
    endpoints.MapAreaControllerRoute(
        name: "Admin",
        areaName: "Admin",
        pattern: "Admin/{controller=Home}/{action=index}/{id?}"
        );
    // 1 den fazla area vars mapControllerRoute kullanabiliriz

    endpoints.MapDefaultControllerRoute();
    // Uygulama herhangi bir istek geldiðinde nereye gideceðini bilmediði için yazdým. Varsayýlan olarak Home/Index e gidecek
});
app.Run();
