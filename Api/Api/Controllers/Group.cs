using System;
using System.Collections.Generic;

namespace Api.Controllers
{
    public class Group
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public IEnumerable<User> Users { get; set; }
    }
}
