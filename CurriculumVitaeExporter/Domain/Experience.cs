using System;

namespace CurriculumVitaeExporter.Domain
{
    public class Experience
    {
        public string Description { get; set; }
        public DateTime? From { get; set; }
        public DateTime? To { get; set; }
    }
}
