﻿using OnSale.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnSale.Common.Responses
{
    public class ProductResponse
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public bool IsActive { get; set; }

        public bool IsStarred { get; set; }

        public Category Category { get; set; }

        public ICollection<ProductImage> ProductImages { get; set; }

        public int ProductImagesNumber => ProductImages == null ? 0 : ProductImages.Count;

        public string ImageFullPath => ProductImages == null || ProductImages.Count == 0
            ? $"http://onsalekevs.somee.com//images/noimage.png"
            : ProductImages.FirstOrDefault().ImageFullPath;

        public ICollection<QualificationResponse> Qualifications { get; set; }

        public int ProductQualifications => Qualifications == null ? 0 : Qualifications.Count;

        public float Qualification => Qualifications == null || Qualifications.Count == 0 ? 0 : Qualifications.Average(q => q.Score);
    }

}
