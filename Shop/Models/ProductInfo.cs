using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models
{
    public class ProductInfo 
    {
        public string Id { get; set; }
        public string Date_record { get; set; }
        public string Id_user { get; set; }
        [Required(ErrorMessage ="Поле не заполнено"), DisplayName("Категория")]
        public string Category { get; set; }
        [Required(ErrorMessage = "Поле не заполнено"), DisplayName("Наименование")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Поле не заполнено"), DisplayName("Описание")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Поле не заполнено"), DisplayName("Цена")]
        public int Price { get; set; }
        [Required(ErrorMessage = "Загрузите изображение"), DisplayName("Изображение")]
        public string Image_url { get; set; }
        public bool Block { get; set; } = false;
        
    }
}
