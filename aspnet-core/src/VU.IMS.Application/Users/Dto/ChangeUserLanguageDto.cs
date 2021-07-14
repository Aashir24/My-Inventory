using System.ComponentModel.DataAnnotations;

namespace VU.IMS.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}