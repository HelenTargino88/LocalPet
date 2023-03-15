using Org.BouncyCastle.Asn1;
using Renci.SshNet.Security.Cryptography.Ciphers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalPet
{
    internal class Animais
    {
       
        public int Id {  get; set; }
        public string Nome { get; set; }
        public string Sexo { get; set; }
        public string Descricao { get; set; }
        public string Idade { get; set; }
        public string Porte { get; set; }
        public string Enfermidades { get; set; }
        public string Medicamentos { get; set; }
        public string Vacinas { get; set; }
        public string Comportamento { get; set; }
        public string Imagem_animal { get; set; }
        public bool Ativo { get; set; }

        public Animais(int id, string nome, string sexo, string descricao, bool ativo)
        {
            Id = id;
            Nome = nome;
            Sexo = sexo;
            Descricao = descricao;
            Ativo = ativo;
        }

        public Animais(string nome, string sexo, string descricao, bool ativo)
        {
            Nome = nome;
            Sexo = sexo;
            Descricao = descricao;
            Ativo = ativo;
        }
        public Animais() { }

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "insert animais (nome,sexo,descricao,ativo) values('" + Nome + "','"+Sexo+"','"+Descricao+"','"+Ativo+"')";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select @@ identity";
            Id = Convert.ToInt32(cmd.ExecuteScalar());
        }
        public static List<Animais> Listar()
        {
            List<Animais> lista = new List<Animais>();
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from animais order by nome asc";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new Animais(
                    dr.GetString(1),dr.GetString(2),dr.GetString(3),dr.GetBoolean(4)
                    ));
            }
            return lista;
        }
        public static Animais ObterPorId(int id)
        {
            Animais animais = new Animais();
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from animais where id = " + id;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                animais.Id = dr.GetInt32(0);
                animais.Nome = dr.GetString(1);
                animais.Sexo = dr.GetString(2);
                animais.Descricao = dr.GetString(3);
                animais.Ativo = dr.GetBoolean(4);

            }
            return animais;
        }
        public void Editar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "update animais set nome = '"+Nome+"','"+Sexo+"','"+Descricao+"','"+Ativo+"'where id ="+ Id;
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
        public static void Atualizar(Animais animais)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "update animais set " +
                "nome = '" + animais.Nome + "'," +
                "sexo = '" + animais.Sexo + "'," +
                "descricao = '" + animais.Descricao + "'," +
                "ativo = '"+animais.Ativo+"'," +
                "where id = '" + animais.Id;
            cmd.ExecuteReader();
        }
        public bool Excluir(int _id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from  animais  where id = " + _id;
            bool result = cmd.ExecuteNonQuery() == 1 ? true : false;
            return result;

        }
        public static List<Animais> BuscarPorNome(string _parte)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from animais where nome like '%" + _parte + "%' order by nome;";
            var dr = cmd.ExecuteReader();
            List<Animais> lista = new List<Animais>();
            while (dr.Read())
            {
                lista.Add(new Animais(
                    dr.GetInt32(0), dr.GetString(1), dr.GetString(2),dr.GetString(3),dr.GetBoolean(4)
                    ));
            }
            return lista;
        }


    }
}
