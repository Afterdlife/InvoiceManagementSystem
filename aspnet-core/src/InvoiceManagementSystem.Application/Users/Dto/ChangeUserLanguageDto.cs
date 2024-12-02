using System.ComponentModel.DataAnnotations;

namespace InvoiceManagementSystem.Users.Dto;

public class ChangeUserLanguageDto
{
    [Required]
    public string LanguageName { get; set; }
}