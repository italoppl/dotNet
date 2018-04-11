<%@ Page Language="C#" Title="My Blog" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Blog.aspx.cs" Inherits="MyBlog.WEB.Blog" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server"> 
    <h2><%: Title %></h2>
    <h3></h3>
    <formview>
        <div class="form-group">
           <label>Nome</label>
           <input type="text" class="form-control" name="nomeInput" id="nomeInput"  placeholder="Digite seu Nome" runat="server">
        </div>
        <div class="form-group">
           <label>Email</label>
           <input type="email" class="form-control" id="emailInput" aria-describedby="emailHelp" placeholder="Digite seu Email" runat="server">
        </div>
        <div class="form-group">
           <label>Titulo do Post</label>
           <input type="text" class="form-control" id="tituloInput"  placeholder="Insira o Titulo do Post" runat="server">
        </div>
        <div class="form-group">
            <label>Texto</label>
            <textarea class="form-control" id="textoInput" rows="3" runat="server"></textarea>
        </div>
        <div class="form-group">
            <label>Categoria do Post</label>
            <select class="form-control" id="areaInput" runat="server">
                <option>Esporte</option>
                <option>Politica</option>
                <option>Universidade</option>
                <option>Musica</option>
                <option>Outros</option>
                
            </select>
        </div>
        <button type="submit" class="btn btn-outline-primary"  onserverClick="Button1_Click" runat="server">Postar</button>
        <button type="submit" class="btn btn-outline-primary"  onserverClick="Button2_Click" runat="server">Limpar</button>
   
    </formview>
</asp:Content>