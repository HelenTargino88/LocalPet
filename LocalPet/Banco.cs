using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LocalPet
{
    public static class Banco
    {
        public static MySqlCommand Abrir()
        {
            MySqlCommand cmd = new MySqlCommand();
            try // tentar abrir
            {
                string strCon = @"server=127.0.0.1;database=db_localpet;user id=root;password=";
                MySqlConnection cn = new MySqlConnection(strCon);
                // cn.ConnectionString = strCon;
                cn.Open();
                cmd.Connection = cn;

            }
            catch (Exception)
            {
                throw;
            }
            // conexão com mysql no c#


            return cmd;
        }
    }
}
