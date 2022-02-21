using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models
{
    public class UserInfo
    {
        public string Id { get; set; }
        public string Date_record { get; set; }
        public PersonalInfo Personal { get; set;}
        public SettingDefault SettingDefault { get; set; }
        public string Telegramm_token { get; set; }
        public bool Paid_for { get; set; }
        public string  Role{ get; set; }
        public bool Block { get; set; }
    }
}
