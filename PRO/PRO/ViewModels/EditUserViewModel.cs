﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using PRO.Entities;


namespace PRO.UI.ViewModels
{
    public class EditUserViewModel
    {
       public ApplicationUser AppUser { get; set; }

        public List<Image> Images { get; set; }
    }
}