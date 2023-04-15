<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="WebApplication1.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <input name="tboxName" placeholder="your name" />
        </div>
        <div>
            <input name="tboxAge" placeholder="your age" />
        </div>
        <div>
            <input name="tboxBirthday" type="datetime-local" />
        </div>
        <div>
            <select name="lboxGender">
                <option value="0">Male</option>
                <option value="1">Female</option>
            </select>
        </div>
        <button type="submit">Submit</button>
        <div>
            <asp:Label ID="labName" runat="server"></asp:Label>
        </div>
        <div>
            <asp:Label ID="labAge" runat="server"></asp:Label>
        </div>
        <div>
            <asp:Label ID="labBirthday" runat="server"></asp:Label>
        </div>
        <div>
            <asp:Label ID="labGender" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
