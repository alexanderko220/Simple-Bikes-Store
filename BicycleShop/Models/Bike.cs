using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BicycleShop.Models
{
    public class Bike
    {
        public int BikeId { get; set; }
        [Required(ErrorMessage = "Please enter a bike model")]
        public string Model { get; set; }
        [Required(ErrorMessage = "Please enter a description")]
        [Display(Name = "Short Description")]
        public string ShortDescription { get; set; }
        [Display(Name = "Long Description")]
        public string LongDescription { get; set; }
        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Please enter a positive price")]
        public decimal Price { get; set; }
        [Display(Name = "Image Url")]
        public string ImageUrl { get; set; }
        [Display(Name = "Image Thumbnail Url")]
        public string ImageThumbnailUrl { get; set; }
        [Display(Name = "Is Bike Of The Week")]
        public bool IsBikeOfTheWeek { get; set; }
        [Display(Name = "Is In Stock")]
        public bool InStock { get; set; }
        [Required(ErrorMessage = "Please specify a category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        //public int specificationId {get;set;}
        public Specification Specifications { get; set; }
    }
}
