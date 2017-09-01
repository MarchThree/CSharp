using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;

namespace 会员系统.DLL
{
    public class MysqlHelper
    {
        private static string constr = "Server=localhost;Database=DSMember;uid=root;pwd=root";

        //执行无返回结果的sql
        public static int ExcuNoneQuery(string sql, MySqlParameter[] para)
        {
            using (MySqlConnection conn = new MySqlConnection(constr))
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.CommandText = sql;
                    cmd.Parameters.AddRange(para);
                    try
                    {
                        return cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        return 0;
                    }

                }
            }
        }

        //返回第一行第一列
        public static object ExcuScalar(string sql, MySqlParameter[] para)
        {
            using (MySqlConnection conn = new MySqlConnection(constr))
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.CommandText = sql;
                    cmd.Parameters.AddRange(para);
                    try
                    {
                        return cmd.ExecuteScalar();
                    }
                    catch (Exception ex)
                    {
                        return null;
                    }

                }
            }
        }

        public static MySqlDataReader ExcuReady(string sql, MySqlParameter[] para)
        {
            using (MySqlConnection conn = new MySqlConnection(constr))
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.CommandText = sql;
                    cmd.Parameters.AddRange(para);
                    try
                    {
                        MySqlDataReader dataReader = cmd.ExecuteReader();
                        return dataReader;
                    }
                    catch (Exception ex)
                    {
                        return null;
                    }

                }
            }
        }

        //返回数据集合
        public static DataSet ExcuteReader(string sql, MySqlParameter[] para)
        {
            using (MySqlConnection conn = new MySqlConnection(constr))
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.CommandText = sql;
                    cmd.Parameters.AddRange(para);
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataSet dt = new DataSet();
                        try
                        {
                            adapter.Fill(dt);
                            return dt;
                        }
                        catch (Exception ex)
                        {
                            return null;
                        }
                    }

                }

            }
        }

    }
}
