using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace LocalPet
{
    public class EnderecoOng
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

        // Métodos construtores
        public EnderecoOng(int id, string cep, string logradouro, string numero, string complemento, string bairro, string cidade, string estado, string uf, string tipo)
        {
            Id = id;
            CEP = cep;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            UF = uf;
            Tipo = tipo;
        }

        public EnderecoOng(string cep, string logradouro, string numero, string complemento, string bairro, string cidade, string estado, string uf, string tipo)
        {
            CEP = cep;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            UF = uf;
            Tipo = tipo;
        }
        public void Inserir(int ongs_id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "insert endereco_ong (cep, logradouro, numero, complemento, bairro, cidade, estado, uf, tipo) " +
                "values (" + ongs_id + ",'" + CEP + "', '" + Logradouro + "', '" + Numero + "', '" + Complemento + "', " +
                "'" + Bairro + "', '" + Cidade + "', '" + Estado + "', '" + UF + "', '" + Tipo + "') ";
            cmd.ExecuteNonQuery();
        }
        public static List<EnderecoOng> ListarPorOng(int ong_id)
        {
            List<EnderecoOng> listaEnd = new List<EnderecoOng>();
            var cmd = Banco.Abrir();
            cmd.CommandText = "select  cep, logradouro, numero, complemento, bairro, cidade, estado, uf, tipo, id from endereco_ong where ongs_id = " +ong_id;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                listaEnd.Add(new EnderecoOng(
                            dr.GetInt32(9),
                            dr.GetString(0),
                            dr.GetString(1),
                            dr.GetString(2),
                            dr.GetString(3),
                            dr.GetString(4),
                            dr.GetString(5),
                            dr.GetString(6),
                            dr.GetString(7),
                            dr.GetString(8)
                        )
                    );
            }
            return listaEnd;
        }
        public void Editar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "update endereco_ong set cep = '" + CEP + "'," +
                "logradouro = '" + Logradouro + "', numero = '" + Numero + "', complemento = " + Complemento + "" +
                "bairro = '" + Bairro + "', cidade = '" + Cidade + "', estado = " + Estado + "" +
                "uf = '" + UF + "', tipo = " + Tipo + "" +
                "where id = " + Id;
            cmd.ExecuteNonQuery();
        }        
        public static void Atualizar(EnderecoOng endereco_ong)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "update endereco_ong set " + "cep = '" + endereco_ong.CEP + "'," + "logradouro = '" + endereco_ong.Logradouro + "'," + 
                "numero = '" + endereco_ong.Numero + "'," + "complemento = '" + endereco_ong.Complemento + "'," + "bairro = '" + endereco_ong.Bairro + "'," + 
                "cidade = '" + endereco_ong.Cidade + "'," + "estado = '" + endereco_ong.Estado + "'," + "uf = '" + endereco_ong.UF + "'," +
                "tipo = '" + endereco_ong.Tipo + "'," + "where id = '" + endereco_ong.Id; ;
            cmd.ExecuteNonQuery();
        }
        public bool Excluir(int _id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from endereco_ong where id = " + _id;
            bool result = cmd.ExecuteNonQuery() == 1 ? true : false;
            return result;
        }

    }
}
