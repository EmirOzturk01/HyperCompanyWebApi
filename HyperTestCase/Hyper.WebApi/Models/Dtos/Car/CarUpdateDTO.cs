using System.ComponentModel.DataAnnotations;

namespace Hyper.WebApi.Models.Dtos.Car
{
    public class CarUpdateDTO
    {
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "Lütfen aracın rengini giriniz.")]
        public string Color { get; set; }

        [Required(ErrorMessage = "Lütfen aracın farlarının açıklık durumunu giriniz.")]
        public bool HeadlightsOn { get; set; }

        [Required(ErrorMessage = "Lütfen aracın tekerlek adetini giriniz.")]
        public int Wheels { get; set; }
    }
}
