using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CadastroEncomenda.Models
{
    public class EncomendaModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Volume { get; set; }
        public decimal Frete { get; set; }

    }
}