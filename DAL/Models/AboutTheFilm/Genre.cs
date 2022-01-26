using System;

namespace NIx_CinemaSite.DAL.Models.AboutTheFilm
{
    public class Genre
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string GenreName { get; set; } //Название жанра



        //public bool Arthouse { get; set; } //Артхаус
        //public bool Biography { get; set; } //Биография
        //public bool Militants { get; set; } //Боевики
        //public bool WesternFilm { get; set; } //Вестерн
        //public bool Military { get; set; } //Военные
        //public bool Detectives { get; set; } //Детективы
        //public bool ForKids { get; set; } //Для детей
        //public bool Documentary { get; set; } //Документальные
        //public bool Dramas  { get; set; } //Драмы
        //public bool Foreign { get; set; } //Зарубежные
        //public bool Historical { get; set; } //Исторические
        //public bool Catastrophes { get; set; } //Катастрофы
        //public bool Comedy { get; set; } //Комедии
        //public bool Crime { get; set; } //Криминал
        //public bool Melodrama { get; set; } //Мелодрамы
        //public bool Mystical { get; set; } //Мистические
        //public bool Musical { get; set; } //Музыкальные
        //public bool ByComics { get; set; } //По комиксам
        //public bool Adventures { get; set; } //Приключения
        //public bool Russians { get; set; } //Русские
        //public bool Ukrainian { get; set; } //Украинские 
        //public bool Family { get; set; } //Семейные
        //public bool Soviet { get; set; } //Советские
        //public bool Sport { get; set; } //Спорт
        //public bool Thrillers { get; set; } //Триллеры
        //public bool Horror { get; set; } //Ужасы
        //public bool Fantasy { get; set; } //Фэнтези
    }
}
