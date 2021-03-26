using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NotesMarketplace.Models
{
    public class AddSystemConfiguration
    {
        public string ID { get; set; }

        [Required(ErrorMessage = "Please Enter Support Email Address")]
        [EmailAddress(ErrorMessage ="Invelid Email ID")]
        public string SupportEmailAddress { get; set; }

        [Required(ErrorMessage = "Please Enter Password")]
        public string EmailPassword { get; set; }

        [Required(ErrorMessage = "Please Enter Support Phone Number")]
        public string SupportPhoneNumber { get; set; }

        [Required(ErrorMessage = "Please Enter Email Address")]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "Please Enter Facebook URL")]
        public string FacebookURL { get; set; }

        [Required(ErrorMessage = "Please Enter Twitter URL")]
        public string TwitterURL { get; set; }

        [Required(ErrorMessage = "Please Enter Linkedin URL")]
        public string LinkedinURL { get; set; }

        [Required(ErrorMessage = "Please Select Default Image For Notes")]
        public HttpPostedFileBase DefaultImageForNotes { get; set; }

        [Required(ErrorMessage = "Please Select Defaul Profile Picture")]
        public HttpPostedFileBase DefaultProfilePicture { get; set; }
    }
}