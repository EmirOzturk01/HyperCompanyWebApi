using System.ComponentModel.DataAnnotations;

namespace Hyper.WebApi.Models.Dtos.Boat
{
    public class BoatCreateDTO
    {

        [Required(ErrorMessage = "Lütfen aracın rengini giriniz.")]
        public string Color { get; set; }

    }
}
