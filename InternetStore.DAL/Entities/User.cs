﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internet_store.DAL.Entities
{
    public class User
    {
        [Required]
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }

        public int HashPassword { get; set; }

        public string PhoneNumber { get; set; }

        public string ZipCode { get; set; }

        [Required]
        public string IP { get; set; }

        [Required]
        public int RoleId { get; set; }
        public Role Role { get; set; }

        public virtual List<Order> Orders { get; set; }
    }
}
