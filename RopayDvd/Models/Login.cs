using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RopayDvd.Models
{
    public class Login
    {
        [Required(ErrorMessage ="Login Id is incorrect.")]
        public string LoginId { get; set; }
        [Required(ErrorMessage ="Password is not supposed to be empty.")]
        [DataType(DataType.Password)]
        public string LoginCode { get; set; }
    }
}
