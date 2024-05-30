﻿using System.ComponentModel.DataAnnotations;
using Fina.Core.Enums;

namespace Fina.Core.Requests.Transactions;

public class UpdateTransactionRequest : Request
{
    public long Id { get; set; }
    [Required(ErrorMessage = "Título inválido")]
    public string Title { get; set; } = string.Empty;
    [Required(ErrorMessage = "Tipo Inválido")]
    public ETransactionType Type { get; set; } = ETransactionType.Withdraw;
    [Required(ErrorMessage = "Valor inválido")]
    public decimal Amount { get; set; }
    [Required(ErrorMessage = "Categoria inválida")]
    public long CategoryId { get; set; }
    [Required(ErrorMessage = "Data inválida")]
    public DateTime? PaidOrReceveidAt { get; set; }
}