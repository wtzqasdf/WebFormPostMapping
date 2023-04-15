using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class index : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                IndexModel model = GetPost<IndexModel>();
                labName.Text = $"Name: {model.Name}";
                labAge.Text = $"Age: {model.Age}";
                labBirthday.Text = $"Birthday: {model.Birthday}";
                labGender.Text = $"Gender: {model.Gender}";
            }
        }
    }
}