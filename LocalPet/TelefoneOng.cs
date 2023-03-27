using LocalPet;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace LocalPet
{
    public class TelefoneOng
    {
        public int Id { get; set; }
        public string Numero { get; set; }
        public string Tipo { get; set; }
        public Ongs Ongs { get; set; }

        public TelefoneOng(int id, string numero, string tipo, Ongs ongs)
        {
            Id = id;
            Numero = numero;
            Tipo = tipo;
            Ongs = ongs;
        }
        public TelefoneOng(string numero, string tipo, Ongs ongs)
        {
            Numero = numero;
            Tipo = tipo;
            Ongs = ongs;    
        }
        public TelefoneOng(string numero, string tipo)
        {
            Numero = numero;
            Tipo = tipo;
        }

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "insert telefone_ong (numero, tipo, ongs_id) " +
                "values (" + Numero + "', '" + Tipo + "', '" + Ongs + "')";
            cmd.ExecuteNonQuery();
        }
        public static List<TelefoneOng> Listar()
        {
            List<TelefoneOng> listaTelOng = new List<TelefoneOng>();
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from telefone_ong";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                listaTelOng.Add(new TelefoneOng(
                            dr.GetInt32(0),
                            dr.GetString(1),
                            dr.GetString(2),
                            Ongs.ObterPorId(dr.GetInt32(3))
                        )
                    );
            }
            return listaTelOng;
        }
        public static void Editar(TelefoneOng telefone_ong)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "update telefone_ong set numero = '" + telefone_ong.Numero + "'," + "tipo = '" + telefone_ong.Tipo + "'," + "ongs_id = '" + telefone_ong.Ongs +
                "where id = " + telefone_ong.Id;
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
