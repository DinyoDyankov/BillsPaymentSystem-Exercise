﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BillsPaymentSystem.Models
{
    public class User
    {
        public User()
        {
            this.PaymentMethods = new HashSet<PaymentMethod>();
        }

        public int UserId { get; set; }

        [Required]
        [MinLength(3), MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [MinLength(3), MaxLength(50)]
        public string LastName { get; set; }

        [Required]
        [RegularExpression("^\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*$")]
        public string Email { get; set; }

        [Required]
        [MinLength(6), MaxLength(25)]
        public string Password { get; set; }

        public ICollection<PaymentMethod> PaymentMethods { get; set; }
    }
}
