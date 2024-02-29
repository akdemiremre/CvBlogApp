using CvBlog.Entities.Concrete;
using Nancy.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CvBlog.Services.Utilities
{
    public static class Tool
    {
        public static string TextToTitleCase(string text)
        {
            TextInfo textInfo = new CultureInfo("tr-TR", false).TextInfo;
            text = textInfo.ToLower(text);
            return textInfo.ToTitleCase(text);
        }
        public static string TextToLowerCase(string text, bool isTrChar)
        {
            if (isTrChar)
            {
                TextInfo textInfo = new CultureInfo("tr-TR", false).TextInfo;
                return textInfo.ToLower(text);
            }
            else
            {
                TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
                return textInfo.ToLower(text);
            }
        }
        public static string TextToUpperCase(string text, bool isTrChar)
        {
            if (isTrChar)
            {
                TextInfo textInfo = new CultureInfo("tr-TR", false).TextInfo;
                return textInfo.ToUpper(text);
            }
            else
            {
                TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
                return textInfo.ToUpper(text);
            }
        }
        public static string DateTimeToMonthName(System.DateTime dateTime)
        {
            CultureInfo ci = new CultureInfo("tr-TR");
            return dateTime.ToString("MMMM", ci);
        }
        public static string PhoneNumberToDb(string text)
        {
            string phoneNumber = text.Replace(" ", null);
            phoneNumber = phoneNumber.Replace("(", null);
            phoneNumber = phoneNumber.Replace(")", null);
            return phoneNumber;
        }
        public static string DbDateTimeFormatChange(string text)
        {
            string[] datetimeArray = text.Split(" ");
            string[] dateeArray = datetimeArray[0].Split(".");
            return dateeArray[2] + "-" + dateeArray[1] + "-" + dateeArray[0] + " " + datetimeArray[1];
        }
        public static decimal MoneyFormatToDb(string money)

        {
            CultureInfo culture = new CultureInfo("tr-TR");
            decimal result = Convert.ToDecimal(money, culture);
            return result;
        }
        public static string MoneyFormatToView(string money)
        {
            if (string.IsNullOrEmpty(money) || money == "0" || money == "0,00")
            {
                return "0,00";
            }
            else
            {
                //return string.Format("{0:###,###.00}", Convert.ToDecimal(money));
                return Convert.ToDecimal(money).ToString("#,########0.00");
            }
        }
        public static void DeleteFilesAndFoldersRecursively(string target_dir)
        {
            if (Directory.Exists(target_dir))
            {
                foreach (string file in Directory.GetFiles(target_dir))
                {
                    File.Delete(file);
                }

                foreach (string subDir in Directory.GetDirectories(target_dir))
                {
                    DeleteFilesAndFoldersRecursively(subDir);
                }
                System.Threading.Thread.Sleep(100); // This makes the difference between whether it works or not. Sleep(0) is not enough.
                Directory.Delete(target_dir);
            }
        }
        public static string MySubString(string text, int length, bool dot)
        {
            if (text.Length > length)
            {
                if (dot)
                {
                    text = text.Substring(0, length) + "...";
                }
                else
                {
                    text = text.Substring(0, length);
                }
            }
            return text;
        }
        public static string CreatePassword(int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }
        /*
        public static string CreatePasswordHash(User user, string password)
        {
            var passwordHasher = new PasswordHasher<User>();
            return passwordHasher.HashPassword(user, password);
        }
        */
        public static string ImageToBase64String(string imgMapPath)
        {
            byte[] imageArray = System.IO.File.ReadAllBytes(imgMapPath);
            return Convert.ToBase64String(imageArray);
        }
        public static string StripTags(string text)
        {
            return Regex.Replace(text, "<.*?>", String.Empty);
        }
        public static string RandomValue(int count, bool isChar)
        {
            Random random = new Random();
            string randomValue = string.Empty;
            if (isChar)
            {
                for (int i = 1; i <= count; i++)
                {
                    if (i % 4 == 0 && i != count)
                    {
                        randomValue += random.Next(0, 9).ToString();
                        randomValue += "-";
                    }
                    else
                    {
                        randomValue += random.Next(0, 9).ToString();
                    }
                }
            }
            else
            {
                for (int i = 1; i <= count; i++)
                {
                    randomValue += random.Next(0, 9).ToString();
                }
            }
            return randomValue;
        }
        public static string ActivationCode(int count)
        {
            Random random = new Random();
            string randomValue = string.Empty;
            for (int i = 1; i <= count; i++)
            {
                randomValue += random.Next(0, 9).ToString();
            }
            return randomValue;
        }
        public static void FileDelete(string fileName)
        {
            string fullPath = Path.GetFullPath("wwwroot/" + fileName);
            if (System.IO.File.Exists(fullPath))
            {
                System.GC.Collect();
                System.GC.WaitForPendingFinalizers();
                System.IO.File.Delete(fullPath);
            }
        }
        public static string Slug2(this string phrase)
        {
            string str = phrase.RemoveAccent().ToLower();
            // invalid chars           
            str = Regex.Replace(str, @"[^a-z0-9\s-]", "");
            // convert multiple spaces into one space   
            str = Regex.Replace(str, @"\s+", " ").Trim();
            // cut and trim 
            str = str.Substring(0, str.Length <= 45 ? str.Length : 45).Trim();
            str = Regex.Replace(str, @"\s", "-"); // hyphens   
            return str;
        }
        public static string Slug(string url)
        {
            if (string.IsNullOrEmpty(url)) return "";
            url = url.ToLower();
            url = url.Trim();
            if (url.Length > 100)
            {
                url = url.Substring(0, 100);
            }
            url = url.Replace("İ", "I");
            url = url.Replace("ı", "i");
            url = url.Replace("ğ", "g");
            url = url.Replace("Ğ", "G");
            url = url.Replace("ç", "c");
            url = url.Replace("Ç", "C");
            url = url.Replace("ö", "o");
            url = url.Replace("Ö", "O");
            url = url.Replace("ş", "s");
            url = url.Replace("Ş", "S");
            url = url.Replace("ü", "u");
            url = url.Replace("Ü", "U");
            url = url.Replace("'", "");
            url = url.Replace("\"", "");
            char[] replacerList = @"$%#@!*?;:~`+=()[]{}|\'<>,/^&"".".ToCharArray();
            for (int i = 0; i < replacerList.Length; i++)
            {
                string strChr = replacerList[i].ToString();
                if (url.Contains(strChr))
                {
                    url = url.Replace(strChr, string.Empty);
                }
            }
            Regex regex = new Regex("[^a-zA-Z0-9_-]");
            url = regex.Replace(url, "-");
            while (url.IndexOf("--", StringComparison.Ordinal) > -1)
                url = url.Replace("--", "-");
            return url;
        }
        public static string RemoveAccent(this string txt)
        {
            byte[] bytes = System.Text.Encoding.GetEncoding("Cyrillic").GetBytes(txt);
            return System.Text.Encoding.ASCII.GetString(bytes);
        }
        public static string UploadImagePath(string Name, UploadImageType uploadImageType)
        {
            string FullPath = String.Empty;
            if (uploadImageType == UploadImageType.UserLogo)
            {
                FullPath = "/Content/Uploads/Users/" + Name;
            }
            else if (uploadImageType == UploadImageType.UserLogo)
            {
                FullPath = "/Content/Uploads/Firms/" + Name;
            }
            else if (uploadImageType == UploadImageType.FirmContactLogo)
            {
                FullPath = "/Content/Uploads/FirmContacts/" + Name;
            }
            else if (uploadImageType == UploadImageType.FirmContractLogo)
            {
                FullPath = "/Content/Uploads/FirmContracts/" + Name;
            }
            return FullPath;
        }
        //public static Task SendEmail(string email, string subject, string htmlMessage)
        //{


        //    var client = new SmtpClient(GetCustomer.customer.EmailHost, GetCustomer.customer.EmailPort)
        //    {
        //        Credentials = new NetworkCredential(GetCustomer.customer.EmailUserName, GetCustomer.customer.EmailPassword),
        //        EnableSsl = GetCustomer.customer.EmailEnableSSL
        //    };
        //    return client.SendMailAsync(
        //        new MailMessage(GetCustomer.customer.EmailUserName, email, subject, htmlMessage)
        //        {
        //            IsBodyHtml = true
        //        }
        //        );
        //}


        //public static string ConnectToSqlServer(string ServerName, string DatabaseName)
        //{
        //    SqlConnectionStringBuilder sqlBuilder = new SqlConnectionStringBuilder
        //    {
        //        DataSource = ServerName,
        //        InitialCatalog = DatabaseName,
        //        //PersistSecurityInfo = true,
        //        IntegratedSecurity = false,
        //        //MultipleActiveResultSets = true,

        //        //UserID = "Username",
        //        //Password = "Password",
        //    };
        //    var entityConnectionStringBuilder = new EntityConnectionStringBuilder
        //    {
        //        Provider = "System.Data.SqlClient",
        //        ProviderConnectionString = sqlBuilder.ConnectionString,
        //        // Metadata = "res://*/Data.Database.csdl|res://*/Data.Database.ssdl|res://*/Data.Database.msl",
        //    };

        //    return entityConnectionStringBuilder.ConnectionString;
        //}
        public static string Base64Encode(string text, int? count = 3)
        {
            string encodedText = null;
            for (int i = 1; i <= count; i++)
            {
                if (i == 1)
                {
                    var bytes = System.Text.Encoding.UTF8.GetBytes(text);
                    encodedText = System.Convert.ToBase64String(bytes);
                }
                else
                {
                    var bytes = System.Text.Encoding.UTF8.GetBytes(encodedText);
                    encodedText = System.Convert.ToBase64String(bytes);
                }
            }
            return encodedText;
        }
        public static string Base64Decode(string encodedText, int? count = 3)
        {
            string text = null;
            for (int i = 1; i <= count; i++)
            {
                if (i == 1)
                {
                    var bytes = System.Convert.FromBase64String(encodedText);
                    text = System.Text.Encoding.UTF8.GetString(bytes);
                }
                else
                {
                    var bytes = System.Convert.FromBase64String(text);
                    text = System.Text.Encoding.UTF8.GetString(bytes);
                }
            }
            return text;
        }
        //public static string GetIP()
        //{
        //    string IP = string.Empty;
        //    HttpContext current = HttpContext.Current;
        //    string IPAddress = current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];

        //    if (!string.IsNullOrEmpty(IPAddress))
        //    {
        //        string[] valAddress = IPAddress.Split(',');
        //        if (valAddress.Length != 0)
        //        {
        //            IP = valAddress[0];
        //            return IP;
        //        }
        //    }
        //    IP = current.Request.ServerVariables["REMOTE_ADDR"];
        //    return IP;
        //}
        public static string EncryptMD5(string val1)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(val1));
            byte[] result = md5.Hash;
            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                strBuilder.Append(result[i].ToString("x2"));
            }
            return strBuilder.ToString();
        }
        /*
        public static string EncHash(string _val)
        {
            return Crypto.EncDecr.EncHash(_val);
        }
        public static string DecrHash(string _val)
        {
            return Crypto.EncDecr.DecrHash(_val);
        }
        */
        public static string RemoveSpecialCharacters(this string str)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in str)
            {
                if ((c >= '0' && c <= '9') || (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || c == '.' || c == '_')
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }
        public static bool IsMobile(string UserAgent)
        {
            bool isMobile = false;
            if (UserAgent.Contains("iPhone") || UserAgent.Contains("Windows Phone") || UserAgent.Contains("Android"))
            {
                isMobile = true;
            }
            return isMobile;
        }

        public static bool IsValidCitizenNo(string tcKimlikNo)
        {
            bool returnvalue = false;
            if (tcKimlikNo.Length == 11)
            {
                Int64 ATCNO, BTCNO, TcNo;
                long C1, C2, C3, C4, C5, C6, C7, C8, C9, Q1, Q2;

                TcNo = Int64.Parse(tcKimlikNo);

                ATCNO = TcNo / 100;
                BTCNO = TcNo / 100;

                C1 = ATCNO % 10; ATCNO = ATCNO / 10;
                C2 = ATCNO % 10; ATCNO = ATCNO / 10;
                C3 = ATCNO % 10; ATCNO = ATCNO / 10;
                C4 = ATCNO % 10; ATCNO = ATCNO / 10;
                C5 = ATCNO % 10; ATCNO = ATCNO / 10;
                C6 = ATCNO % 10; ATCNO = ATCNO / 10;
                C7 = ATCNO % 10; ATCNO = ATCNO / 10;
                C8 = ATCNO % 10; ATCNO = ATCNO / 10;
                C9 = ATCNO % 10; ATCNO = ATCNO / 10;
                Q1 = ((10 - ((((C1 + C3 + C5 + C7 + C9) * 3) + (C2 + C4 + C6 + C8)) % 10)) % 10);
                Q2 = ((10 - (((((C2 + C4 + C6 + C8) + Q1) * 3) + (C1 + C3 + C5 + C7 + C9)) % 10)) % 10);

                returnvalue = ((BTCNO * 100) + (Q1 * 10) + Q2 == TcNo);
            }
            return returnvalue;
        }
        //public static ReturnModel CReturn(OptinalClass _OptinalClass)
        //{
        //    ReturnModel _ReturnModel = new ReturnModel();
        //    try
        //    {
        //        //ResourceManager _ResourceManager = new ResourceManager(typeof(Resource.Global));
        //        //string resourceValue = _ResourceManager.GetString(_OptinalClass.OptinalClass_msg, System.Threading.Thread.CurrentThread.CurrentUICulture);
        //        if (_OptinalClass.OptinalClass_val)
        //        {
        //            _ReturnModel.Status = Tool.ReturnModelTypeMapping(ReturnModelType.success);
        //            _ReturnModel.Title = Global.TransactionSuccessful;
        //            switch (_OptinalClass.OptinalClass_IDs)
        //            {
        //                case "0":
        //                    _ReturnModel.Message = Global.JokerDeleted.Replace("@", _OptinalClass.OptinalClass_msg);
        //                    break;
        //                case "1":
        //                    _ReturnModel.Message = Global.NewJokerAdded.Replace("@", _OptinalClass.OptinalClass_msg);
        //                    break;
        //                case "2":
        //                    _ReturnModel.Message = Global.JokerInformationUpdated.Replace("@", _OptinalClass.OptinalClass_msg);
        //                    break;
        //                default:
        //                    break;
        //            }
        //        }
        //        else if (!_OptinalClass.OptinalClass_val)
        //        {
        //            _ReturnModel.Status = Tool.ReturnModelTypeMapping(ReturnModelType.danger);
        //            _ReturnModel.Title = Global.TransactionFailed;
        //            switch (_OptinalClass.OptinalClass_IDs)
        //            {
        //                case "0":
        //                    _ReturnModel.Message = Global.JokerCouldNotBeDeleted.Replace("@", _OptinalClass.OptinalClass_msg);
        //                    break;
        //                case "1":
        //                    _ReturnModel.Message = Global.NewJokerCouldNotBeAdded.Replace("@", _OptinalClass.OptinalClass_msg);
        //                    break;
        //                case "2":
        //                    _ReturnModel.Message = Global.JokerInformationCouldNotBeUpdated.Replace("@", _OptinalClass.OptinalClass_msg);
        //                    break;
        //                default:
        //                    break;
        //            }
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //    }
        //    return _ReturnModel;
        //}
        public static T? isNull<T>(string valueToParse) where T : struct, IComparable
        {
            if (string.IsNullOrEmpty(valueToParse)) return null;
            try
            {
                // return parsed value
                return (T)Convert.ChangeType(valueToParse, typeof(T));
            }
            catch (Exception)
            {
                //default as null value
                return null;
            }
        }
        public static string DateForSql(string _val, string type)
        {
            //return ToDateTime(_val, new DateTime(1900, 1, 1)).ToString("yyyy-MM-dd", System.Globalization.CultureInfo.CreateSpecificCulture("tr-TR"));
            if (type == "1")
                return ToDateTime(_val, new DateTime(1900, 1, 1)).ToString("yyyy-MM-dd HH:mm", System.Globalization.CultureInfo.CreateSpecificCulture("tr-TR"));
            else if (type == "2")
                return ToDateTime(_val, new DateTime(1900, 1, 1)).ToString("yyyy-MM-dd HH:mm:ss", System.Globalization.CultureInfo.CreateSpecificCulture("tr-TR"));
            else
                return ToDateTime(_val, new DateTime(1900, 1, 1)).ToString("yyyy-MM-dd", System.Globalization.CultureInfo.CreateSpecificCulture("tr-TR"));
        }
        public static DateTime ToDateTime(string _val, DateTime _donus)
        {
            if (_val == null)
                return _donus;

            DateTime tmp = new DateTime(1900, 1, 1);

            if (DateTime.TryParse(_val, out tmp))
                return DateTime.Parse(_val);

            return _donus;
        }


        #region JsonConverts

        public static string AsJsonList<T>(List<T> tt)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            //serializer.MaxJsonLength = 2147483647;
            return serializer.Serialize(tt);
        }
        public static string AsJson<T>(T t)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            //serializer.MaxJsonLength = 2147483647;
            return serializer.Serialize(t);
        }
        public static List<T> AsObjectList<T>(string tt)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            //serializer.MaxJsonLength = 2147483647;
            return serializer.Deserialize<List<T>>(tt);
        }
        public static T AsObject<T>(string t)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            //serializer.MaxJsonLength = 2147483647;
            return serializer.Deserialize<T>(t);
        }
        #endregion

        //public static BootboxModel GetModalResource()
        //{
        //    BootboxModel _BootboxModel = new BootboxModel();
        //    _BootboxModel.ButtonCancel = Global.ModelButonCancel;
        //    _BootboxModel.ButtonYes = Global.ModelButonYes;
        //    _BootboxModel.ButtonNo = Global.ModelButonNo;
        //    _BootboxModel.ButtonOk = Global.ModelButonOk;
        //    _BootboxModel.Header = Global.ModelHeader;
        //    return _BootboxModel;
        //}
        //public static string ReturnModelTypeMapping(ReturnModelType val)
        //{
        //    Dictionary<ReturnModelType, string> ReturnModelTypeMapping = new Dictionary<ReturnModelType, string>()
        //    {
        //        {    Helper.ReturnModelType.danger, "danger" },
        //        {    Helper.ReturnModelType.info, "info" },
        //        {    Helper.ReturnModelType.success, "success" }
        //    };

        //    return ReturnModelTypeMapping.Where(x => x.Key == val).FirstOrDefault().Value;
        //}

    }
    public enum UploadImageType
    {
        UserLogo = 101,
        FirmLogo = 102,
        FirmContactLogo = 103,
        FirmContractLogo = 104
    }
}
