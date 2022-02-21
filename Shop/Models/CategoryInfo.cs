using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models
{
    public class CategoryInfo
    {
        public string Id { get; set; }
        public string Date_record { get; set; }
        public string Id_user { get; set; }
        [Required(ErrorMessage = "Поле не заполнено"), DisplayName("Имя")]
        public string Name { get; set; }
        public bool Block { get; set; } = false;
    }
}
