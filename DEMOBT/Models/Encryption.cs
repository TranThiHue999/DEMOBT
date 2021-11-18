using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace DEMOBT.Models
{
    public class Encryption
    {
        public string  PasswordEncryption(String pass)
        {
            return FormsAuthentication.HashPasswordForStoringInConfigFile(pass.Trim(), "MD5"); //ma hoa chuoi truyen vao
        }
    }
}