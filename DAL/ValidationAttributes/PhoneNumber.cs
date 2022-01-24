using System.ComponentModel.DataAnnotations;


namespace WebMyCinema.ValidationAttributes

{
    public class PhoneNumber : ValidationAttribute
    {
        public bool IsValid(string value)
        {
            if (value.Length != 10)
            {
                this.ErrorMessage = "Номер должен содержать 10 цифр";
            }
            return false;
        }
    }
}
