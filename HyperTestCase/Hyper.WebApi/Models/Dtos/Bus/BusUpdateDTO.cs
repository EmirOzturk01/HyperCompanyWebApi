using System.ComponentModel.DataAnnotations;

namespace Hyper.WebApi.Models.Dtos.Bus
{
    public class BusUpdateDTO
    {
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "Lütfen aracın rengini giriniz.")]
        public string Color { get; set; }
    }
}
