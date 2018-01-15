using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoffeeShop.Models
{
    public class ModelImageCrop
    {
        public int ViewMode { get; set; }
        public string NameCrop { get; set; }
        public string FileInputID { get; set; }
        public string JQModalSelector { get; set; }
        public string ImageID { get; set; }
        public string TargetUpdate { get; set; }
        public string TargetInputUpdate { get; set; }
        public string ClearButtonID { get; set; }
        public string NoImageUrl { get; set; }
        public int WidthImage { get; set; }
        public int HeightImage { get; set; }
        public bool aspectRatio { get; set; }
    }
}