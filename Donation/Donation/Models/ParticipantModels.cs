using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Donation.Models
{
    public class ParticipantModels
    {
        [Key]
        public int clienteId { get; set; }

        [Required(ErrorMessage = "Preencha o campo nome")]
        [MaxLength(150, ErrorMessage = "Maximo {0} Caracteres")]
        [MinLength(2, ErrorMessage = "minomo {0} caracteres")]
        public string Name { get; set; }

                
        [Required(ErrorMessage = "Preencha o campo idade")]
        public int Idade { get; set; }

        public bool Ativo { get; set; }

        public string PersonType { get; set; }

        
    }
}