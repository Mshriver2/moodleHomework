<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Final_Project._Default" %>



<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                
                <h2>Max's Homework Page</h2>
            </hgroup>
            

            
        </div>
    </section>
    

</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    
    
    
    <div id="header">

        
        <p>
        <asp:Label ID="Label1" runat="server" Font-Size="X-Large" Text="Your Classes"></asp:Label>
       
        </p>

        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Get Classes" />

        <br  />
    <p>
        
        <asp:TextBox ID="TextBox2" runat="server" Height="16px" Width="273px"></asp:TextBox>
        <asp:TextBox ID="TextBox3" runat="server" Height="16px" Width="273px"></asp:TextBox>
        <asp:TextBox ID="TextBox4" runat="server" Height="16px" Width="273px"></asp:TextBox>
        <asp:TextBox ID="TextBox5" runat="server" Height="16px" Width="273px"></asp:TextBox>
        <asp:TextBox ID="TextBox6" runat="server" Height="16px" Width="273px"></asp:TextBox>
        <asp:TextBox ID="TextBox7" runat="server" Height="16px" Width="273px"></asp:TextBox>
        <asp:TextBox ID="TextBox8" runat="server" Height="16px" Width="273px"></asp:TextBox>
        <asp:TextBox ID="TextBox9" runat="server" Height="16px" Width="273px"></asp:TextBox>
        <asp:TextBox ID="TextBox10" runat="server" Height="16px" Width="273px"></asp:TextBox>
        <asp:TextBox ID="TextBox11" runat="server" Height="16px" Width="273px"></asp:TextBox>
       
    </p>
    </div>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    
        <div><%=Class1 %></div>
       
    
    <br />
    <div><%=Class2 %></div>
    <br />
    <p>
        
    </p>
    <br />
    
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;
        
        
    </p>




</asp:Content>
