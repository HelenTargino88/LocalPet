using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace LocalPet
{
    public class Raca
    {


        public int Id { get; set; }
        public string Raça { get; set; }

        public Raca(string raca)
        {
            Raça = raca;
        }

        public Raca(int id, string raca)
        {
            Id = id;
            Raça = raca;
        }
        public Raca() { }

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "insert raca (raca) values('" + Raça + "')";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select @@ identity";
            Id = Convert.ToInt32(cmd.ExecuteScalar());
        }
        public static List<Raca> Listar()
        {
            List<Raca> lista = new List<Raca>();
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from raca order by nome asc";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new Raca(
                    dr.GetString(1)
                    ));
            }
            return lista;
        }
        public static Raca ObterPorId(int id)
        {
            Raca raca = new Raca();
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from raca where id = " + id;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                raca.Id = dr.GetInt32(0);
                raca.Raça = dr.GetString(1);

            }
            return raca;
        }
        public void Editar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "update raca set nome = '" + Raça + "'where id =" + Id;
            cmd.ExecuteReader();
        }
        public static bool Arquivar(int id) // Arquivando
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update raca set descontinuado = 1 where id =" + id;
            return cmd.ExecuteNonQuery() == 1 ? true : false;
        }
        public static bool Restaurar(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update raca set descontinuado = 0 where id =" + id;
            return cmd.ExecuteNonQuery() == 1 ? true : false;

        }
        public static void Atualizar(Raca raca)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "update raca set" +
                "nome = '" + raca.Raça + "'" +
                "where id " + raca.Id;
            cmd.ExecuteReader();
        }
        public bool Excluir(int _id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from raca  where id = " + _id;
            bool result = cmd.ExecuteNonQuery() == 1 ? true : false;
            return result;

        }
        public static List<Raca> BuscarPorNome(string _parte)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from especies where nome like '%" + _parte + "%' order by nome;";
            var dr = cmd.ExecuteReader();
            List<Raca> lista = new List<Raca>();
            while (dr.Read())
            {
                lista.Add(new Raca(
                    dr.GetInt32(0), dr.GetString(1)
                    ));
            }
            return lista;
        }
    }
}
