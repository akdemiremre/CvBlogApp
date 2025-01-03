using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvBlog.Services.Utilities
{
    public static class Messages
    {
        public static class Article
        {
            public static string Error(string proc, string errorMessage)
            {
                return $"{proc} yapılırken hata oluştu ! Hata : " + errorMessage;
            }
            public static string NotFound(bool isPlural)
            {
                if (isPlural) return "Hiç bir makale bulunamadı.";
                return "Böyle bir makale bulunamadı.";
            }
            public static string Add(bool result, string articleName)
            {
                if (result) return $"{articleName} isimli makale başarıyla eklenmiştir.";
                return $"{articleName} isimli makale eklenemedi.";
            }

            public static string Delete(bool result, string articleName)
            {
                if (result) return $"{articleName} isimli makale başarıyla silinmiştir.";
                return "Makale silinemedi";
            }
            public static string HardDelete(bool result, string articleName)
            {
                if (result) return $"{articleName} isimli makale kaydı başarıyla silinmiştir.";
                return "Makale kaydı silinemedi";
            }
            public static string Update(bool result, string articleName)
            {
                if (result) return $"{articleName} isimli makale başarıyla güncellenmiştir.";
                return $"{articleName} isimli makale güncellenemedi.";
            }
            public static string IsActiveChange(bool result, string articleName, string state)
            {
                if (result) return $"{articleName} isimli makale başarıyla {state} hale getirilmiştir.";
                return $"{articleName} isimli makale durumu güncellenemedi.";
            }
        }
        public static class Category
        {
            public static string Error(string proc, string errorMessage)
            {
                return $"{proc} yapılırken hata oluştu ! Hata : "+errorMessage;
            }
            public static string NotFound(bool isPlural)
            {
                if (isPlural) return "Hiç bir kategori bulunamadı.";
                return "Böyle bir kategori bulunamadı.";
            }
            public static string Add(bool result, string categoryName)
            {
                if(result) return $"{categoryName} isimli kategori başarıyla eklenmiştir.";
                return $"{categoryName} isimli kategori eklenemedi.";
            }

            public static string Delete(bool result, string categoryName)
            {
                if (result) return $"{categoryName} isimli kategori başarıyla silinmiştir.";
                return "Kategori silinemedi";
            }
            public static string HardDelete(bool result, string categoryName)
            {
                if (result) return $"{categoryName} isimli kategori kaydı başarıyla silinmiştir.";
                return "Kategori kaydı silinemedi";
            }
            public static string Update(bool result, string categoryName)
            {
                if (result) return $"{categoryName} isimli kategori başarıyla güncellenmiştir.";
                return $"{categoryName} isimli kategori güncellenemedi.";
            }
            public static string IsActiveChange(bool result, string categoryName, string state)
            {
                if (result) return $"{categoryName} isimli kategori başarıyla {state} hale getirilmiştir.";
                return $"{categoryName} isimli kategori durumu güncellenemedi.";
            }
        }
        public static class Education
        {
            public static string Error(string proc, string errorMessage)
            {
                return $"{proc} yapılırken hata oluştu ! Hata : " + errorMessage;
            }
            public static string NotFound(bool isPlural)
            {
                if (isPlural) return "Hiç bir eğitim bilgisi bulunamadı.";
                return "Böyle bir eğitim bilgisi bulunamadı.";
            }
            public static string Add(bool result)
            {
                if (result) return "Eğitim bilgisi başarıyla eklenmiştir.";
                return "Eğitim bilgisi eklenemedi.";
            }

            public static string Delete(bool result)
            {
                if (result) return "Eğitim bilgisi başarıyla silinmiştir.";
                return "Eğitim bilgisi silinemedi";
            }
            public static string HardDelete(bool result)
            {
                if (result) return "Eğitim bilgisi kaydı başarıyla silinmiştir.";
                return "Eğitim bilgisi kaydı silinemedi";
            }
            public static string Update(bool result)
            {
                if (result) return "Eğitim bilgisi başarıyla güncellenmiştir.";
                return "Eğitim bilgisi güncellenemedi.";
            }
            public static string IsActiveChange(bool result, string state)
            {
                if (result) return $"Eğitim bilgisi başarıyla {state} hale getirilmiştir.";
                return "Eğitim bilgisi durumu güncellenemedi.";
            }
        }
        public static class EducationLevel
        {
            public static string Error(string proc, string errorMessage)
            {
                return $"{proc} yapılırken hata oluştu ! Hata : "+errorMessage;
            }
            public static string NotFound(bool isPlural)
            {
                if (isPlural) return "Hiç bir eğitim seviye bilgisi bulunamadı.";
                return "Böyle bir eğitim seviye bilgisi bulunamadı.";
            }
        }
        public static class Experience
        {
            public static string Error(string proc, string errorMessage)
            {
                return $"{proc} yapılırken hata oluştu ! Hata : " + errorMessage;
            }
            public static string NotFound(bool isPlural)
            {
                if (isPlural) return "Hiç bir deneyim bulunamadı.";
                return "Böyle bir deneyim bulunamadı.";
            }
            public static string Add(bool result)
            {
                if (result) return "Deneyim başarıyla eklenmiştir.";
                return "Deneyim eklenemedi.";
            }

            public static string Delete(bool result)
            {
                if (result) return "Deneyim başarıyla silinmiştir.";
                return "Deneyim silinemedi";
            }
            public static string HardDelete(bool result)
            {
                if (result) return "Deneyim kaydı başarıyla silinmiştir.";
                return "Deneyim kaydı silinemedi";
            }
            public static string Update(bool result)
            {
                if (result) return "Deneyim başarıyla güncellenmiştir.";
                return "Deneyim güncellenemedi.";
            }
            public static string IsActiveChange(bool result, string state)
            {
                if (result) return $"Deneyim başarıyla {state} hale getirilmiştir.";
                return "Deneyim durumu güncellenemedi.";
            }
        }
        public static class MyLanguage
        {
            public static string Error(string proc, string errorMessage)
            {
                return $"{proc} yapılırken hata oluştu ! Hata : " + errorMessage;
            }
            public static string NotFound(bool isPlural)
            {
                if (isPlural) return "Hiç bir dil bilgisi bulunamadı.";
                return "Böyle bir dil bilgisi bulunamadı.";
            }
            public static string Add(bool result, string myLanguageName)
            {
                if (result) return $"{myLanguageName} isimli dil bilgisi başarıyla eklenmiştir.";
                return $"{myLanguageName} isimli dil bilgisi eklenemedi.";
            }

            public static string Delete(bool result, string myLanguageName)
            {
                if (result) return $"{myLanguageName} isimli dil bilgisi başarıyla silinmiştir.";
                return "Dil bilgisi silinemedi";
            }
            public static string HardDelete(bool result, string myLanguageName)
            {
                if (result) return $"{myLanguageName} isimli dil bilgisi kaydı başarıyla silinmiştir.";
                return "Dil bilgisi kaydı silinemedi";
            }
            public static string Update(bool result, string myLanguageName)
            {
                if (result) return $"{myLanguageName} isimli dil bilgisi başarıyla güncellenmiştir.";
                return $"{myLanguageName} isimli dil bilgisi güncellenemedi.";
            }
            public static string IsActiveChange(bool result, string myLanguageName, string state)
            {
                if (result) return $"{myLanguageName} isimli dil bilgisi başarıyla {state} hale getirilmiştir.";
                return $"{myLanguageName} isimli dil bilgisi durumu güncellenemedi.";
            }
        }
        public static class Portfolio
        {
            public static string Error(string proc, string errorMessage)
            {
                return $"{proc} yapılırken hata oluştu ! Hata : " + errorMessage;
            }
            public static string NotFound(bool isPlural)
            {
                if (isPlural) return "Hiç bir portföy bulunamadı.";
                return "Böyle bir portföy bulunamadı.";
            }
            public static string Add(bool result, string portfolioName)
            {
                if (result) return $"{portfolioName} isimli portföy başarıyla eklenmiştir.";
                return $"{portfolioName} isimli portföy eklenemedi.";
            }

            public static string Delete(bool result, string portfolioName)
            {
                if (result) return $"{portfolioName} isimli portföy başarıyla silinmiştir.";
                return "Portföy silinemedi";
            }
            public static string HardDelete(bool result, string portfolioName)
            {
                if (result) return $"{portfolioName} isimli portföy kaydı başarıyla silinmiştir.";
                return "Portföy kaydı silinemedi";
            }
            public static string Update(bool result, string portfolioName)
            {
                if (result) return $"{portfolioName} isimli portföy başarıyla güncellenmiştir.";
                return $"{portfolioName} isimli portföy güncellenemedi.";
            }
            public static string IsActiveChange(bool result, string portfolioName, string state)
            {
                if (result) return $"{portfolioName} isimli portföy başarıyla {state} hale getirilmiştir.";
                return $"{portfolioName} isimli portföy durumu güncellenemedi.";
            }
        }
        public static class Service
        {
            public static string Error(string proc, string errorMessage)
            {
                return $"{proc} yapılırken hata oluştu ! Hata : " + errorMessage;
            }
            public static string NotFound(bool isPlural)
            {
                if (isPlural) return "Hiç bir portföy bulunamadı.";
                return "Böyle bir hizmet bulunamadı.";
            }
            public static string Add(bool result, string serviceName)
            {
                if (result) return $"{serviceName} isimli hizmet başarıyla eklenmiştir.";
                return $"{serviceName} isimli hizmet eklenemedi.";
            }

            public static string Delete(bool result, string serviceName)
            {
                if (result) return $"{serviceName} isimli hizmet başarıyla silinmiştir.";
                return "Hizmet silinemedi";
            }
            public static string HardDelete(bool result, string serviceName)
            {
                if (result) return $"{serviceName} isimli hizmet kaydı başarıyla silinmiştir.";
                return "Hizmet kaydı silinemedi";
            }
            public static string Update(bool result, string serviceName)
            {
                if (result) return $"{serviceName} isimli hizmet başarıyla güncellenmiştir.";
                return $"{serviceName} isimli hizmet güncellenemedi.";
            }
            public static string IsActiveChange(bool result, string serviceName, string state)
            {
                if (result) return $"{serviceName} isimli hizmet başarıyla {state} hale getirilmiştir.";
                return $"{serviceName} isimli hizmet durumu güncellenemedi.";
            }
        }
        public static class Skill
        {
            public static string Error(string proc, string errorMessage)
            {
                return $"{proc} yapılırken hata oluştu ! Hata : " + errorMessage;
            }
            public static string NotFound(bool isPlural)
            {
                if (isPlural) return "Hiç bir yetenek bulunamadı.";
                return "Böyle bir yetenek bulunamadı.";
            }
            public static string Add(bool result, string skillName)
            {
                if (result) return $"{skillName} isimli yetenek başarıyla eklenmiştir.";
                return $"{skillName} isimli yetenek eklenemedi.";
            }

            public static string Delete(bool result, string skillName)
            {
                if (result) return $"{skillName} isimli yetenek başarıyla silinmiştir.";
                return "Yetenek silinemedi";
            }
            public static string HardDelete(bool result, string skillName)
            {
                if (result) return $"{skillName} isimli yetenek kaydı başarıyla silinmiştir.";
                return "Yetenek kaydı silinemedi";
            }
            public static string Update(bool result, string skillName)
            {
                if (result) return $"{skillName} isimli yetenek başarıyla güncellenmiştir.";
                return $"{skillName} isimli yetenek güncellenemedi.";
            }
            public static string IsActiveChange(bool result, string skillName, string state)
            {
                if (result) return $"{skillName} isimli yetenek başarıyla {state} hale getirilmiştir.";
                return $"{skillName} isimli yetenek durumu güncellenemedi.";
            }
        }
        public static class SocialMedia
        {
            public static string Error(string proc, string errorMessage)
            {
                return $"{proc} yapılırken hata oluştu ! Hata : " + errorMessage;
            }
            public static string NotFound(bool isPlural)
            {
                if (isPlural) return "Hiç bir sosyal medya bulunamadı.";
                return "Böyle bir sosyal medya bulunamadı.";
            }
            public static string Add(bool result, string socialMedia)
            {
                if (result) return $"{socialMedia} isimli sosyal medya başarıyla eklenmiştir.";
                return $"{socialMedia} isimli sosyal medya eklenemedi.";
            }

            public static string Delete(bool result, string socialMedia)
            {
                if (result) return $"{socialMedia} isimli sosyal medya başarıyla silinmiştir.";
                return "Sosyal medya silinemedi";
            }
            public static string HardDelete(bool result, string socialMedia)
            {
                if (result) return $"{socialMedia} isimli sosyal medya kaydı başarıyla silinmiştir.";
                return "Sosyal medya kaydı silinemedi";
            }
            public static string Update(bool result, string socialMedia)
            {
                if (result) return $"{socialMedia} isimli sosyal medya başarıyla güncellenmiştir.";
                return $"{socialMedia} isimli sosyal medya güncellenemedi.";
            }
            public static string IsActiveChange(bool result, string socialMedia, string state)
            {
                if (result) return $"{socialMedia} isimli sosyal medya başarıyla {state} hale getirilmiştir.";
                return $"{socialMedia} isimli sosyal medya durumu güncellenemedi.";
            }
        }
        public static class User
        {
            public static string Error(string proc, string errorMessage)
            {
                return $"{proc} yapılırken hata oluştu ! Hata : " + errorMessage;
            }
            public static string NotFound(bool isPlural)
            {
                if (isPlural) return "Hiç bir kullanıcı bulunamadı.";
                return "Böyle bir kullanıcı bulunamadı.";
            }
            public static string Add(bool result, string user)
            {
                if (result) return $"{user} isimli kullanıcı başarıyla eklenmiştir.";
                return $"{user} isimli kullanıcı eklenemedi.";
            }

            public static string Delete(bool result, string user)
            {
                if (result) return $"{user} isimli kullanıcı başarıyla silinmiştir.";
                return "Kullanıcı silinemedi";
            }
            public static string HardDelete(bool result, string user)
            {
                if (result) return $"{user} isimli kullanıcı kaydı başarıyla silinmiştir.";
                return "Kullanıcı kaydı silinemedi";
            }
            public static string Update(bool result, string user)
            {
                if (result) return $"{user} isimli kullanıcı başarıyla güncellenmiştir.";
                return $"{user} isimli kullanıcı güncellenemedi.";
            }
            public static string IsActiveChange(bool result, string user, string state)
            {
                if (result) return $"{user} isimli kullanıcı başarıyla {state} hale getirilmiştir.";
                return $"{user} isimli kullanıcı durumu güncellenemedi.";
            }
        }
    }
}
