using System;

namespace api.Dtos.Comment
{
    public class CommentDto : BaseCommentDto
    {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
        public int? StockId { get; set; }
    }

}
