using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;
using Entities.Concrete;

namespace Entities.DTOs
{
    public class CarDetailDto : IDto
    {

        public int CarId { get; set; }
        public string BrandName { get; set; }
        public string ColorName { get; set; }
        public string CarName { get; set; }
        public int DailyPrice { get; set; }
        public int ModelYear { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public int FindexPoint { get; set; }

    }
}