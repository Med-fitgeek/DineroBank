using System.ComponentModel.DataAnnotations;

namespace TransactionService.Models
{
    public class Transaction
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public Guid AccountId { get; set; }

        public Guid? TargetAccountId { get; set; } // transfert uniquement

        [Required]
        public decimal Amount { get; set; }

        [Required]
        public string Type { get; set; } // CREDIT | DEBIT | TRANSFER

        public string? Description { get; set; }

        public Guid UserId { get; set; } // Extracted from JWT

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
