using System.ComponentModel.DataAnnotations;

namespace AptekaCursovoy.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Имя { get; set; }
        public string Фамилия { get; set; }
        public string Должность { get; set; }
        [DataType(DataType.Date)]
        public DateTime ДатаРождения { get; set; }
        public string Адрес { get; set; }
        public string Телефон { get; set; }
        public string Email { get; set; }
        public int Зарплата { get; set; }
        public string Фото { get; set; }

    }
}
