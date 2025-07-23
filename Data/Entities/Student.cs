using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication9.Data.Entities
{
    [Table("students")]
    public class Student
    {
        [Column("id")]
        public required int Id { get; set; }

        [Column("first_name")]
        [MaxLength(64)]
        public required string FirstName { get; set; }

        [Column("last_name")]
        [MaxLength(64)]
        public string? LastName { get; set; }

        [Column("email_address")]
        public required string Email { get; set; }

        [Column("created_at")]
        public required DateTime CreatedAt { get; set; } = DateTime.Now;

        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
