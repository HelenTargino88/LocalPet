using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalPet
{
    public class Clientes
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime Data_nasc { get; set; }
        public string Email { get; set; }
        public Usuarios User { get; }

        public Clientes(int id, string nome, string cpf, DateTime data_nasc, string email, Usuarios user)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Data_nasc = data_nasc;
            Email = email;
            User = user;
        }
        public Clientes(string nome, string cpf, DateTime data_nasc, string email)
        {
            Nome = nome;
            Cpf = cpf;
            Data_nasc = data_nasc;
            Email = email;
        }
        public Clientes()
        {

        }

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "insert clientes (nome, cpf, data_nasc, email)" +
                "values ('" + Nome + "'," +
                "'" + Cpf + "'," +
                "'" + Data_nasc + "'," +
                "'" + Email + "')";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select @@identity";
            Id = Convert.ToInt32(cmd.ExecuteScalar());
        }
        public static List<Clientes> Listar()
        {
            List<Clientes> lista = new List<Clientes>();
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from clientes order by name asc";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new Clientes(
                 dr.GetInt32(0),
                 dr.GetString(1),
                 dr.GetString(2),
                 dr.GetDateTime(3),
                 dr.GetString(4),
                 Usuarios.ObterPorId(dr.GetInt32(0))));
            }
            return lista;
        }
        public static Clientes ObterPorId(int id)
        {
            Clientes clientes = new Clientes();
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from clientes where id =" + id;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                clientes.Id = dr.GetInt32(0);
                clientes.Nome = dr.GetString(1);
                clientes.Cpf = dr.GetString(2);
                clientes.Data_nasc = dr.GetDateTime(3);
                clientes.Email = dr.GetString(4);
                Usuarios.ObterPorId(dr.GetInt32(0));
            }
            return clientes;
        }
        public void Editar(Clientes clientes)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "update clientes set nome = '" + clientes.Nome + "'," + "cpf = '" + clientes.Cpf + "'," + "data_nasc = '" + clientes.Data_nasc + "'," + "email = '" + clientes.Email + "' where id = " + clientes.Id;
            cmd.ExecuteNonQuery();
        }
        public static bool Arquivar(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "uptdate clientes set descontinuado = 1 where id =" + id;
            return cmd.ExecuteNonQuery() == 1 ? true : false;
        }
        public static bool Restaurar(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update clientes set descontinuado = 0 where id =" + id;
            return cmd.ExecuteNonQuery() == 1 ? true : false;
        }
        public bool Excluir(int _id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from clientes where id = " + _id;
            bool result = cmd.ExecuteNonQuery() == 1 ? true : false;
            return result;
        }
        public static List<Clientes> BuscarPorNome(string _parte)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from clientes where nome like '%" + _parte + "%' order by nome;";
            var dr = cmd.ExecuteReader();
            List<Clientes> lista = new List<Clientes>();
            while (dr.Read())
            {
                lista.Add(new Clientes(
                    dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetDateTime(3), dr.GetString(4), Usuarios.ObterPorId(dr.GetInt32(0))
                    ));
            }
            return lista;
        }
    }
}
