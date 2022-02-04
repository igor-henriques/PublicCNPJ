namespace PublicCNPJ.API.Models;

public record Partner
{
    public string tipo_de_registro { get; set; }
    public string indicador { get; set; }
    public string tipo_atualizacao { get; set; }
    public string cnpj { get; set; }
    public string identificador_socio { get; set; }
    public string nome_socio { get; set; }
    public string cnpj_cpf_socio { get; set; }
    public string cod_qualificacao_socio { get; set; }
    public string percentual_capital_socio { get; set; }
    public string data_entrada_sociedade { get; set; }
    public string cod_pais { get; set; }
    public string nome_pais_socio { get; set; }
    public string cpf_representante_legal { get; set; }
    public string nome_representante { get; set; }
    public string cod_qualificacao_representante_legal { get; set; }
    public string fillter { get; set; }
    public string fim_registro { get; set; }
}