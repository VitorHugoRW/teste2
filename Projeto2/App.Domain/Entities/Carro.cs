using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Entities
{
    public class Carro
    {
        [Key]
        public Guid Id { get; set; }
        public string nome_carros { get; set; }
        public int ano_carros { get; set; }
        public string modelo_carros { get; set; }

    }
}
