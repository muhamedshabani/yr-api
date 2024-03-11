using System;
using yr_api.Models.Enums;

namespace yr_api.Models.Entities
{
    public class Label : Base
    {
        public string Name { get; set; }
        public ELabelColor Color { get; set; }

        public ICollection<File> Files { get; set; } 
    }
}

