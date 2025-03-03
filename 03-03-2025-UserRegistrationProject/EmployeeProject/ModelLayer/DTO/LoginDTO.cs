﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.DTO
{
    public class LoginDTO
    {
        public string email { get; set; } = "";
        public string password { get; set; }= "";

        override
            public string ToString()
        {
            return $"Email: {email} Password: {password}";
        }
    }
}
