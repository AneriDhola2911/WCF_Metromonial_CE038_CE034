<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Signup.aspx.cs" Inherits="Matrimonial_client.User.Signup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="User_Registartion" runat="server" Text="User Registration:"></asp:Label>
        <br />
        <br />
        <br />
        <asp:Label ID="UserName_Label" runat="server" Text="UserName:"></asp:Label>
        <asp:TextBox ID="UserName_Input" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="UsernameRequired" runat="server" ControlToValidate="UserName_Input" ErrorMessage="*" ForeColor="#FF6699" ToolTip="Please Enter Username"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="UsernameValidator" runat="server" ControlToValidate="UserName_Input" ErrorMessage="Please enter valid username" ForeColor="Red" ToolTip="Username must be of length 6 to 20 and contain One UPPERCASE One lowercase and one digit" ValidationExpression="((?=.\d)(?=.[a-z])(?=.*[A-Z]).{6,20})"></asp:RegularExpressionValidator>
        <br />
        <br />
        <asp:Label ID="Email_Label" runat="server" Text="Email:"></asp:Label>
        <asp:TextBox ID="Email_Input" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="EmailRequired" runat="server" ControlToValidate="Email_Input" ErrorMessage="*" ForeColor="#FF6699" ToolTip="Please Enter Email"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="EmailValidator" runat="server" ControlToValidate="Email_Input" ErrorMessage="Please enter a valid email" ForeColor="Red" ToolTip="email must be of form xyz@abc.com" ValidationExpression="\w+([-+.']\w+)@\w+([-.]\w+)\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
        <br />
        <br />
        <asp:Label ID="Mobileno_Label" runat="server" Text="Mobile No.:"></asp:Label>
        <asp:TextBox ID="Mobileno_Input" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="MobileNoRequired" runat="server" ControlToValidate="Mobileno_Input" ErrorMessage="*" ForeColor="#FF6699" ToolTip="Please Enter Mobile Number"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="MobileNoValidator" runat="server" ControlToValidate="Mobileno_Input" ErrorMessage="Please enter a valid mobile number" ForeColor="Red" ToolTip="Mobile Must be of 10 digit" ValidationExpression="[0-9]{10}"></asp:RegularExpressionValidator>
        <br />
        <br />
        <asp:Label ID="Password_Label" runat="server" Text="Password:"></asp:Label>
        <asp:TextBox ID="Password_Input" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" ControlToValidate="Password_Input" ErrorMessage="*" ForeColor="#FF6699" ToolTip="Please Enter Password "></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="PasswordValidator" runat="server" ControlToValidate="Password_Input" ErrorMessage="Please enter valid password" ForeColor="Red" ToolTip="Password Must be of length 6 to 20 and Contain one UPPERCASE one lowercase one symbol and one digit" ValidationExpression="((?=.\d)(?=.[a-z])(?=.[A-Z])(?=.[\W]).{6,20})"></asp:RegularExpressionValidator>
        <br />
        <br />
        <asp:Label ID="ConfirmPass_Label" runat="server" Text="Confirm Password:"></asp:Label>
        <asp:TextBox ID="ConfirmPass_Input" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="ConfirmPasswordRequired" runat="server" ControlToValidate="ConfirmPass_Input" ErrorMessage="*" ForeColor="#FF6699" ToolTip="Please Enter Confirm Password"></asp:RequiredFieldValidator>
        <asp:CompareValidator ID="ConfirmPasswordValidator" runat="server" ControlToCompare="Password_Input" ControlToValidate="cpassword" ErrorMessage="Password and Confirm password must be same " ForeColor="Red"></asp:CompareValidator>
        <br />
        <br />
        <br />
        <asp:Button ID="Register_Button" runat="server" OnClick="Register" Text="Register" />
        <br />
    </form>
</body>
</html>
