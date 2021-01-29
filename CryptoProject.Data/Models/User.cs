using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CryptoProject.Data.Models
{
    public class User : IdentityUser
    {
        public virtual UserAdditionalInfo UserAdditionalInfo { get; set; }
    }
}
