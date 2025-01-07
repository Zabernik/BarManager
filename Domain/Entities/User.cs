﻿using Domain.Enums;

namespace Domain.Entities
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public Role Role { get; set; }
    }
}
