﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tourism.Models
{
    //TODO: удалить
    public class OfferModel
    {
        [Required(ErrorMessage = "Не указан город")]
        public string City { get; set; }
        [Required(ErrorMessage = "Не указано описание")]
        public string TextOfOffer { get; set; }
        [Required(ErrorMessage = "Не указана дата начала")]
        public DateTime DateOfOfferFrom { get; set; }
        [Required(ErrorMessage = "Не указана дата окончания")]
        public DateTime DateOfOfferTo { get; set; }
        [Required(ErrorMessage = "Не указана стоимость")]
        public int Price { get; set; }
    }
}
