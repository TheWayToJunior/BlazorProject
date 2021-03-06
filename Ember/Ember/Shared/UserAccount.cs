﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Ember.Shared
{
    public class UserAccount
    {
        [Key, Column(Order = 0)]
        public string UserId { get; set; }

        [Key, Column(Order = 1)]
        public string  AccountId { get; set; }

        public virtual IdentityUser User { get; set; }

        public virtual Account Account { get; set; }
    }
}
