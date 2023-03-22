using LocalPet;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ti92class
{
    public class TelefoneOng
    {
        public int Id { get; set; }
        public string Numero { get; set; }
        public string Tipo { get; set; }

        public TelefoneOng(int id, string numero, string tipo)
        {
            Id = id;
            Numero = numero;
            Tipo = tipo;
        }

        public TelefoneOng(string numero, string tipo)
        {
            Numero = numero;
            Tipo = tipo;
        }

        public void Inserir(int ong_id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "insert telefone_ong (numero, tipo) " +
                "values (" + ong_id + ",'" + Numero + "', '" + Tipo + "')";
            cmd.ExecuteNonQuery();
        }
        public static List<TelefoneOng> ListarPorOng(int ong_id)
        {
            List<TelefoneOng> listaTel = new List<TelefoneOng>();
            var cmd = Banco.Abrir();
            cmd.CommandText = "select  numero, tipo, id from telefone_ong where ong_id = " + ong_id;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                listaTel.Add(new TelefoneOng(
                            dr.GetInt32(2),
                            dr.GetString(0),
                            dr.GetString(1)
                        )
                    );
            }
            return listaTel;
        }
        public void Editar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "update telefone_ong set numero = '" + Numero + "'," + "tipo = '" + Tipo +             
                "where id = " + Id;
            cmd.ExecuteNonQuery();
        }
        public static void Atualizar(TelefoneOng telefone_ong)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "update telefone_ong set " + "numero = '" + telefone_ong.Numero + "'," + "tipo = '" + telefone_ong.Tipo + "'," +
               "where id = '" + telefone_ong.Id; ;
            cmd.ExecuteNonQuery();
        }
        public bool Excluir(int _id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from telefone_ong where id = " + _id;
            bool result = cmd.ExecuteNonQuery() == 1 ? true : false;
            return result;
        }
    }
}
