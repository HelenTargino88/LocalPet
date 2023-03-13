using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalPet
{
    public class Especies
    {


        public int Id { get; set; }
        public string Nome { get; set; }

        public Especies(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public Especies(string nome)
        {
            Nome = nome;
        }
        public Especies() { }
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "insert usuarios(nome) values('" + Nome + "')";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select @@ identity";
            Id = Convert.ToInt32(cmd.ExecuteScalar());
        }
        public static List<Especies> Listar()
        {
            List<Especies> lista = new List<Especies>();
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from especies order by nome asc";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new Especies(
                    dr.GetString(1)
                    ));
            }
            return lista;
        }
        public static Especies ObterPorId(int id)
        {
            Especies especie = new Especies();
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from especies where id = " + id;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                especie.Id = dr.GetInt32(0);
                especie.Nome = dr.GetString(1);

            }
            return especie;
        }
        public void Editar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "update especies set nome = '" + Nome + "'where id =" + Id;
            cmd.ExecuteReader();
        }
        public static bool Arquivar(int id) // Arquivando
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update especies set descontinuado = 1 where id =" + id;
            return cmd.ExecuteNonQuery() == 1 ? true : false;
        }
        public static bool Restaurar(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update especies set descontinuado = 0 where id =" + id;
            return cmd.ExecuteNonQuery() == 1 ? true : false;

        }
        public static void Atualizar(Especies especie)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "update especies set" +
                "nome = '" + especie.Nome + "'" +
                "where id " + especie.Id;
            cmd.ExecuteReader();
        }
        public bool Excluir(int _id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from  especies  where id = " + _id;
            bool result = cmd.ExecuteNonQuery() == 1 ? true : false;
            return result;

        }
        public static List<Especies> BuscarPorNome(string _parte)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from especies where nome like '%" + _parte + "%' order by nome;";
            var dr = cmd.ExecuteReader();
            List<Especies> lista = new List<Especies>();
            while (dr.Read())
            {
                lista.Add(new Especies(
                    dr.GetInt32(0), dr.GetString(1)
                    ));
            }
            return lista;
        }
    }
}
