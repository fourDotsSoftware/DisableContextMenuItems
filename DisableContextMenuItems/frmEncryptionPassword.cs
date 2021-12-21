using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DisableContextMenuItems
{
    public partial class frmEncryptionPassword : DisableContextMenuItems.CustomForm 
    {
        private bool NewPassword = false;
        private int WrongPasswordTriesCount = 0;
        private bool NotifyOK = false;

        public frmEncryptionPassword()
        {
            InitializeComponent();
        }
        

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;

            Environment.Exit(0);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string oldpass = RegistryHelper.GetAppRegistryKeyValue("Password", true);
            
            if (oldpass != null && oldpass != XOREncrypter.EncryptDecrypt(txtEncryptionPassword.Text))
            {
                Module.ShowMessage("Wrong Password !");

                txtEncryptionPassword.Text = "";

                WrongPasswordTriesCount++;

                if (WrongPasswordTriesCount == 3)
                {
                    Environment.Exit(0);
                }

                return;
            }
            else
            {
                NotifyOK = true;
            }

            this.DialogResult = DialogResult.OK;
        }

        private void frmEncryptionPassword_Load(object sender, EventArgs e)
        {            
            this.Text = Module.ShortApplicationTitle + " "+this.Text;

            txtEncryptionPassword.Font = new Font(txtEncryptionPassword.Font.FontFamily, 10f);
        }

        private void frmEncryptionPassword_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!NotifyOK)
            {
                e.Cancel = true;
            }
        }
    }
}

