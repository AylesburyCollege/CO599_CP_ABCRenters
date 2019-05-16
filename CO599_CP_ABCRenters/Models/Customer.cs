using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CO599_CP_ABCRenters.Models
{
        public enum MaritalStatusOptions

        {

            [Display(Name = "Single")]

            SINGLE,

            [Display(Name = "Married")]

            MARRIED,

            [Display(Name = "Divorced")]

            DIVORCED,

            [Display(Name = "Other")]

            OTHER

        }

    public class Customer
    {
        public int CustomerID { get; set; }

        [Required, StringLength(20), Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required, StringLength(20)]
        public string Surname { get; set; }

        [Required, Display(Name = "Marital Status")]
        public MaritalStatusOptions MaritalStatus { get; set; }

        [StringLength(16), Display(Name = "Contact Number")]
        public string ContactNumber { get; set; }

        [Required, StringLength(100), Display(Name = "E-mail Address")]
        public string EmailAddress { get; set; }

        [Required, DataType(DataType.DateTime), Display(Name = "Date of Birth")]
        [DisplayFormat(DataFormatString = "{0:yyyy/mm/dd}", ApplyFormatInEditMode = true)]
        public DateTime DateOfBirth { get; set; }

        public int AddressID { get; set; }

        public virtual Address Address { get; set; }

    }
}