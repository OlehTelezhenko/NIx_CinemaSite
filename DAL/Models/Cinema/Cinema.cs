using System;
using System.ComponentModel.DataAnnotations;
using WebMyCinema.ValidationAttributes;

public class Cinema
{
    [Required]
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();

    [Required]
    [StringLength(20)]
    public string Name { get; set; }

    [Required]
    public string Address { get; set; }

    [Required]
    [MaxLength(2000)]
    public string AboutTheCinema { get; set; }

    [Required]
    [PhoneNumber]//Переделать 
    public string CinemaPhoneNumber { get; set; }

    [Required]
    [Url]
    public string Photography { get; set; }//фото кинотеатра

}
