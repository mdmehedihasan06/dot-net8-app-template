﻿using App.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Entities.Authentication
{
    public class AppUser : BaseEntity
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
