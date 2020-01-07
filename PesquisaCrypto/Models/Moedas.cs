using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PesquisaCrypto.Models
{
    public class Moedas
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public int Quantidade { get; set; }

        //Criação de um checkbox que não será salvo no banco de dados
        [NotMapped]
        public bool CheckBox { get; set; }
    }
}
