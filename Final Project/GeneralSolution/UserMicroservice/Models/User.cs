using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserMicroservice.Models
{
    public class User
    {
        public int Id { get; set; }
        public string NickName { get; set; }
        public string RealName { get; set; }
    }
}
