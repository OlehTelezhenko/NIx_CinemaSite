using System;
using System.ComponentModel.DataAnnotations;


//Зародыш
public class UserAuthorization
{
    public Guid Id { get; set; } = Guid.NewGuid();

    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    public string Password { get; set; }

}
