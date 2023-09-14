﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.ComponentModel.DataAnnotations.Schema;

namespace filtroCandidatos.Models
{
   public class Pagamento
    {
        [Column ("id")]

        public int id { get; set; }

        [Column ("numero_do_cartao")]

        public int numero_do_cartao { get; set; }

        [Column ("cvc")]
        
        public int cvc { get; set; }

        [Column ("nome_cartao")]

        public int nome_cartao { get; set; }

        [Column ("cpf_cartao")]

        public int cpf_cartao { get; set; }

        [Column ("pacote")]

        public int pacote { get; set; }

        [Column ("validade_do_cartao")]

        public int validade_do_cartao { get; set; }

        [Column ("chave")]

        public int chave { get; set; }
    }
}