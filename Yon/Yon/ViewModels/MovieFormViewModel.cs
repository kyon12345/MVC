using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Yon.Models;
using System.ComponentModel.DataAnnotations;

namespace Yon.ViewModels
{
    public class MovieFormViewModel
    {
        public MovieFormViewModel()
        {
            Id = 0;
        }
        public MovieFormViewModel(Movie movie)
        {
            Id = movie.Id;
            Name = movie.Name;
            DateReleased = movie.DateReleased;
            NumberInStock = movie.NumberInStock;
            GenreId = movie.GenreId;
        }
        public IEnumerable<Genre> Genres { get; set; }

        public int? Id { get; set; }
        [Required(ErrorMessage = "Please enter movie's name")]
        [StringLength(255)]
        public string Name { get; set; }


     

        [Required]
        [Display(Name = "Genre")]
        public byte? GenreId { get; set; }

        [Required]
        public DateTime? DateReleased { get; set; }

        [Range(1, 20)]
        [Required]
        public byte? NumberInStock { get; set; }


        public string Title
        {
            get
            {
                if(Id!=0)
                    return "Edit Movie";
                return "New Movie";


            }
        }
    }
}