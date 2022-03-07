using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Models
{
    public class EmailSettings
    {
        public string ApiKey { get; set; }
        public string? Address { get; set; }
        public string? FromName { get; set; }
    }
}
