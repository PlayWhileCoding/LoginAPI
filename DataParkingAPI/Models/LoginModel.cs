using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DataParkingAPI.Models
{
    public class UserModel
    {
       
            [Required(ErrorMessage = "Username is required")]
            [StringLength(30, ErrorMessage = "Maximum Lenght: 15", MinimumLength = 8)]
            public string userName { get; set; }

            [Required(ErrorMessage = "Password is required")]
            [DataType(DataType.Password)]
            [StringLength(30, ErrorMessage = "Maximum Lenght: 12 ", MinimumLength = 8)]
            public string password { get; set; }
        }
   
}