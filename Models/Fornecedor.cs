using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Fornecedor
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(14)]
    public required string CpfCnpj { get; set; }

    [Required]
    [MaxLength(100)]
    public required string Nome { get; set; }

    [Required]
    [EmailAddress]
    public required string Email { get; set; }

    [Required]
    [MaxLength(8)]
    public required string CEP { get; set; }

    public required string RG { get; set; }
    public DateTime? DataNascimento { get; set; }

    public required ICollection<FornecedorEmpresa> Empresas { get; set; }
}
