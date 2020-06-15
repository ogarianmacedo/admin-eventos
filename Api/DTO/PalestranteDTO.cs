using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Api.DTO
{
    public class PalestranteDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage="Campo {0} obrigatório!")]
        public string Nome { get; set; }

        [Required(ErrorMessage="Campo {0} obrigatório!")]
        public string Descricao { get; set; }

        [Required(ErrorMessage="Campo {0} obrigatório!")]
        public string Telefone { get; set; }

        [Required(ErrorMessage="Campo {0} obrigatório!")]
        public string Email { get; set; }

        public string ImagemUrl { get; set; }

        public List<RedeDTO> Redes { get; set; }

        public List<EventoDTO> Eventos { get; set; }
    }
}