<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div>

        <h1  style="text-align:center;">
            User Management System
        </h1><br />
        <btn type="button" class="btn btn-primary">Add new User</btn>
         </div>
     </div><br /><br />
        <table class="table table-striped">
  <thead>
    <tr>
      <th scope="col">Employee id</th>
      <th scope="col">Employee name</th>
      <th scope="col">Employee salary</th>
      <th scope="col">Update</th>
      <th scope="col">Delete</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <th scope="row">empid</th>
      <td>emname</td>
      <td>empsal</td>
      <td> <a href="register.aspx" class="btn btn-info" role="button">update</a></td>
      <td><a href="#" class="btn btn-danger" role="button">delete</a></td>
    </tr>
  
  </tbody>
</table>

    </div>

</asp:Content>
