namespace PublicCNPJ.API.Models;

public record Company
{
    public string tipo_de_registro { get; set; }
    public string indicador { get; set; }
    public string tipo_atualizacao { get; set; }
    public string cnpj { get; set; }
    public string identificador_matriz_filial { get; set; }
    public string razao_social { get; set; }
    public string nome_fantasia { get; set; }
    public string situacao_cadastral { get; set; }
    public string data_situacao_cadastral { get; set; }
    public string motivo_situacao_cadastral { get; set; }
    public string nm_cidade_exterior { get; set; }
    public string cod_pais { get; set; }
    public string nm_pais { get; set; }
    public string codigo_natureza_juridica { get; set; }
    public string data_inicio_atividade { get; set; }
    public string cnae_fiscal { get; set; }
    public string descricao_tipo_logradouro { get; set; }
    public string logradouro { get; set; }
    public string numero { get; set; }
    public string complemento { get; set; }
    public string bairro { get; set; }
    public string cep { get; set; }
    public string uf { get; set; }
    public string codigo_municipio { get; set; }
    public string municipio { get; set; }
    public string ddd_telefone_1 { get; set; }
    public string ddd_telefone_2 { get; set; }
    public string ddd_fax { get; set; }
    public string correio_eletronico { get; set; }
    public string qualificacao_responsavel { get; set; }
    public string capital_social_empresa { get; set; }
    public string porte_empresa { get; set; }
    public string opcao_pelo_simples { get; set; }
    public string data_opcao_pelo_simples { get; set; }
    public string data_exclusao_simples { get; set; }
    public string opcao_pelo_mei { get; set; }
    public string situacao_especial { get; set; }
    public string data_situacao_especial { get; set; }
    public string filler { get; set; }
    public string fim_registro { get; set; }
}