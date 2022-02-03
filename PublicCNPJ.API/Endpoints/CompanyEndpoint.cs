using Microsoft.AspNetCore.Mvc;

namespace PublicCNPJ.API.Endpoints;

public static class CompanyEndpoint
{
    public static void MapCompanyEndpoints(this WebApplication app)
    {
        app.MapGet("/getcompany", async ([FromServices] ICompanyService service, 
            [FromQuery] string cnpj) => await GetCompany(service, cnpj));

        app.MapPost("/getcompanies", async([FromServices] ICompanyService service, 
            [FromBody] IEnumerable<string> cnpjs) => await GetCompanies(service, cnpjs));
    }

    private async static Task<IResult> GetCompanies(ICompanyService service, IEnumerable<string> cnpjs)
    {
        if (!cnpjs.TryFilter(out IEnumerable<string> filteredCnpj)) return Results.BadRequest("Formato incorreto de CNPJ");

        var response = await service.GetCompaniesAsync(filteredCnpj);

        if (response == null) return Results.NotFound("O CNPJ não foi encontrado.");

        return Results.Ok(response);
    }

    private async static Task<IResult> GetCompany(ICompanyService service, string cnpj)
    {
        if (!cnpj.TryFilter(out string filteredCnpj)) return Results.BadRequest("Formato incorreto de CNPJ");

        var response = await service.GetCompanyAsync(filteredCnpj);

        if (response == null) return Results.NotFound("O CNPJ não foi encontrado.");

        return Results.Ok(response);
    }
}