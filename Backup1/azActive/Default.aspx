<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Default.aspx.vb" Inherits="azActive._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >

<head runat="server">
    <title>az_Active : Laser Marking System</title>
    <style type="text/css">
        .style1
        {
            width: 109px;
        }
    </style>
</head>


<body>
    <link rel="SHORTCUT ICON" href="imtest.ico" />

    <form id="form1" runat="server">
    <div>
    
        <asp:Image ID="Image1" runat="server" Height="289px" ImageUrl="ac_Title.png" 
            Width="1260px" />
    
        <div style="width: 1130px; margin-left: 40px; font-family: Tahoma; font-size: small; font-variant: normal; color: #006666; table-layout: fixed; white-space: normal; word-spacing: normal; letter-spacing: normal; height: 322px;">
            Type the Lot No. to check the status of the Lot...&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server" AutoPostBack="True"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                ControlToValidate="TextBox1" ErrorMessage="Enter Lot No. here !!!"></asp:RequiredFieldValidator>
            &nbsp;&nbsp;&nbsp;

            <br />
            <br />
            <asp:HyperLink ID="HyperLink1" runat="server" 
                NavigateUrl="~/UpLoadSpecFile.aspx">Click here to upload new spec. file to 
            the system...</asp:HyperLink>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
            <br />
            <br />

            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
            <br />
            <br />

            <table style="padding: inherit; margin: inherit; width: 45%; font-family: Tahoma; position: relative; top: -362px; left: 492px; z-index: auto;">
                <tr>
                    <td class="style1">
                        <asp:Label ID="lbl_LotNo" runat="server" Text="Lot No" Visible="False"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="lbl_LotNo_" runat="server" Text="Label" Visible="False"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="style1">
                        <asp:Label ID="lbl_IMINo" runat="server" Text="IMI No." Visible="False"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="lbl_IMINo_" runat="server" Text="Label" Visible="False"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="style1">
                        <asp:Label ID="lbl_FreqVal" runat="server" Text="Frequency" Visible="False"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="lbl_FreqVal_" runat="server" Text="Label" Visible="False"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="style1">
                        <asp:Label ID="lbl_Opt" runat="server" Text="Operator" Visible="False"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="lbl_Opt_" runat="server" Text="Label" Visible="False"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="style1">
                        <asp:Label ID="lbl_DateVal" runat="server" Text="Marking Date" Visible="False"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="lbl_DateVal_" runat="server" Text="Label" Visible="False"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="style1">
                        <asp:Label ID="lbl_Profile" runat="server" Text="Profile Name" Visible="False"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="lbl_Profile_" runat="server" Text="Label" Visible="False"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="style1">
                        <asp:Label ID="lbl_MacNo" runat="server" Text="Machine No." Visible="False"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="lbl_MacNo_" runat="server" Text="Label" Visible="False"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="style1">
                        <asp:Label ID="lbl_MData1" runat="server" Text="Marking Data 1" Visible="False"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="lbl_MData1_" runat="server" Text="Label" Visible="False"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="style1">
                        <asp:Label ID="lbl_MData2" runat="server" Text="Marking Data 2" Visible="False"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="lbl_MData2_" runat="server" Text="Label" Visible="False"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="style1">
                        <asp:Label ID="lbl_MData3" runat="server" Text="Marking Data 3" Visible="False"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="lbl_MData3_" runat="server" Text="Label" Visible="False"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="style1">
                        <asp:Label ID="lbl_MData4" runat="server" Text="Marking Data 4" Visible="False"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="lbl_MData4_" runat="server" Text="Label" Visible="False"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="style1">
                        <asp:Label ID="lbl_MData5" runat="server" Text="Marking Data 5" Visible="False"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="lbl_MData5_" runat="server" Text="Label" Visible="False"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="style1">
                        <asp:Label ID="lbl_MData6" runat="server" Text="Marking Data 6" Visible="False"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="lbl_MData6_" runat="server" Text="Label" Visible="False"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="style1">
                    </td>
                    <td>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btn_DelRec" runat="server" Text="Delete This Record!" 
                            ForeColor="#CC0000" Visible="False" Width="130px" 
                            ToolTip="Permenantly remove the selected record from the database." />
                    </td>
                </tr>
                
            </table>
            <br />
        </div>
        
    </div>
    
    </form>
</body>
</html>
