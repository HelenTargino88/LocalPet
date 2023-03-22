using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalPet
{
    public class Adocoes
    {
        public int Id { get; set; }
        public Clientes Clientes { get; set; }
        public Animais Animais { get; set; }

        public Adocoes(int id, Clientes clientes, Animais animais)
        {
            Id = id;
            Clientes = clientes;
            Animais = animais;
        }
        public Adocoes(Clientes clientes, Animais animais)
        {
            Clientes = clientes;
            Animais = animais;
        }
        public Adocoes() { }

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "insert adocoes (clientes,animais) values('" + Clientes + "','" + Animais + "')";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select @@ identity";
            Id = Convert.ToInt32(cmd.ExecuteScalar());
        }
        public static Adocoes ObterPorId(int id)
        {
            Adocoes adocoes = new Adocoes();
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from adocoes where id = " + id;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                adocoes.Id = dr.GetInt32(0);
                adocoes.Clientes = Clientes.ObterPorId(dr.GetInt32(2));
                adocoes.Animais = Animais.ObterPorId(dr.GetInt32(3));
            }
            return adocoes;
        }
        public void Editar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "update adocoes set clientes = '" + Clientes + "', animais = '" + Animais + "'where id =" + Id;
            cmd.ExecuteReader();
        }        
        public static void Atualizar(Adocoes adocoes)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "update adocoes set " +
                "clientes = '" + adocoes.Clientes + "'," +
                "animais = '" + adocoes.Animais + "'," +                
                "where id = '" + adocoes.Id;
            cmd.ExecuteReader();
        }
        public bool Excluir(int _id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from  adocoes  where id = " + _id;
            bool result = cmd.ExecuteNonQuery() == 1 ? true : false;
            return result;
        }        
    }
}
