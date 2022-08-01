﻿using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Configuration;
using System.Web.Caching;
using SimpleServingsLibrary.Shared;

namespace SimpleServings.UI.testPage
{
    public partial class dashboard : System.Web.UI.Page
    {
        protected System.Web.UI.WebControls.Label lblSingleCouple;
        protected System.Web.UI.WebControls.Label lblFamily;
        protected System.Web.UI.WebControls.Label lblAcceptingReferrals;
        protected System.Web.UI.WebControls.Label lblMsg;
        protected System.Web.UI.WebControls.Label lblUserName;
        protected System.Web.UI.WebControls.TextBox txtSearchBy;
        protected System.Web.UI.WebControls.Image comicStrip;
        protected System.Web.UI.WebControls.Image ImgComicStrip;
        private void PopAnnouncements()
        {

    }
/********
        private void Authorize()
        {

            if (Session["UserObject"] != null)
            {
                this.dvLoggedIn.Visible = true;
                this.dvLogIn.Visible = false;
            }
            else
            {
                this.dvLoggedIn.Visible = false;
                this.dvLogIn.Visible = true;
            }
        }
        #region Web Form Designer generated code
        override protected void OnInit(EventArgs e)
        {
            //
            // CODEGEN: This call is required by the ASP.NET Web Form Designer.
            //
            InitializeComponent();
            base.OnInit(e);
        }

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {

        }
        #endregion

        private string SearchBy()
        {
            if (rbCaseNumber.Checked)
                return "CaseNumber";
            //else if (rbCase.Checked )return "Case";
            else if (rbName.Checked)
                return "Name";
            else if (rbSSN.Checked)
                return "SSN";
            else if (rbFHNumber.Checked)
                return "FairHearingNumber";
            else
                return "";
        }




        protected void Page_Load(object sender, System.EventArgs e)
        {

            if (Page != null)
            {
                Page.RegisterRequiresViewStateEncryption();
            }
            Authorize();
            if (!Page.IsPostBack)
            {
                Utility.SetFocus(this.Page, this.txtUserName);
                PopAnnouncements();
            }


        }



        protected void btnLogin_Click(object sender, System.EventArgs e)
        {
            //Simple Servings Authentication

            if (SimpleServingsLibrary.Shared.Staff.Authenticate(txtUserName.Text, txtPassword.Text))
            {
                SimpleServingsLibrary.Shared.Staff facesStaff = new SimpleServingsLibrary.Shared.Staff();
                facesStaff.GetStaffByUserNameAndPassword(txtUserName.Text, txtPassword.Text);
                Session["UserObject"] = facesStaff;
                if (facesStaff.ForcePasswordChange)
                {
                    int staffID = facesStaff.StaffID;
                    Session["UserObject"] = null;
                    string passwordURL = ResolveUrl("~/UI/Page/SimpleServings/Staff/ForcePasswordChange.aspx");
                    Response.Redirect(passwordURL + "?StaffID=" + facesStaff.StaffID);
                }
                else Response.Redirect("~/UI/Page/Dashboard.aspx");
            }

            else
            {
                Response.Redirect("~/UI/Page/Login.aspx");
            }

        }

        protected void btnLogout_Click(object sender, System.EventArgs e)
        {
            Session["UserObject"] = null;
            Session.Abandon();
            Response.Redirect("~/UI/Page/Home.aspx");
        }

        protected void btnSearch_Click(object sender, System.EventArgs e)
        {
            //Session["ClientSearchLink"] = "~/UI/Page/CaseClient/CaseSearch.aspx?SearchType=" + SearchBy() + "&Key=" + txtSearchKey.Text.Trim();

            //Response.Redirect("~/UI/Page/CaseClient/CaseSearch.aspx?SearchType=" + SearchBy() + "&Key=" + txtSearchKey.Text.Trim());

        }

        protected void lnkPassword_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/UI/Page/SimpleServings/Staff/ForgotPassword.aspx");
        }
        
********/
    }
}