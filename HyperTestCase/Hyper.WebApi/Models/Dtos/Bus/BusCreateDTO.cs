using System.ComponentModel.DataAnnotations;

namespace Hyper.WebApi.Models.Dtos.Bus
{
    public class BusCreateDTO
    {
        [Required(ErrorMessage = "Lütfen aracın rengini giriniz.")]
        public string Color { get; set; }
    }
}
