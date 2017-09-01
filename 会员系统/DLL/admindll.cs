using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
using 会员系统.Model;

namespace 会员系统.DLL
{
    public class admindll
    {
        public static adminModel getAdminById(int id) {
            string sql = "select * from admin where id=@id";
            MySqlParameter[] para =new MySqlParameter[] {new MySqlParameter("@id",MySqlDbType.Int16) };
            DataSet ds=  MysqlHelper.ExcuteReader(sql,para);
            adminModel adminM = new adminModel();
            if (ds!=null) {
                adminM.Id =(int)ds.Tables[0].Rows[0]["id"];
                adminM.Password = (int)ds.Tables[0].Rows[0]["id"];
            }
        }
    }
}
