using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

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

        public Usuarios(int _id, string _nome, string _email, Nivel _nivel, string _senha, bool _ativo)
        {
            Id = _id;
            Nome = _nome;
            Email = _email;
            Nivel = _nivel;
            Senha = _senha;
            Ativo = _ativo;
        }

    }
}
