using Domain.Models;
using Repository.Implementations;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services
{
    public class CompanyService : ICompanyService
    {
        public CompanyRepository _companyRepository;
        private int Count { get; set; }
        public CompanyService()
        {
            _companyRepository = new CompanyRepository();
        }
        public Company Create(Company model)
        {
            model.Id = Count;
            _companyRepository.Create(model);
            Count++;
            return model;
        }

        public void Delete(Company model)
        {
            throw new NotImplementedException();
        }

        public Company Get(Predicate<Company> filter)
        {
            throw new NotImplementedException();
        }

        public List<Company> GetAll(Predicate<Company> filter)
        {
            throw new NotImplementedException();
        }

        public Company Update(int id, Company model)
        {
            throw new NotImplementedException();
        }
    }
}
