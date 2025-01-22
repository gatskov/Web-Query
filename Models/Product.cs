using System;
using System.ComponentModel.DataAnnotations;
namespace WebQuery.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string? Вх_N { get; set; }
        [Required]
        public string? Заказчик { get; set; }
        [Required]
        public string? Предмет_запроса { get; set; }
        [Required]
        public string? Объект { get; set; }
        [Required]
        public string? Примечание1 { get; set; }
        [Required]
        public string? На_сервере { get; set; }
        [Required]
        public string? Реестр_ТКП { get; set; }
        [Required]
        public string? Ответственный { get; set; }
        [Required]
        public string? Примечание2 { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public int? Статус { get; set; }
        [Required]
        public int? status { get; set; }
        [DataType(DataType.Date)]
        public DateOnly? Date { get; set; } 
    }
}
