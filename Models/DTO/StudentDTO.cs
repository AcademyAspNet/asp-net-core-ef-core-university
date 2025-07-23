using System.ComponentModel.DataAnnotations;

namespace WebApplication9.Models.DTO
{
    public class StudentDTO
    {
        [Required(ErrorMessage = "Укажите имя студента")]
        [MaxLength(64, ErrorMessage = "Слишком длинное имя студента")]
        [MinLength(2, ErrorMessage = "Слишком короткое имя студента")]
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "Укажите фамилию студента")]
        [MaxLength(64, ErrorMessage = "Слишком длинная фамилия студента")]
        [MinLength(2, ErrorMessage = "Слишком короткая фамилия студента")]
        public string? LastName { get; set; }

        [Required(ErrorMessage = "Укажите адрес электронной почты студента")]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }
    }
}
