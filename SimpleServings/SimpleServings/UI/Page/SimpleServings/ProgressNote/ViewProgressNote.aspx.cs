using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

namespace SimpleServings.UI.Page.SimpleServings.ProgressNote
{
    public partial class ViewProgressNote : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Request["MailMessage"] != null)
                    lblMailMsg.Text = Request["MailMessage"].ToString();

            }

        }
    }
}