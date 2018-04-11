using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyBlog.WEB.Models
{
    public class Usuario
    {
        public int usuarioID { get; set; }
        public String Nome { get; set; }
        public DateTime DataCadastro { get; set; }
        public String email { get; set; }
    }
}