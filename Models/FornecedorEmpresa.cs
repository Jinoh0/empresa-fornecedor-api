public class FornecedorEmpresa
{
    public int EmpresaId { get; set; }
    public required Empresa Empresa { get; set; }

    public int FornecedorId { get; set; }
    public required Fornecedor Fornecedor { get; set; }
}
