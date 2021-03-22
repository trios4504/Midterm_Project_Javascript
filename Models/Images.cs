using System;
namespace Midterm_Project.Models
{
    public class Images
    {
        public Images()
        {
        }


        public int ImagesId { get; set; }
        public string ImageAlt { get; set; }
        public string ImagePath { get; set; }
        public string Description { get; set; }
    }
}