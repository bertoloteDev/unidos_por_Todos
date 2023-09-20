using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace filtroCandidatos.Models
{
    public class Localidade

    {

        [Column("id")]

        public int Id { get; set; }



        [Column("nome_cidade")]

        public string Nome_cidade { get; set; }



        [Column("posicao")]

        public int posicao { get; set; }



        [Column("estado")]

        public string estado { get; set; }



        [Column("indiceidh")]

        public string indiceidh { get; set; }


        [Column("regiao")]

        public string regiao { get; set; }



    }
}
