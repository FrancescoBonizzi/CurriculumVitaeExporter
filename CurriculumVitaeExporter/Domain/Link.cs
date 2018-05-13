using System;

namespace CurriculumVitaeExporter.Domain
{
    /// <summary>
    /// A link to something useful in you Curriculum Vitae
    /// </summary>
    public class Link
    {
        /// <summary>
        /// The link title
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// The link url
        /// </summary>
        public Uri Url { get; set; }
    }
}
