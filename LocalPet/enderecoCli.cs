using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalPet
{
    public class EnderecoCli
    {
        
        public int Id { get; set; }
        public string CEP { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string UF { get; set; }
        public string Tipo { get; set; }
        public Clientes Clientes { get; set; }

        // Métodos construtores
        public EnderecoCli(int id, string cep, string logradouro, string numero, string complemento, string bairro, string cidade, string estado, string uF, string tipo, Clientes clientes)
        {
            Id = id;
            CEP = cep;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            UF = uF;
            Tipo = tipo;
            Clientes = clientes;
        }
        public EnderecoCli(string cep, string logradouro, string numero, string complemento, string bairro, string cidade, string estado, string uF, string tipo, Clientes clientes)
        {
            CEP = cep;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            UF = uF;
            Tipo = tipo;
            Clientes = clientes;
        }

        public EnderecoCli(string cep, string logradouro, string numero, string complemento, string bairro, string cidade, string estado, string uF, string tipo)
        {
            CEP = cep;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            UF = uF;
            Tipo = tipo;
        }
      public void Inserir(int cliente_id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "insert endereco_cli (cep, logradouro, numero, complemento, bairro, cidade, estado, uf, tipo, clientes_id) " +
                "values ("+ CEP + "', '" + Logradouro + "', '" + Numero + "', '" + Complemento + "', " +
                "'" + Bairro + "', '" + Cidade + "', '" + Estado + "', '" + UF + "', '" + Tipo + "', '" + Clientes + "')";
            cmd.ExecuteNonQuery();
        }
        public static List<EnderecoCli> Listar()
        {
            List<EnderecoCli> listaEnd = new List<EnderecoCli>();
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from cliente_id";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                listaEnd.Add(new EnderecoCli(
                            dr.GetInt32(0),
                            dr.GetString(1),
                            dr.GetString(2),
                            dr.GetString(3),
                            dr.GetString(4),
                            dr.GetString(5),
                            dr.GetString(6),
                            dr.GetString(7),
                            dr.GetString(8),
                            dr.GetString(9),
                            Clientes.ObterPorId(dr.GetInt32(10))
                        )
                    );
            }
            return listaEnd;
        }
        public void Editar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "update endereco_cli set cep = '" + CEP + "'," +
                "logradouro = '" + Logradouro + "', numero = '" + Numero + "', complemento = " + Complemento + "" +
                "bairro = '" + Bairro + "', cidade = '" + Cidade + "', estado = " + Estado + "" +
                "uf = '" + UF + "', tipo = " + Tipo + "" +
                "where id = " + Id;
            cmd.ExecuteNonQuery();
        }
        public static void Atualizar(EnderecoCli endereco_cli)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "update endereco_cli set " + "cep = '" + endereco_cli.CEP + "'," + "logradouro = '" + endereco_cli.Logradouro + "'," +
                "numero = '" + endereco_cli.Numero + "'," + "complemento = '" + endereco_cli.Complemento + "'," + "bairro = '" + endereco_cli.Bairro + "'," +
                "cidade = '" + endereco_cli.Cidade + "'," + "estado = '" + endereco_cli.Estado + "'," + "uf = '" + endereco_cli.UF + "'," +
                "tipo = '" + endereco_cli.Tipo + "'," + "where id = '" + endereco_cli.Id; ;
            cmd.ExecuteNonQuery();
        }
        public bool Excluir(int _id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from endereco_cli where id = " + _id;
            bool result = cmd.ExecuteNonQuery() == 1 ? true : false;
            return result;
        }

    }
}
