using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
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
        public string CpfResponsavel { get; set; }
        public string Descricao { get; set; }
        public string Imagem_ong { get; set; }
        public Usuarios User { get; set; }
        public Ongs() { }

        public Ongs(int id, string nome, string cnpj, string cpfResponsavel, string descricao, string imagem_ong, Usuarios user)
        {
            Id = id;
            Nome = nome;
            Cnpj = cnpj;
            CpfResponsavel = cpfResponsavel;
            Descricao = descricao;
            Imagem_ong = imagem_ong;
            User = user;
        }

        public Ongs(string nome, string cnpj, string cpfResponsavel, string descricao, string imagem_ong)
        {
            Nome = nome;
            Cnpj = cnpj;
            CpfResponsavel = cpfResponsavel;
            Descricao = descricao;
            Imagem_ong = imagem_ong;
        }

        public Ongs(int id, string nome, string cnpj, string cpfResponsavel, string descricao, string imagem_ong)
        {
            Id = id;
            Nome = nome;
            Cnpj = cnpj;
            CpfResponsavel = cpfResponsavel;
            Descricao = descricao;
            Imagem_ong = imagem_ong;
        }

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "insert ongs(nome, cnpj, cpfResponsavel, descricao, imagem_ong, usuario_id) values('" + Nome + "','" + Cnpj + "','" + CpfResponsavel + "','" + Descricao + "','" + Imagem_ong + "')";
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
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetString(4),
                    dr.GetString(5),
                    Usuarios.ObterPorId(dr.GetInt32(0))
                    )); ;
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
                ongs.CpfResponsavel = dr.GetString(3);
                ongs.Descricao = dr.GetString(4);
                ongs.Imagem_ong = dr.GetString(5);
                Usuarios.ObterPorId(dr.GetInt32(0));
            }
            return ongs;
        }
        public void Editar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "update ongs set nome = '" + Nome + "', cnpj = '" + Cnpj + "', cpfResponsavel = '" + CpfResponsavel + "',' descricao ='" + Descricao + "','imagem_ong = '" + Imagem_ong + ",' 'where id =" + Id;
            cmd.ExecuteReader();
        }
        public static void Atualizar(Ongs ongs)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "update ongs set " + "nome = '" + ongs.Nome + "', cnpj = '" + ongs.Cnpj + "', cpfResponsavel = '" + ongs.CpfResponsavel + "',' descricao ='" + ongs.Descricao + "','imagem_ong = '" + ongs.Imagem_ong + ",' 'where id =" + ongs.Id;
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
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetString(4),
                    dr.GetString(5),
                    Usuarios.ObterPorId(dr.GetInt32(0))
                    ));
            }
            return lista;
        }
    }
}