using System.ComponentModel.DataAnnotations;

namespace MyAbpProject6.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}