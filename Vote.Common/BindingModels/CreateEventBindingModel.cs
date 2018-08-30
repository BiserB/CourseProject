﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Vote.Common.Attributes;

namespace Vote.Common.BindingModels
{
    public class CreateEventBindingModel 
    {

        [Required]
        [StringLength(64, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 3)]
        public string Code { get; set; }

        [Required]
        [StringLength(256, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 3)]
        public string Title { get; set; }

        [Required]
        [Display(Name = "Start date")]
        public DateTime StartDate { get; set; }

        [Required]
        [Display(Name = "End date")]
        [DateAfter("StartDate")]
        public DateTime EndDate { get; set; }
        
        public bool AnonymousAllowed { get; set; }
    }
}
