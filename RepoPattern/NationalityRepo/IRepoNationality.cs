using MoviesProject.DTO.Nationilty_Dto;

namespace MoviesProject.RepoPattern.NationalityRepo
{
    public interface IRepoNationality
    {
        public void AddNationality(NationalityDto dto);
        public void DeleteNationality(int id);
    }
}
