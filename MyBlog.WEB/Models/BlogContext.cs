using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MyBlog.WEB.Models
{
    public class BlogContext : DbContext 
    {
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comentario> Comentarios { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        public BlogContext()
            : base("BancoDeDadosBlog")
        {

        }
    }
}