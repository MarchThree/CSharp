using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 会员系统.Model
{
   public class memberModel
    {
        private int _id;
        private string _memberName;
        private int _memberSex;
        private int _memberAge;

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

        public string MemberName
        {
            get
            {
                return _memberName;
            }

            set
            {
                _memberName = value;
            }
        }

        public string MemberSex
        {
            get
            {
                return _memberSex==0?"男":"女";
            }

            set
            {
                _memberSex = value=="男"?0:1;
            }
        }

        public int MemberAge
        {
            get
            {
                return _memberAge;
            }

            set
            {
                _memberAge = value;
            }
        }
    }
}
