<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditGeneralInfo.aspx.cs" Inherits="SimpleServings.UI.Page.SimpleServings.Staff.EditGeneralInfo" %>

<%@ Register Src="../../../UDC/SimpleServings/Staff/AddEditStaff.ascx" TagName="AddEditStaff"
    TagPrefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form ID="form1" runat="server">
    <div>
        <uc1:AddEditStaff ID="AddEditStaff1" runat="server" IsUsedInWizard="false" />
    
    </div>
    </form>
</body>
</html>
