namespace PublicCNPJ.API.Interfaces
{
    public interface ICompanyService
    {
        Task<GetCompaniesDTO> GetCompaniesAsync(IEnumerable<string> cnpjs);
        Task<Company> GetCompanyAsync(string cnpj);
    }
}