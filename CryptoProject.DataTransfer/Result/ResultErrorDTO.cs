using System;
using System.Collections.Generic;
using System.Text;

namespace CryptoProject.DataTransfer.Result
{
    public class ResultErrorDTO : ResultDTO
    {
        public List<string> Errors { get; set; }
    }
}
