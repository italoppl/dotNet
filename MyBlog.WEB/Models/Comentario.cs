using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyBlog.WEB.Models
{
    public class Comentario
    {
        public int ComentarioID { get; set; }
        public String Texto { get; set; }
        public DateTime Data { get; set; }

    }
}