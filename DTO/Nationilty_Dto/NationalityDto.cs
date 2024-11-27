using System.ComponentModel.DataAnnotations;

namespace MoviesProject.DTO.Nationilty_Dto
{
    public class NationalityDto
    {
        [Required]
        public string NationalityName { get; set; }
    }
}
