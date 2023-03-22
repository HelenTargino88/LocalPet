using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace LocalPet
{
    public class Usuarios
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public Nivel Nivel { get; set; }
        public string Senha { get; set; }
        public DateTime Data_registro { get; set; }

        // Métodos construtores

        public Usuarios() { }
        public Usuarios(string _nome, string _email, Nivel _nivel, string _senha, DateTime _data)
        {
            Nome = _nome;
            Email = _email;
            Nivel = _nivel;
            Senha = _senha;
            Data_registro = _data;
        }

        public Usuarios(int _id, string _nome, string _email, Nivel _nivel, string _senha, DateTime _data)
        {
            Id = _id;
            Nome = _nome;
            Email = _email;
            Nivel = _nivel;
            Senha = _senha;
            Data_registro = _data;
        }

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "insert usuarios (nome, email, nivel, senha, data) values('" + Nome + "','" + Email + "','" + Nivel + "','" + Senha + "','" + Data_registro + "')";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select @@identity";
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Connection.Close();

        }
        public static List<Usuarios> Listar()
        {
            List<Usuarios> lista = new List<Usuarios>();
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from usuarios order by nome";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new Usuarios(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), Nivel.ObterPorId(dr.GetInt32(3)), dr.GetString(4), dr.GetDateTime(5)));
            }
            return lista;
        }
        public static Usuarios ObterPorId(int _id)
        {
            Usuarios usuario = new Usuarios();
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from usuarios where id = " + _id;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                usuario.Id = dr.GetInt32(0);
                usuario.Nome = dr.GetString(1);
                usuario.Email = dr.GetString(2);
                usuario.Nivel = Nivel.ObterPorId(dr.GetInt32(4));
                usuario.Senha = dr.GetString(3);
                usuario.Data_registro = dr.GetDateTime(5);
            }
            return usuario;
        }
        public bool Excluir(int _id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "delete from usuarios where id = " + _id;
            bool result = cmd.ExecuteNonQuery() == 1 ? true : false;
            return result;
        }
        public static void Atualizar(Usuarios usuario)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "update usuarios set " +
                "nome = '" + usuario.Nome + "'," +
                "email = '" + usuario.Email + "'," +
                "nivel = '" + usuario.Nivel + "'," +
                "senha = '" + usuario.Senha + "'," +
                "data = '" + usuario.Data_registro + "' " +
                "where id = " + usuario.Id;
            cmd.ExecuteReader();
        }
        public static List<Usuarios> BuscarPorNome(string _parte)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from usuarios where nome like '%"+_parte+"%'order by nome;" ;
            var dr = cmd.ExecuteReader();
            List<Usuarios> lista = new List<Usuarios>();
            while (dr.Read())
            {
                lista.Add(new Usuarios(
                        dr.GetInt32(0), dr.GetString(1), dr.GetString(2), Nivel.ObterPorId(dr.GetInt32(3)), dr.GetString(4), dr.GetDateTime(5)
                    )
                );
            }
            return lista;

        }
        public static Usuarios Logar(string _email, string _senha)
        {
            Usuarios user = null;
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from usuarios where email = @email and senha=md5(@senha)";
            cmd.Parameters.AddWithValue("@email", _email);
            cmd.Parameters.AddWithValue("@senha", _senha);
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                user = new Usuarios(
                       dr.GetInt32(0),
                       dr.GetString(1),
                       dr.GetString(2),
                       Nivel.ObterPorId(dr.GetInt32(4)),
                       dr.GetString(3),
                       dr.GetDateTime(5)
                   );
            }
            return user;
        }

    }
}
