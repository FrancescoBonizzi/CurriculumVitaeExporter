using System;
using System.Collections.Generic;

namespace CurriculumVitaeExporter.Domain
{
    public class CurriculumVitae
    {
        public string FullName { get; set; }
        public string Headline { get; set; }
        public string CurrentPosition { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public IEnumerable<string> Skills { get; set; }
        public IEnumerable<string> Hobbies { get; set; }
        
        public IEnumerable<Experience> Experiences { get; set; }
        public IEnumerable<Experience> Education { get; set; }
        public IEnumerable<Experience> Projects { get; set; }

        public IEnumerable<Link> Links { get; set; }
    }
}
