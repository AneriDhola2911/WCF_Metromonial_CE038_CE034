<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Reset.aspx.cs" Inherits="Matrimonial_client.User.Reset" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Reset Password"></asp:Label>
        <br />
        <br />
        <asp:Label ID="password_Label" runat="server" Text="Password"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="password_input" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" ControlToValidate="password_input" ErrorMessage="*" ForeColor="#FF6699" ToolTip="Please Enter Password "></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="PasswordValidator" runat="server" ControlToValidate="password_input" ErrorMessage="Please enter valid password" ForeColor="Red" ToolTip="Password Must be of length 6 to 20 and Contain one UPPERCASE one lowercase one symbol and one digit" ValidationExpression="((?=.\d)(?=.[a-z])(?=.[A-Z])(?=.[\W]).{6,20})"></asp:RegularExpressionValidator>
        <br />
        <br />
        <asp:Label ID="Confirmpassword_Label" runat="server" Text="Confirm Password"></asp:Label>

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="confirm_password" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="ConfirmPasswordRequired" runat="server" ControlToValidate="confirm_password" ErrorMessage="*" ForeColor="#FF6699" ToolTip="Please Enter Confirm Password"></asp:RequiredFieldValidator>
            <asp:CompareValidator ID="ConfirmPasswordValidator" runat="server" ControlToCompare="password_input" ControlToValidate="confirmpassword" ErrorMessage="Password and Confirm password must be same " ForeColor="Red"></asp:CompareValidator>
&nbsp;&nbsp;
        <br />
        <br />
        <br />
        <asp:Button ID="Reset_button" runat="server" OnClick="Reset_button_Click" Text="Reset" />
        <br />
    </form>
</body>
</html>
