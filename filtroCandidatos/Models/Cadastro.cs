using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
//using System.Data.Entity.ModelConfiguration.Conventions; 
using System.Data.Entity.ModelConfiguration.Conventions;
using System.ComponentModel.DataAnnotations.Schema;



namespace filtroCandidatos.Models
{
    public class Cadastro
    {
        [Column("id")]
        public int id { get; set; }

        [Column("nome")]
        public string Nome { get; set; }

        [Column("sobrenome")]
        public string sobrenome { get; set; }

        [Column("data_de_nascimento")]
        public string data_de_nascimento { get; set; }

        [Column("cpf")]
        public string cpf { get; set; }

        [Column("idade")]
        public int idade { get; set; }

        [Column("genero")]
        public string genero { get; set; }

        [Column("telefone_usuario")]
        public string telefone_usuario { get; set; }










    }
}
