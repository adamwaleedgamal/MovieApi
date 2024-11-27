using MoviesProject.DTO.Nationilty_Dto;
using MoviesProject.Models;
using System.ComponentModel.DataAnnotations;

namespace MoviesProject.DTO.Directior_Dto
{
    public class DirictorDto
    {
        [Required]
        public string DirictorName { get; set; }
        [Phone]
        public string DirictorContact { get; set; }
        [EmailAddress]
        public string DirictorrEmail { get; set; }
        public NationalityDto Nationality { get; set; }
    }
}
