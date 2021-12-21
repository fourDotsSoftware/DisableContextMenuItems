using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace DisableContextMenuItems
{
    public partial class CustomTextBoxLabel : System.Windows.Forms.TextBox
    {
        // prepei prota sto designer na oriseis to Font.. allios exei null font kai de to bgazei sosta
        Font oldFont = null;
        int oldHeight = -1;

        private string _Caption = "";
        private bool _Enter = false;

        [Browsable(true)]
        public string Caption
        {
            get { return _Caption; }
            set { _Caption = value; }
        }

        public CustomTextBoxLabel()
        {
            InitializeComponent();            

            this.SetStyle(ControlStyles.UserPaint, true);
        }
        
        protected override void OnCreateControl()
        {
            oldFont = new System.Drawing.Font(Font.FontFamily, Font.Size, Font.Style, Font.Unit);            
        }
        
        protected override void OnPaint(PaintEventArgs e)
        {            
            base.OnPaint(e);
            if (this.Text == "")
            {
                e.Graphics.DrawString(TranslateHelper.Translate(Caption), this.Font, Brushes.Gray, new PointF(0, 0));
            }
        }

        protected override void OnTextChanged(EventArgs e)
        {
            if (this.Text == "")
            {
                this.SetStyle(ControlStyles.UserPaint, true);
            }
            else
            {
                this.SetStyle(ControlStyles.UserPaint, false);
                this.Font = oldFont;              
            }

            base.OnTextChanged(e);
        }
                
        protected override void OnEnter(EventArgs e)
        {
            if (this.Text != string.Empty)
            {
                this.SetStyle(ControlStyles.UserPaint, false);
                this.Font = oldFont;
            }
            //Invalidate();
            base.OnEnter(e);                    
            
        }

        
        protected override void OnLeave(EventArgs e)
        {
            if (this.Text == "")
            {
                this.SetStyle(ControlStyles.UserPaint, true);
                //Invalidate();
            }

            base.OnLeave(e);
        }

        private void ucAmount_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (!this._Enter)
            {
                this.SelectAll();
                this._Enter = true;
            }
        }

        private void ucAmount_Leave(object sender, System.EventArgs e)
        {
            this._Enter = false;

        }

    }
}
