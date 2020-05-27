<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="InProc.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
              <table>
                <tr>
                    <td colspan="2"><h1>Web Page 1</h1></td>
                </tr>
                <tr>
                    <td>Name:</td>
                    <td><asp:Label ID="lblName" runat="server"></asp:Label></td>
                </tr>
                <tr>
                    <td>Mobile:</td>
                    <td><asp:Label ID="lblMobile" runat="server"></asp:Label></td>
                </tr>
                
            </table>
        </div>
    </form>
</body>
</html>
