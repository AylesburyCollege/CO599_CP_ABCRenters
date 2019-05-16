using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CO599_CP_ABCRenters.Models
{

    public enum ImageFormats

    {

        img,

        jpg,

        png

    }
    public enum ImageRooms

    {

        [Display(Name = "Outside")]

        OUTSIDE,

        [Display(Name = "Living Area")]

        LIVING_AREA,

        [Display(Name = "Kitchen")]

        KITCHEN,

        [Display(Name = "Main Bedroom")]

        MAIN_BEDROOM,

        [Display(Name = "Bathroom")]

        BATHROOM,

        [Display(Name = "Garden")]

        GARDEN,

        [Display(Name = "Guest Bedroom")]

        GUEST_BEDROOM

    }
    public class PropertyImage
    {

        public int PropertyImageID { get; set; }

        [Required, StringLength(255), DataType(DataType.ImageUrl)]
        public string ImageURL { get; set; }

        [Required, StringLength(255)]
        public string Description { get; set; }

        [Required, StringLength(50)]
        public string Caption { get; set; }

        public ImageFormats ImageFormat { get; set; }

        public ImageRooms Position { get; set; }

        // FK

        public int PropertyID { get; set; }
        public virtual Property Property { get; set; }
    }
}