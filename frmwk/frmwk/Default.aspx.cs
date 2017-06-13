using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace frmwk
{
	public partial class _Default : Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!IsPostBack)
			{
				TextBox1.Text = "0";
			}
			else
			{
				int iCnt = int.Parse(Request["TextBox1"]);
				TextBox1.Text = (iCnt + 1).ToString();
			}

		}
	}
}