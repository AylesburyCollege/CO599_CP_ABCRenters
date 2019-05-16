using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CO599_CP_ABCRenters.Models
{

    public enum Counties

    {

        [Display(Name = "Buckinghamshire")]

        BUCKINGHAMSHIRE,

        [Display(Name = "London")]

        LONDON,

        [Display(Name = "Tyne and Wear")]

        TYNEANDWEAR,

        [Display(Name = "Warwickshire")]

        WARWICKSHIRE


    }

    public class Address
    {
       
        public int AddressID { get; set; }

        [Required, StringLength(30), Display(Name = "House Name/Number")]
        public string House { get; set; }

        [StringLength(30), Display(Name = "Street Name")]
        public string StreetName { get; set; }

        [Required, StringLength(30), Display(Name = "Town Name")]
        public string TownName { get; set; }

        [Required, StringLength(10)]
        public string Postcode { get; set; }

        public Counties County { get; set; }




    }
}