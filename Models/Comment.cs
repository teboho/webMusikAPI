using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;

namespace webMusikAPI.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        public string TrackId { get; set; }
        public string CommentText { get; set; }
        public string UserId { get; set; }
        public DateTime Posted { get; set; }
    }
}
