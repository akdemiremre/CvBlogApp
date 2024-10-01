using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvBlog.Entities.Dtos
{
    public class UploadedImageDto
    {
        public string FullName { get; set; } // YÜKELRKEN VERDİĞİMİZ İSİM
        public string OldName { get; set; } // BİZE GELEN İSİM
        public string Extension { get; set; } // UZANTISI
        public string Path { get; set; } // TAM YOLU
        public string FolderName { get; set; } // KLASÖR İSMİ
        public long Size { get; set; } // RESMİN BOYUTU
    }
}
