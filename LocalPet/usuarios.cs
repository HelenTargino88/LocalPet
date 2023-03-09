﻿using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

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
                lista.Add(new Usuarios(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), Nivel.ObterPorId(dr.GetInt32(3)), dr.GetString(4), dr.GetInt32(5)));
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
                usuario.Data_registro = dr.GetInt32(5);
            }
            return usuario;
        }
        public 

    }
}
