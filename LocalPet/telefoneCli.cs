using LocalPet;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ti92class
{
    public class TelefoneCli
    {
        public int Id { get; set; }
        public string Numero { get; set; }
        public string Tipo { get; set; }

        public TelefoneCli(int id, string numero, string tipo)
        {
            Id = id;
            Numero = numero;
            Tipo = tipo;
        }

        public TelefoneCli(string numero, string tipo)
        {
            Numero = numero;
            Tipo = tipo;
        }

        public void Inserir(int cliente_id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "insert telefone_cli (numero, tipo) " +
                "values (" + cliente_id + ",'" + Numero + "', '" + Tipo + "')";
            cmd.ExecuteNonQuery();
        }
        public static List<TelefoneCli> ListarPorCliente(int cliente_id)
        {
            List<TelefoneCli> listaTel = new List<TelefoneCli>();
            var cmd = Banco.Abrir();
            cmd.CommandText = "select  numero, tipo, id from telefone_cli where cliente_id = " + cliente_id;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                listaTel.Add(new TelefoneCli(
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
            cmd.CommandText = "update telefone_cli set numero = '" + Numero + "'," + "tipo = '" + Tipo +
                "where id = " + Id;
            cmd.ExecuteNonQuery();
        }
        public static void Atualizar(TelefoneCli telefone_cli)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "update telefone_cli set " + "numero = '" + telefone_cli.Numero + "'," + "tipo = '" + telefone_cli.Tipo + "'," +
               "where id = '" + telefone_cli.Id; ;
            cmd.ExecuteNonQuery();
        }
        public bool Excluir(int _id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from telefone_cli where id = " + _id;
            bool result = cmd.ExecuteNonQuery() == 1 ? true : false;
            return result;
        }
    }
}
