using System.ComponentModel.DataAnnotations;

namespace Hyper.WebApi.Models.Dtos.Boat
{
    public class BoatUpdateDTO
    {
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "Lütfen aracın rengini giriniz.")]
        public string Color { get; set; }

    }
}
