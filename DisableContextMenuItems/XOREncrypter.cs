using System;
using System.Collections.Generic;
using System.Text;

namespace DisableContextMenuItems
{
    class XOREncrypter
    {
        public static string EncryptDecrypt(string toEncrypt)
        {
            char key = 'E'; //Any char will work
            int ikey = (int)key;

            StringBuilder sb = new StringBuilder();

            string output = toEncrypt;
            for (int i = 0; i < toEncrypt.Length; i++)
            {
                sb.Append((char)((int)toEncrypt[i] ^ ikey));
            }

            return sb.ToString();
        }
    }

    
}
