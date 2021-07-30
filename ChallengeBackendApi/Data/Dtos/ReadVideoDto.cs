using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ChallengeBackendApi.Data.Dtos
{
    public class ReadVideoDto
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo título é obrigatório")]
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        [Required(ErrorMessage = "O campo URL é obrigatório")]
        public string Url { get; set; }
    }
}
