using LocalPet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ti92class
{
    public class telefoneOng
    {
        public int Id { get; set; }
        public string Numero { get; set; }
        public string Tipo { get; set; }

        public telefoneOng(int id, string numero, string tipo)
        {
            Id = id;
            Numero = numero;
            Tipo = tipo;
        }

        public telefoneOng(string numero, string tipo)
        {
            Numero = numero;
            Tipo = tipo;
        }

        public void Inserir(int ong_id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "insert telefones (numero, tipo) " +
                "values (" + ong_id + ",'" + Numero + "', '" + Tipo + "')";
            cmd.ExecuteNonQuery();
        }
        public static List<telefonecli> ListarPorCliente(int ong_id)
        {
            List<telefonecli> listaTel = new List<telefonecli>();
            var cmd = Banco.Abrir();
            cmd.CommandText = "select  numero, tipo, id from telefones where cliente_id = " + ong_id;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                listaTel.Add(new telefonecli(
                            dr.GetInt32(2),
                            dr.GetString(0),
                            dr.GetString(1)
                        )
                    );
            }
            return listaTel;
        }
    }
}
