﻿using MoviesProject.DTO.Directior_Dto;

namespace MoviesProject.RepoPattern.DirictorRepo
{
    public interface IRepoDirictor
    {
        public void AddDirictor(DirictorDto dto);  
        public void UpdateAllData(UpdateAllDataDto dto , int id);
        public void DeleteDirictor(int id);
    }
}