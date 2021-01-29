using CryptoProject.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CryptoProject.Domain.Services
{
    public interface IJwtService
    {
        string CreateToken(User user);
    }
}
