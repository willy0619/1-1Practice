﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _1_1Practice {
    public partial class Demo : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            Response.Write("Hi222");
            Response.Write("Demo can run.");
        }
    }
}