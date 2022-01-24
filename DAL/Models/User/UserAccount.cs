using System;
using System.ComponentModel.DataAnnotations;
using WebMyCinema.ValidationAttributes;

public class UserAccount
{
    public Guid Id { get; set; } = Guid.NewGuid();

    [Required]
    [MaxLength(100), MinLength(2)]
    public string Username { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }

    public string FullPhoneNumber { get; set; }

    [PhoneNumber]
    [MaxLength(10)]
    public string PhoneNumber { get; set; }
    //Принимает 10 цифр, например 0931112233
    public decimal Account { get; set; } //Денежный счет
}
