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
    public class Animais
    {      
        public int Id {  get; set; }
        public string Nome { get; set; }
        public Raca Raca { get; set; }
        public string Especie { get; set; }
        public string Sexo { get; set; }
        public string Porte { get; set; }
        public string Idade { get; set; }
        public string Descricao { get; set; }
        public string Enfermidades { get; set; }
        public string Medicamentos { get; set; }
        public string Vacinas { get; set; }
        public string Comportamento { get; set; }
        public string Imagem_animal { get; set; }
        public bool Ativo { get; set; }


        public Animais(int id, string nome, Raca raca, string especie, string sexo, string porte, string idade, string descricao, string enfermidades, string medicamentos, string vacinas, string comportamento, string imagem_animal, bool ativo)
        {
            Id = id;
            Nome = nome;
            Raca = raca;
            Especie = especie;
            Sexo = sexo;
            Porte = porte;
            Idade = idade;
            Descricao = descricao;
            Enfermidades = enfermidades;
            Medicamentos = medicamentos;
            Vacinas = vacinas;
            Comportamento = comportamento;
            Imagem_animal = imagem_animal;
            Ativo = ativo;
        }

        public Animais(string nome, Raca raca, string especie, string sexo, string porte, string idade, string descricao, string enfermidades, string medicamentos, string vacinas, string comportamento, string imagem_animal, bool ativo)
        {
            Nome = nome;
            Raca = raca;
            Especie = especie;
            Sexo = sexo;
            Porte = porte;
            Idade = idade;
            Descricao = descricao;
            Enfermidades = enfermidades;
            Medicamentos = medicamentos;
            Vacinas = vacinas;
            Comportamento = comportamento;
            Imagem_animal = imagem_animal;
            Ativo = ativo;
        } 

        public Animais() { }


        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "insert animais (nome,raca,especie,sexo,porte,idade,descricao,enfermidades,medicamentos,vacinas,comportamento,imagem_animal,ativo) values('" +Nome+ "','"+Raca+"','"+Especie+"','" + Sexo+ "','"+Porte+ "'," +
                "'"+Idade+ "','" + Descricao+ "','"+Enfermidades+"','"+Medicamentos+ "','"+Vacinas+ "','"+Comportamento+ "','"+Imagem_animal+"','" + Ativo+"')";
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
                    dr.GetString(1), Raca.ObterPorId(dr.GetInt32(2)),dr.GetString(3), dr.GetString(4), dr.GetString(5), dr.GetString(6), 
                    dr.GetString(7), dr.GetString(8), dr.GetString(9), dr.GetString(10), dr.GetString(11), dr.GetString(12), dr.GetBoolean(13)
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
                animais.Raca = Raca.ObterPorId(dr.GetInt32(2));
                animais.Especie = dr.GetString(3);
                animais.Sexo = dr.GetString(4);
                animais.Porte = dr.GetString(5);
                animais.Idade = dr.GetString(6);
                animais.Descricao = dr.GetString(7);
                animais.Enfermidades = dr.GetString(8);
                animais.Medicamentos = dr.GetString(9);
                animais.Vacinas = dr.GetString(10);
                animais.Comportamento = dr.GetString(11);
                animais.Imagem_animal = dr.GetString(12);
                animais.Ativo = dr.GetBoolean(13);

            }
            return animais;
        }
        public void Editar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "update animais set nome = '" + Nome + "','" + Raca + "','" + Especie + "','" + Sexo + "','" + Porte + "'," +
                "'" + Idade + "','" + Descricao + "','" + Enfermidades + "','" + Medicamentos + "','" + Vacinas + "','" + Comportamento + "','" + Imagem_animal + "','" + Ativo+"'where id ="+ Id;
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
                "raca = '" + animais.Raca + "'," +
                "especie = '" + animais.Especie + "'," +         
                "porte = '" + animais.Porte + "'," +
                "idade = '" + animais.Idade + "'," +
                "descricao = '" + animais.Descricao + "'," +
                "enfermidades = '" +animais.Enfermidades+"'," +
                "medicamentos = '" + animais.Medicamentos + "'," +
                "vacinas = '" + animais.Vacinas + "'," +
                "comportamento = '" + animais.Comportamento + "'," +
                "imagem_animal = '" + animais.Imagem_animal + "'," +
                "ativo = '" + animais.Ativo + "'," +
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
                    dr.GetString(1), Raca.ObterPorId(dr.GetInt32(2)), dr.GetString(3), dr.GetString(4), dr.GetString(5), dr.GetString(6),
                    dr.GetString(7), dr.GetString(8), dr.GetString(9), dr.GetString(10), dr.GetString(11), dr.GetString(12), dr.GetBoolean(13)
                    ));
            }
            return lista;
        }


    }
}
