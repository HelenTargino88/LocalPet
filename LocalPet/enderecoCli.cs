using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalPet
{
    public class EnderecoCLi
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
        public EnderecoCLi(int id, string cep, string logradouro, string numero, string complemento, string bairro, string cidade, string estado, string uF, string tipo)
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
        }

        public EnderecoCLi(string cep, string logradouro, string numero, string complemento, string bairro, string cidade, string estado, string uF, string tipo)
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
            cmd.CommandText = "insert enderecos (cep, logradouro, numero, complemento, bairro, cidade, estado, uf, tipo) " +
                "values (" + cliente_id + ",'" + CEP + "', '" + Logradouro + "', '" + Numero + "', '" + Complemento + "', " +
                "'" + Bairro + "', '" + Cidade + "', '" + Estado + "', '" + UF + "', '" + Tipo + "')";
            cmd.ExecuteNonQuery();
        }
        public static List<EnderecoCLi> ListarPorCliente(int cliente_id)
        {
            List<EnderecoCLi> listaEnd = new List<EnderecoCLi>();
            var cmd = Banco.Abrir();
            cmd.CommandText = "select  cep, logradouro, numero, complemento, bairro, cidade, estado, uf, tipo, id from enderecos where cliente_id = " + cliente_id;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                listaEnd.Add(new EnderecoCLi(
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

    }
}
