using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelClient
{
    public class UserModel
    {
        public int id { get; set; }
        public string tel { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string AccessHash { get; set; }
        public string Username { get; set; }
    }

}