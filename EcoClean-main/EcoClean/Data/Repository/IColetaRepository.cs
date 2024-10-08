﻿using EcoClean.Models;

namespace EcoClean.Data.Repository
{
    public interface IColetaRepository
    {
        IEnumerable<ColetaModel> GetAll();

        ColetaModel GetById(long Id);
        void Add(ColetaModel coleta);
        void Update(ColetaModel coleta);
        void Delete(ColetaModel coleta);
    }
}
