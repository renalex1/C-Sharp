using System;
using System.ComponentModel.DataAnnotations;

namespace api.Dtos.Comment
{
    public class BaseCommentDto
    {
        [Required]
        [MinLength(5, ErrorMessage = "Title must be min 5 characters")]
        [MaxLength(280, ErrorMessage = "Title cannot be over 280 characters")]
        public string Title { get; set; } = string.Empty;

        [Required]
        [MinLength(5, ErrorMessage = "Context must be min 5 characters")]
        [MaxLength(280, ErrorMessage = "Context cannot be over 280 characters")]
        public string Content { get; set; } = string.Empty;

    }

}
