using System.ComponentModel.DataAnnotations;

namespace Maya.Project.Authorization.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}
