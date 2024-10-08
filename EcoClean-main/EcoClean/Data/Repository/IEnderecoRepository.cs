﻿using EcoClean.Models;

namespace EcoClean.Data.Repository
{
    public interface IEnderecoRepository
    {
        IEnumerable<EnderecoModel> GetAll();

        EnderecoModel GetById(long Id);
        EnderecoModel FindByCep(string Cep);
       
        void Add(EnderecoModel endereco);
        void Update(EnderecoModel endereco);
        void Delete(EnderecoModel endereco);
    }
}
