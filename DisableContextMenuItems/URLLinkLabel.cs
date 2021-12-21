﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DisableContextMenuItems
{
    public class URLLinkLabel : System.Windows.Forms.LinkLabel 
    {
        public URLLinkLabel()
            : base()
        {

        }

        protected override void OnClick(EventArgs e)
        {
            System.Diagnostics.Process.Start(this.Text);
        }
    }
}
