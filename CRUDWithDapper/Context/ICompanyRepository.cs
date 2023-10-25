using CRUDWithDapper.Entites;

namespace CRUDWithDapper.Context
{
    public interface ICompanyRepository
    {

        public Task<IEnumerable<Company>> GetCompanies();
        public Task<Company> GetCompany(int id);
        //public Task CreateCompany(CompanyForCreationDto company);
        public Task<Company> CreateCompany(CompanyForCreationDto company);
        public Task UpdateCompany(int id, CompanyForUpdateDto company);
        public Task DeleteCompany(int id);
        public Task<Company> GetCompanyByEmployeeId(int id);
        public Task<Company> GetCompanyEmployeesMultipleResults(int id);
        public Task<List<Company>> GetCompaniesEmployeesMultipleMapping();
    }
}
