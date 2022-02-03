namespace PublicCNPJ.API.Models;

public class GetCompaniesDTO
{
    public IEnumerable<Company> SuccessfullCompanies { get; set; }
    public List<string> FailedCompanies { get; set; }
}