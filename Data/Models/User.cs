﻿using System;

namespace OnlineRetailersStore.Data.Models
{
    public class User
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool Retailer { get; set; }
    }
}
