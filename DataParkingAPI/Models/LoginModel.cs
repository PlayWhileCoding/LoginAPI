﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DataParkingAPI.Models
{
    public class LoginModel
    {
       
            [Required(ErrorMessage = "Username is required")]
            [StringLength(30, ErrorMessage = "Maximum Lenght: 15", MinimumLength = 8)]
            public string UserName { get; set; }

            [Required(ErrorMessage = "Password is required")]
            [DataType(DataType.Password)]
            [StringLength(30, ErrorMessage = "Maximum Lenght: 12 ", MinimumLength = 8)]
            public string Password { get; set; }
        }
   
}