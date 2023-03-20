﻿using LocalPet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ti92class
{
    public class TelefoneOng
    {
        public int Id { get; set; }
        public string Numero { get; set; }
        public string Tipo { get; set; }

        public TelefoneOng(int id, string numero, string tipo)
        {
            Id = id;
            Numero = numero;
            Tipo = tipo;
        }

        public TelefoneOng(string numero, string tipo)
        {
            Numero = numero;
            Tipo = tipo;
        }

        public void Inserir(int ong_id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "insert telefones (numero, tipo) " +
                "values (" + ong_id + ",'" + Numero + "', '" + Tipo + "')";
            cmd.ExecuteNonQuery();
        }
        public static List<TelefoneOng> ListarPorOng(int ong_id)
        {
            List<TelefoneOng> listaTel = new List<TelefoneOng>();
            var cmd = Banco.Abrir();
            cmd.CommandText = "select  numero, tipo, id from telefones where cliente_id = " + ong_id;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                listaTel.Add(new TelefoneOng(
                            dr.GetInt32(2),
                            dr.GetString(0),
                            dr.GetString(1)
                        )
                    );
            }
            return listaTel;
        }
    }
}
