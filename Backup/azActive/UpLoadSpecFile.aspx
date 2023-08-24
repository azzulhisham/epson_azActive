<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="UpLoadSpecFile.aspx.vb" Inherits="azActive.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>az_Active : Laser Marking System</title>
</head>
<body>
    <link rel="SHORTCUT ICON" href="imtest.ico" />

    <form id="form1" runat="server">
    <div>
    
        <asp:Image ID="Image1" runat="server" Height="289px" ImageUrl="ac_Title.png" 
            Width="1260px" />
    
    </div>
    
    <div style="font-family: Tahoma; color: #336699; font-size: small; margin-left: 40px;">
    
        Locate the new spec. file here...&nbsp;&nbsp;&nbsp;
        <asp:FileUpload ID="FileUpload1" runat="server" Width="432px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:LinkButton ID="LinkButton1" runat="server">Go...</asp:LinkButton>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
            ControlToValidate="FileUpload1" 
            ErrorMessage="Please provide a valid file path... "></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="lbl_Msg" runat="server" ForeColor="#006600" Visible="False"></asp:Label>
        <br />
        <br />
        <br />
        
    
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Default.aspx">Return 
        To Home</asp:HyperLink>
        
    
    </div>

    </form>
</body>
</html>
