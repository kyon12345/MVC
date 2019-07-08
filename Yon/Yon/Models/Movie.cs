using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Yon.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Please enter movie's name")]
        [StringLength(255)]
        public string Name { get; set; }

       
        public Genre Genre { get; set; }

        [Required]
        [Display(Name="Genre")]
        public byte GenreId { get; set; }

        public DateTime DateAdded { get; set; }
        public DateTime DateReleased { get; set; }  

        [Range(1,20)]
        public byte NumberInStock { get; set; }
    }
}