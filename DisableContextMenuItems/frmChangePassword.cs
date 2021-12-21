using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DisableContextMenuItems
{
    public partial class frmChangePassword : DisableContextMenuItems.CustomForm 
    {
        private bool NewPassword = false;
        private int WrongPasswordTriesCount = 0;

        public frmChangePassword(bool new_password)
        {
            InitializeComponent();
            NewPassword = new_password;
            //NewPassword = true;

            if (NewPassword)
            {
                lblOldPassword.Visible = false;
                txtOldPassword.Visible = false;

                this.Text = TranslateHelper.Translate("Please enter New Password");
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string oldpass = null;

            if (!NewPassword)
            {
                oldpass = RegistryHelper.GetAppRegistryKeyValue("Password", true);

                if (oldpass == null)
                {
                    Module.ShowMessage("Error could not read Settings !");
                    return;
                }
            }            
            
            if (!NewPassword && oldpass != XOREncrypter.EncryptDecrypt(txtOldPassword.Text))
            {
                Module.ShowMessage("You have entered a wrong Old Password !");                              

                return;
            }
            
            if (txtNewPassword.Text != txtConfirmNewPassword.Text)
            {
                Module.ShowMessage("The New Password and the Confirm New Password Values are different !");

                return;

            }

            if (RegistryHelper.SetAppRegistryKeyValue("Password", XOREncrypter.EncryptDecrypt(txtNewPassword.Text),true))
            {

                if (NewPassword)
                {
                    Module.ShowMessage("Password was set successfully !");

                }
                else
                {
                    Module.ShowMessage("Password changed successfully !");
                }
            }
            else
            {
                Module.ShowMessage("Error could not set Settings !");
                return;
            }

            this.DialogResult = DialogResult.OK;
        }

        private void frmEncryptionPassword_Load(object sender, EventArgs e)
        {            
            this.Text = Module.ShortApplicationTitle + " "+this.Text;

            
        }
    }
}

