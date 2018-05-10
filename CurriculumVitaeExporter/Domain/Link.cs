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
        public string Url { get; set; }

        /// <summary>
        /// If in the curriculum page you want to show this url
        /// </summary>
        public bool ShowUrl { get; set; } = true;
    }
}
