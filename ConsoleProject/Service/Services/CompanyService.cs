using Domain.Models;
using Repository.Implementations;
using Service.Services.InterFaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services
{
    public class CompanyService : ICompanyService
    {
        private CompanyRepository _CompanyRepository;
        public CompanyService()
        {
            _CompanyRepository = new CompanyRepository();
        }
        public Company Create(Company model)
        {
            throw new NotImplementedException();
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
