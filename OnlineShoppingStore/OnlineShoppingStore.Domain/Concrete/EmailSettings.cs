using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShoppingStore.Domain.Concrete
{
    public class EmailSettings
    {
        public string MailToAddress = "tonytong003@gmail.com";
        public string MailFromAddress = "tonytong003@gmail.com";
        public bool UseSsl = true;
        public string Username = "tonytong003@gmail.com";
        public string Password = "StoreProject";
        public string ServerName="smtp.gmail.com";
        public int ServerPort = 587;
    }
}
