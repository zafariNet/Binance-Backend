using System.ComponentModel.DataAnnotations;

namespace Maya.Project.Authorization.Accounts.Dto
{
    public class SendEmailActivationLinkInput
    {
        [Required]
        public string EmailAddress { get; set; }
    }
}