using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;



namespace filtroCandidatos.Models
{
    public class Cadastro
    {
        [Column("id")]
        public int id { get; set; }

        [Column("idade")]
        public int idade  { get; set; }

        [Column("cpf")]
        public string cpf { get; set; }

        [Column("data_nascimento")]
        public DateTime data_nascimento { get; set; }

        [Column("endereco")]
        public string endereco { get; set; }

        [Column("nome")]
        public string Nome { get; set; }

        [Column("genero")]
        public string genero { get; set; }

    }
}
