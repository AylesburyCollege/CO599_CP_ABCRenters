using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CO599_CP_ABCRenters.Models
{

   public enum Categories
    {
        Flats,
        SemiDetatched,
        Detatched,
        Bungalow,
        Terraced
    }

    public enum EstateAgents
    {
        [Display(Name = "Brown & Merry")]
        BROWNMERRY,

        [Display(Name = "Michaael Anthony")]
        MICHAELANTHONY,

        [Display(Name = "Taylors")]
        TAYLORS,

        [Display(Name = "Williams")]
        WILLIAMS
    }

    public class Property
    {
        public int PropertyID { get; set; }

        [Required, StringLength(35), Display(Name = "Title")]
        public string Name { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        [Required, DisplayFormat(DataFormatString = "{0:c}", ApplyFormatInEditMode = false) , Display(Name = "Price Per Calender Month")]
        public decimal Price { get; set; }

        public Categories Category { get; set; }

        [Required, DataType(DataType.DateTime), Display(Name = "Date of availablity")]
        [DisplayFormat(DataFormatString = "{0:yyyy/mm/dd}", ApplyFormatInEditMode = true)]
        public DateTime AvailableDate { get; set; }


        public EstateAgents EstateAgent { get; set; }

        [Display(Name = "Number of Bedrooms")]
        public int Bedrooms { get; set; }

        public string AddressID { get; set; }
        
        [Display(Name = "Pets Allowed")]

        public bool PetsAllowed { get; set; }

        [Display(Name = "Shared Accommodation")]

        public bool IsShared { get; set; }

        public virtual Address Address { get; set; }

        public virtual ICollection<PropertyImage> ImagesList { get; set; }
    }
}