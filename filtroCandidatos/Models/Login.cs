using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace filtroCandidatos.Models
{

    public class  Login
    {

        [Column("id")]
        public int id { get; set; }

        [Column("email")]
        public int email{ get; set; }

        [Column("tipo_de_acesso")]
        public string tipo_de_acesso { get; set; }

        [Column("senha")]
        public string senha { get; set; }

        [Column("id_cadastro")]
        public string id_cadastro { get; set; }

    }
}
