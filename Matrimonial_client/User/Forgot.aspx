<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Forgot.aspx.cs" Inherits="Matrimonial_client.User.Forgot" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="email" runat="server" Text="Email"></asp:Label>
&nbsp;&nbsp;&nbsp; :<asp:TextBox ID="email_input" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="EmailRequired" runat="server" ControlToValidate="email_input" ErrorMessage="*" ForeColor="#FF6699" ToolTip="Please Enter Email"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="EmailValidator" runat="server" ControlToValidate="email_input" ErrorMessage="Please enter a valid email" ForeColor="Red" ToolTip="email must be of form xyz@abc.com" ValidationExpression="\w+([-+.']\w+)@\w+([-.]\w+)\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
        </div>
        <asp:Button ID="submit" runat="server" OnClick="submit_Click" Text="Submit" />
    </form>
</body>
</html>
