<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="serverupload.aspx.cs" Inherits="task_02.serverupload" %>

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
                    <td>
                        Product Name:-
                    </td>
                    <td>
                        <asp:TextBox ID="name" runat="server" ></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        Upload image
                    </td>
                    <td>
                        <asp:FileUpload ID="image" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td>
                        
                        <asp:Button ID="btn" runat="server" Text="submit" OnClick="btn_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
