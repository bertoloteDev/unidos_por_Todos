using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.ComponentModel.DataAnnotations.Schema;


namespace filtroCandidatos.Models
{
    class ong
    {
        [Column("id")]
        public int id { get; set; }

        [Column("nome_de_ongs")]
        public string nome_ongs { get; set; }

        [Column("responsavel_ongs")]
        public string responsavel_ongs { get; set; }

        [Column("cnpj")]
        public string cnpj { get; set; }

        [Column("cpf_responsavel")]
        public string cpf_responsavel { get; set; }

        [Column("telefone")]
        public string telefone { get; set; }

        [Column("orcamento")]
        public float orcamento { get; set; }

        [Column("emailong")]

        public string emailong { get; set; }




    }
}
