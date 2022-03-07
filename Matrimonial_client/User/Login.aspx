<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Matrimonial_client.User.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Login_Label" runat="server" Text="Login"></asp:Label>
            <br />
            <br />
            <br />
        </div>
        <asp:Label ID="username_Label" runat="server" Text="Username:"></asp:Label>
        <asp:TextBox ID="username_input" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="UsernameRequired" runat="server" ControlToValidate="username_input" ErrorMessage="*" ForeColor="#FF6699" ToolTip="Please Enter Username"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="UsernameValidator" runat="server" ControlToValidate="username_input" ErrorMessage="Please enter valid username" ForeColor="Red" ToolTip="Username must be of length 6 to 20 and contain One UPPERCASE One lowercase and one digit" ValidationExpression="((?=.\d)(?=.[a-z])(?=.*[A-Z]).{6,20})"></asp:RegularExpressionValidator>
        <br />
        <br />
        <asp:Label ID="password_Label" runat="server" Text="Password:    "></asp:Label>
        <asp:TextBox ID="password_input" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" ControlToValidate="password_input" ErrorMessage="*" ForeColor="#FF6699" ToolTip="Please Enter Password "></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="PasswordValidator" runat="server" ControlToValidate="password_input" ErrorMessage="Please enter valid password" ForeColor="Red" ToolTip="Password Must be of length 6 to 20 and Contain one UPPERCASE one lowercase one symbol and one digit" ValidationExpression="((?=.\d)(?=.[a-z])(?=.[A-Z])(?=.[\W]).{6,20})"></asp:RegularExpressionValidator>
        <br />
        <asp:HyperLink ID="forgot_password" runat="server" NavigateUrl="~/User/Forgot.aspx">Forgot password???</asp:HyperLink>
        <br />
        <br />
        <br />
        <asp:Button ID="login_button" runat="server" OnClick="login_button_Click" Text="Login" />
    </form>
</body>
</html>
