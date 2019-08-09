using System.ComponentModel.DataAnnotations;

namespace TCCAssociation.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}