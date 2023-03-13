using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalPet
{
    public class Ongs
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cnpj { get; set; }
        public string Cpf { get; set; }
        public Ongs()
        {
        }

        public Ongs(int id, string nome, string cnpj, string cpf)
        {
            Id = id;
            Nome = nome;
            Cnpj = cnpj;
            Cpf = cpf;
        }

        public Ongs(string nome, string cnpj, string cpf)
        {
            Nome = nome;
            Cnpj = cnpj;
            Cpf = cpf;
        }

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "insert ongs(nome, cnpj, cpf) values('" + Nome + "','" + Cnpj + "','" + Cpf + "')";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select @@ identity";
            Id = Convert.ToInt32(cmd.ExecuteScalar());
        }
        public static List<Ongs> Listar()
        {
            List<Ongs> lista = new List<Ongs>();
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from ongs order by nome asc";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new Ongs(
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3)
                    ));
            }
            return lista;
        }
        public static Ongs ObterPorId(int id)
        {
            Ongs ongs = new Ongs();
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from ongs where id = " + id;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ongs.Id = dr.GetInt32(0);
                ongs.Nome = dr.GetString(1);
                ongs.Cnpj = dr.GetString(2);
                ongs.Cpf = dr.GetString(3);
            }
            return ongs;
        }
        public void Editar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "update ongs set nome = '" + Nome + "', cnpj = '" + Cnpj + "', cpf = '" + Cpf + "'where id =" + Id;
            cmd.ExecuteReader();
        }
        public static bool Arquivar(int id) // Arquivando
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update ongs set descontinuado = 1 where id =" + id;
            return cmd.ExecuteNonQuery() == 1 ? true : false;
        }
        public static bool Restaurar(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update ongs set descontinuado = 0 where id =" + id;
            return cmd.ExecuteNonQuery() == 1 ? true : false;
        }
        public static void Atualizar(Ongs ongs)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "update ongs set " +
                "nome = '" + ongs.Nome + "'," +
                "cnpj = '" + ongs.Cnpj + "'," +
                "cpf = '" + ongs.Cpf + "'," +
                "where id = '" + ongs.Id;
            cmd.ExecuteReader();
        }
        public bool Excluir(int _id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from ongs where id = " + _id;
            bool result = cmd.ExecuteNonQuery() == 1 ? true : false;
            return result;
        }
        public static List<Ongs> BuscarPorNome(string _parte)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from ongs where nome like '%" + _parte + "%' order by nome;";
            var dr = cmd.ExecuteReader();
            List<Ongs> lista = new List<Ongs>();
            while (dr.Read())
            {
                lista.Add(new Ongs(
                    dr.GetInt32(0),dr.GetString(1),dr.GetString(2),dr.GetString(3)
                    ));
            }
            return lista;
        }
    }
}
