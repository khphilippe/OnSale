﻿using Newtonsoft.Json;
using OnSale.Common.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnSale.Web.Data.Entities
{
    public class Qualification
    {
        public int Id { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd hh:mm}")]
        public DateTime Date { get; set; }

        [Display(Name = "Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd hh:mm}")]
        public DateTime DateLocal => Date.ToLocalTime();

        [JsonIgnore]
        public Product Product { get; set; }

        public User User { get; set; }

        [DisplayFormat(DataFormatString = "{0:N2}")]
        public float Score { get; set; }

        [DataType(DataType.MultilineText)]
        public string Remarks { get; set; }
    }

}
