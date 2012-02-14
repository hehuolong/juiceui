﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Juice_Sample_Site {
	public partial class Slider : System.Web.UI.Page {

        public void Page_Load() {
            if (!IsPostBack) {
                slider1.Value = 50;
            }
        }

		protected void slider_Change(object sender, EventArgs e) {
            currentValue.Text = ((Juice.Slider)sender).Value.ToString();
		}
	}
}