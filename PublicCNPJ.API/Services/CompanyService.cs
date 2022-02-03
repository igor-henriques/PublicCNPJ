namespace PublicCNPJ.API.Services;

public class CompanyService : ICompanyService
{
    private readonly SQLiteConnection connection;

    public CompanyService(Context context)
    {
        this.connection = context.GetSQLiteConnection;
    }

    public async Task<GetCompaniesDTO> GetCompaniesAsync(IEnumerable<string> cnpjs)
    {
        GetCompaniesDTO response = new();

        string sql = $"SELECT * FROM cnpj_dados_cadastrais_pj WHERE cnpj IN ('{string.Join("','", cnpjs)}')";

        response.SuccessfullCompanies = await connection.QueryAsync<Company>(sql);

        response.FailedCompanies = cnpjs.Where(cnpj => !response.SuccessfullCompanies.Select(x => x.cnpj).Contains(cnpj)).ToList();

        return response;
    }
    public async Task<Company> GetCompanyAsync(string cnpj)
    {
        const string sql = "SELECT * FROM cnpj_dados_cadastrais_pj WHERE cnpj = @cnpj";

        var response = await connection.QueryFirstAsync<Company>(sql, param: new { cnpj });

        return response;
    }
}