using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CharityWebSite.Models
{
    public class File
    {
        public int FileId { get; set; }

        [Display(Name = "File Name")]
        [StringLength(255)]
        public string FileName { get; set; }

        [Display(Name = "Content Type")]
        public string ContentType { get; set; }
        public byte[] Content { get; set; }
        public FileType FileType { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}