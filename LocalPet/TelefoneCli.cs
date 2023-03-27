using LocalPet;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalPet
{
    public class TelefoneCli
    {
        public int Id { get; set; }
        public string Numero { get; set; }
        public string Tipo { get; set; }
        public Clientes Clientes { get; set; }

        public TelefoneCli(int id, string numero, string tipo, Clientes clientes)
        {
            Id = id;
            Numero = numero;
            Tipo = tipo;
            Clientes = clientes;
        }
        public TelefoneCli(string numero, string tipo, Clientes clientes)
        {
            Numero = numero;
            Tipo = tipo;
            Clientes = clientes;
        }

        public TelefoneCli(string numero, string tipo)
        {
            Numero = numero;
            Tipo = tipo;
        }

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "insert telefone_cli (numero, tipo, cliente_id) " +
                "values (" + Numero + ",'" + Tipo + "', '" + Clientes + "')";
            cmd.ExecuteNonQuery();
        }
        public static List<TelefoneCli> Listar()
        {
            List<TelefoneCli> listaTelCli = new List<TelefoneCli>();
            var cmd = Banco.Abrir();
            cmd.CommandText = "select  * from telefone_cli";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                listaTelCli.Add(new TelefoneCli(
                            dr.GetInt32(0),
                            dr.GetString(1),
                            dr.GetString(2),
                            Clientes.ObterPorId(dr.GetInt32(3))
                        )
                    );
            }
            return listaTelCli;
        }
        public static void Editar(TelefoneCli telefone_cli)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "update telefone_cli set numero = '" + telefone_cli.Numero + "'," + "tipo = '" + telefone_cli.Tipo + "'," + "cliente_id = '" + telefone_cli.Clientes +
                "where id = " + telefone_cli.Id;
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
