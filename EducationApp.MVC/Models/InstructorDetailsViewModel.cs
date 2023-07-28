using System;
namespace EducationApp.MVC.Models
{
    public class InstructorDetailsViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }
        public string InstructorName { get; set; }
        public string InstructorAbout { get; set; }
        public string InstructorUrl { get; set; }
        public List<CategoryViewModel> Categories { get; set; }
        public int EditionYear { get; set; }
        public int EditionNumber { get; set; }
        public int Stock { get; set; }
        public int PageCount { get; set; }
        public string Description { get; set; }
    }
}

