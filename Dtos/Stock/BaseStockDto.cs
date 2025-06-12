using System;
using System.ComponentModel.DataAnnotations;

using api.Dtos.Comment;

namespace api.Dtos.Stock
{
    public class BaseStockDto
    {
        [Required]
        [MinLength(1, ErrorMessage = "Symbol must be min 1 characters")]
        [MaxLength(10, ErrorMessage = "Symbol cannot be over 10 characters")]
        public string Symbol { get; set; } = string.Empty;

        [Required]
        [MinLength(1, ErrorMessage = "Company name must be min 1 characters")]
        [MaxLength(20, ErrorMessage = "Company name cannot be over 20 characters")]
        public string CompanyName { get; set; } = string.Empty;

        [Required]
        [Range(1, 1000000000)]
        public decimal Purchase { get; set; }

        [Required]
        [Range(0.001, 1000000000)]
        public decimal LastDiv { get; set; }

        [Required]
        [MinLength(1, ErrorMessage = "Industry must be min 1 characters")]
        [MaxLength(20, ErrorMessage = "Industry cannot be over 20 characters")]
        public string Industry { get; set; } = string.Empty;

        [Required]
        [Range(1, 5000000000)]
        public long MarketCap { get; set; }
        public List<CommentDto>? Comments { get; set; }
    }

}
