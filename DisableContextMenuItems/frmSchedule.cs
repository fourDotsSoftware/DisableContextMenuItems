using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DisableContextMenuItems
{
    public partial class frmSchedule : DisableContextMenuItems.CustomForm
    {
        public frmSchedule()
        {
            InitializeComponent();
        }

        private void frmSchedule_Load(object sender, EventArgs e)
        {
            cmbSchedule.Items.Add(TranslateHelper.Translate("Always"));
            cmbSchedule.Items.Add(TranslateHelper.Translate("On Schedule"));

            cmbSchedule.SelectedIndex = 0;

            dtStart.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
            dtEnd.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 59, 59);
        }

        private void cmbSchedule_SelectedIndexChanged(object sender, EventArgs e)
        {
            HideAll();
            
            if (cmbSchedule.SelectedIndex==1)
            {
                lblSEnd.Visible = true;
                lblSStart.Visible = true;
                lblSWeek.Visible = true;
                dtStart.Visible = true;
                dtEnd.Visible = true;
                chkFri.Visible = true;
                chkMon.Visible = true;
                chkSat.Visible = true;
                chkSun.Visible = true;
                chkThu.Visible = true;
                chkTue.Visible = true;
                chkWed.Visible = true;
            }
        }

        private void HideAll()
        {            
            lblSEnd.Visible = false;
            lblSStart.Visible = false;
            lblSWeek.Visible = false;
            dtStart.Visible = false;
            dtEnd.Visible = false;
            chkFri.Visible = false;
            chkMon.Visible = false;
            chkSat.Visible = false;
            chkSun.Visible = false;
            chkThu.Visible = false;
            chkTue.Visible = false;
            chkWed.Visible = false;            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

        }
    }
}
