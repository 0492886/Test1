﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewMenuReport.aspx.cs" Inherits="SimpleServings.UI.Page.SimpleServings.Reports.ViewMenuReport" %>
<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=11.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ScriptManager ID="ScriptManager1" runat="server" ScriptMode="Release"></asp:ScriptManager>


<rsweb:ReportViewer ID="ReportViewer1" runat="server" Width="100%" height="1500px" ProcessingMode="Remote" Visible="false"></rsweb:ReportViewer>
   
        </div>
    </form>
</body>
</html>
