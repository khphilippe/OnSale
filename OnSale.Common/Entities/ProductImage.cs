using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OnSale.Common.Entities
{
    public class ProductImage
    {
        public int Id { get; set; }

        [Display(Name = "Image")]
        public Guid ImageId { get; set; }

        [Display(Name = "Image")]
        public string ImageFullPath => ImageId == Guid.Empty
            ? $"http://onsalekevs.somee.com/images/noimage.png"
            : $"https://onsalekevs.blob.core.windows.net/products/{ImageId}";
        
    }

}
