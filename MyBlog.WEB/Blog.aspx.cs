using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyBlog.WEB.Models;
using MyBlog.WEB;

namespace MyBlog.WEB
{
    public partial class Blog : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using (var context = new BlogContext())
            {
                Usuario user = new Usuario()
                {
                    Nome = nomeInput.Value,
                    email = emailInput.Value,
                    DataCadastro = DateTime.Now
                };
                Post post = new Post()
                {
                    Titulo = tituloInput.Value,
                    Texto = textoInput.Value,
                    Autor = user.Nome,
                    DataCadastro = DateTime.Now,
                    Area = areaInput.Value
                };
                context.Usuarios.Add(user);
                context.Posts.Add(post);
                context.SaveChanges();

            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            nomeInput.Value = "";
            emailInput.Value = "";
            tituloInput.Value = "";
            textoInput.Value = "";
        }

    }
}