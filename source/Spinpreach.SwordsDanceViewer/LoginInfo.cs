using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Spinpreach.SwordsDanceViewer
{
    public class LoginInfo
    {

        private const string xmlname = "LoginInfo.xml";

        public string UserID { get; set; }
        public string PassWord { get; set; }

        public LoginInfo()
        {
            this.UserID = "";
            this.PassWord = "";
        }

        public LoginInfo(string UserID, string PassWord)
        {
            this.UserID = UserID;
            this.PassWord = PassWord;
        }

        public bool IsExists()
        {
            if (this.UserID == "" || this.PassWord == "")
            {
                return (false);
            }
            else
            {
                return (true);
            }
        }

        public static void Save(LoginInfo value)
        {
            string sPath = Path.Combine(Directory.GetCurrentDirectory(), xmlname);
            XmlSerializer serializer = new XmlSerializer(typeof(LoginInfo));
            FileStream fs = new FileStream(sPath, FileMode.Create);
            LoginInfo obj = new LoginInfo();
            obj.UserID = Cipher.EncryptString(value.UserID);
            obj.PassWord = Cipher.EncryptString(value.PassWord);
            serializer.Serialize(fs, obj);
            fs.Close();
        }

        public static LoginInfo Load()
        {
            LoginInfo obj = new LoginInfo();
            string sPath = Path.Combine(Directory.GetCurrentDirectory(), xmlname);
            if (File.Exists(sPath))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(LoginInfo));
                FileStream fs = new FileStream(sPath, FileMode.Open);
                LoginInfo value = (LoginInfo)serializer.Deserialize(fs);
                obj.UserID = Cipher.DecryptString(value.UserID);
                obj.PassWord = Cipher.DecryptString(value.PassWord);
                fs.Close();
            }
            return (obj);
        }

    }
}
