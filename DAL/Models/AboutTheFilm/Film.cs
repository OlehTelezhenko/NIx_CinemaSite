using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WebMyCinema.Models;

public class Film
{
    public Guid Id { get; set; } = Guid.NewGuid(); //Ааааайди
    [Required]
    [StringLength(20)]
    public string Title { get; set; } //Название фильма
    [Required]
    [StringLength(20)]
    public string Cauntry { get; set; } //Страна        
    [Required]
    public List<Genre> Genre { get; set; } //Жанр                                             ?
    [Required]
    public float Rating { get; set; } //Оценка, например 7.7
    [Required]
    public DataType ReleaseDate { get; set; } //Дата выхода фильма
    [Required]
    [MaxLength(2000)]
    public string Description { get; set; } //Описание
    [Required]
    public int Duration { get; set; } //Продолжительность фильма в минутах
    [Required]
    public string Director { get; set; } //Режиссер

    public List<Actor> Actors; //Актеры                                               ?
    
    [Url]
    public string MoviePoster { get; set; } //Обложка кино
    [Url]
    public string MovieTrailer { get; set; } //Трейлер
}
