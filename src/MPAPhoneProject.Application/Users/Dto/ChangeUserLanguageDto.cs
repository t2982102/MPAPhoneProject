using System.ComponentModel.DataAnnotations;

namespace MPAPhoneProject.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}