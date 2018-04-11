using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyBlog.WEB.Models
{
    public class Post
    {
        public int postID { get; set; }
        public String Titulo { get; set; }
        public DateTime DataCadastro { get; set; }
        public String Texto { get; set; }
        public String Autor { get; set; }
        public ICollection<Comentario> Comentarios { get; set; }
        public String Area { get; set; }
    }
}