using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Empresa
{
    [Key]
    public int EmpresaId { get; set; }

    [Required]
    [MaxLength(14)]
    public required string CNPJ { get; set; }

    [Required]
    [MaxLength(100)]
    public required string NomeFantasia { get; set; }

    [Required]
    [MaxLength(8)]
    public required string CEP { get; set; }

    public required ICollection<FornecedorEmpresa> Fornecedores { get; set; }
}
