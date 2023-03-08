using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace LocalPet
{
    public class Nivel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }

        //Metodos construtores 

        public Nivel() { }
        public Nivel(int id, string nome, string sigla)
        {
            Id = id;
            Nome = nome;
            Sigla = sigla;
        }
        public Nivel(string nome, string sigla)
        {
            Nome = nome;
            Sigla = sigla;
        }

        public void Inserir() 
        {
            //Gravar um novo nivel na tabela niveis
            var cmd = Banco.Abrir();
            cmd.CommandText = "insert nivel (nome, sigla) values ('"+Nome+"','"+Sigla+"')";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select @@identity";
            Id = Convert.ToInt32(cmd.ExecuteScalar());

        }
        public static List<Nivel> Listar() 
        {
            List<Nivel> lista = new List<Nivel>();
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from nivel order by nome asc";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new Nivel(dr.GetInt32(0),dr.GetString(1),dr.GetString(2)));
               
            }
            return lista;

        }
        public static Nivel ObterPorId(int _id)
        {
            Nivel nivel = new Nivel();
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from nivel where id =" +_id;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                nivel.Id = dr.GetInt32(0);
                nivel.Nome = dr.GetString(1);
                nivel.Sigla = dr.GetString(2);
            }
            return nivel;
        }
        public static void Atualizar(Nivel nivel)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "update niveis set nome = '" +
                nivel.Nome + "', sigla = '" + nivel.Sigla +
                "' where id = " + nivel.Id;
            cmd.ExecuteReader();
        }
        public bool Excluir(int _id)
        {
            var cmd = Banco. Abrir();
            cmd.CommandText = "delete from nivel where id = "+_id;
            bool result = cmd.ExecuteNonQuery() == 1 ? true : false;
            return result;  
        }
        public static List<Nivel> BuscarPorNome(string _parte)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from niveis where nome like '%" + _parte + "%' order by nome;";
            var dr = cmd.ExecuteReader();
            List<Nivel> lista = new List<Nivel>();
            while (dr.Read())
            {
                lista.Add(new Nivel(
                        dr.GetInt32(0), dr.GetString(1), dr.GetString(2)
                    )
                );
            }
            return lista;
        }

    }
}
