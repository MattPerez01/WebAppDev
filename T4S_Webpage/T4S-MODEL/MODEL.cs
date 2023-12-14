using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4S_MODEL
{
    public class SignUpModel
    {
        public string userName { get; set; }
        public string password { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
       
        public string message { get; set; }
    }
    public class SignInModel
    {
        public string userName { get; set; }
        public string password { get; set; }
        public string message { get; set; }
    }

}
