﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OnSale.Common.Entities
{
    public class Category
    {
        public int Id { get; set; }

        [MaxLength(50)]
        [Required]
        public string Name { get; set; }

        [Display(Name = "Image")]
        public Guid ImageId { get; set; }

        [Display(Name = "Image")]
        public string ImageFullPath => ImageId == Guid.Empty
           // ? $"https://localhost:44335/images/noimage.png" 

            ? $"http://onsalekevs.somee.com/images/noimage.png"
            : $"https://onsalekevs.blob.core.windows.net/categories/{ImageId}";
    }
}