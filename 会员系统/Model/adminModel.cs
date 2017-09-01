using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 会员系统.Common;

namespace 会员系统.Model
{
    public class adminModel
    {
        private int _id;
        private string _userName;
        private string _password;


        public int Id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }

        public string UserName
        {
            get
            {
                return _userName;
            }

            set
            {
                _userName = value;
            }
        }

        public string Password
        {
            get
            {
                return _password;
            }

            set
            {
                _password =value;
            }
        }
    }
}
