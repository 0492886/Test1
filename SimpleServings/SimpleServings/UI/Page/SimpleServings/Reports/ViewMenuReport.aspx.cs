﻿using Microsoft.Reporting.WebForms;
using SimpleServings.UI.UDC.SimpleServings.Reports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SimpleServings.UI.Page.SimpleServings.Reports
{
    public partial class ViewMenuReport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int MenuID = Convert.ToInt32(Request.QueryString["MenuID"]);

                Session["MenuID"] = Request.QueryString["MenuID"];

                string acctUserName = "SSRSuser";
                string acctPassword = "Aging@123";
                string acctDomain = "DFTA";
                IReportServerCredentials irsc = new CustomReportCredentials(acctUserName, acctPassword, acctDomain);
                ReportViewer1.ServerReport.ReportServerCredentials = irsc;

                this.ReportViewer1.ServerReport.ReportServerUrl = new Uri(System.Configuration.ConfigurationManager.AppSettings["ReportServerURL"]);

                string ReportPath = "/SimpleServings/Menu_Item_by_MenuID_ML";

                this.ReportViewer1.ServerReport.ReportPath = ReportPath;

                List<ReportParameter> rptparam = SetReportParam();

                this.ReportViewer1.ServerReport.SetParameters(rptparam);

                //ReportViewer1.Visible = true;
                //ReportViewer1.ShowPrintButton = true;
                //this.ReportViewer1.ServerReport.Refresh();

                Warning[] warnings;
                string[] streamids;
                string mimeType, encoding, extension;
                byte[] bytes = ReportViewer1.ServerReport.Render("PDF", null, out mimeType, out encoding, out extension, out streamids, out warnings);
                Response.Buffer = true;
                Response.Clear();
                Response.ContentType = mimeType;
                Response.AddHeader("content-disposition", "attachment; filename=" + "reportname" + "." + extension);
                Response.BinaryWrite(bytes); // create the file
                Response.Flush(); // send it to the client to download




            }

        }



        private List<ReportParameter> SetReportParam()
        {

            List<ReportParameter> rptparam = new List<ReportParameter>();
            rptparam.Add(CreateReportParameter("MenuID", Session["MenuID"].ToString()));

            return rptparam;

        }


        private ReportParameter CreateReportParameter(String paramName, String paramValue)
        {
            ReportParameter rptparam = new ReportParameter(paramName, paramValue);
            return rptparam;

        }







    }
}