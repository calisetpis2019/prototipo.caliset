using System.ComponentModel.DataAnnotations;

namespace prototipo.caliset.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}