using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace dvdCollection.Models
{
    public class dvd
    {


        public int dvdId { get; set; }    
        
        [Display(Name="Title")]
        public string dvdTitle { get; set; }
        [Display(Name ="Director")]
        public string dvdDirector { get; set; }
        [Display(Name ="Genre")]
        public Genre genre { get; set; }


    }
}