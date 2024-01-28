using System.ComponentModel.DataAnnotations;

namespace AptekaCursovoy.Models
{
    public class Tovar
    {
        public int Id { get; set; }
        public string Название { get; set; }
        public string Категория { get; set; }
        public int Цена { get; set; }
        public string Количество { get; set; }
        public string Производитель { get; set; }
        public string Поставщик { get; set; }
        [DataType(DataType.Date)]
        public DateTime ДатаПоступления { get; set; }
        public string Описание { get; set; }
        public string Фото { get; set; }
    }
}
