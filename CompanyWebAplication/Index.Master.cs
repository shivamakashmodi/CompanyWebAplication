﻿using BodyObject.BaseClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CompanyWebAplication
{
    public partial class Index : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var isMobile = Request.Browser.IsMobileDevice;
            if (isMobile)
            {

            }
        }

        protected void BtnSignupModalSubmit_Click(Object sender, EventArgs e)
        {
            Response.Write("hwllndckjnsjd");
            string encryptedPwd = FormsAuthentication.HashPasswordForStoringInConfigFile(txtPassword.Value, "SHA1");
            BaseUser baseUser = new BaseUser();
            baseUser.LoginId = txtLoginID_Username.Value.ToString();
            baseUser.Password = encryptedPwd;

            Response.Write("<script>alert('Called');</script>");
        }
    }
}