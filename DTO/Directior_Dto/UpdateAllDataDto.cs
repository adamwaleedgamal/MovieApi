using System.ComponentModel.DataAnnotations;
using MoviesProject.DTO;
using MoviesProject.DTO;
using MoviesProject.DTO.Categoiry_Dto;
using MoviesProject.DTO.Nationilty_Dto;

namespace MoviesProject.DTO.Directior_Dto
{
    public class UpdateAllDataDto
    {
        [Required]
        public string DirictorName { get; set; }
        [Phone]
        public string DirictorContact { get; set; }
        [EmailAddress]
        public string DirictorrEmail { get; set; }
        public NationalityDto Nationality { get; set; }
        public List<MovieDto> Movies { get; set; }
        public CategoryDto categoryDtos { get; set; }

    }
}
