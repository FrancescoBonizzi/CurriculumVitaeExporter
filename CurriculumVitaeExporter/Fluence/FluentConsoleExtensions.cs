using CurriculumVitaeExporter.Domain;
using System.Collections.Generic;
using System.Linq;

namespace CurriculumVitaeExporter.Fluence
{
    /// <summary>
    /// Some extensions to enrich FluentConsole while writing something about CurriculumVitae
    /// </summary>
    public static class FluentConsoleExtensions
    {
        /// <summary>
        /// It writes a list of experiences
        /// </summary>
        /// <param name="fluentConsole"></param>
        /// <param name="experiences"></param>
        /// <returns></returns>
        public static FluentConsole Write(
            this FluentConsole fluentConsole, 
            IEnumerable<Experience> experiences)
        {
            foreach (var workingExperience in experiences)
            {
                fluentConsole.Tab().Write($"· {workingExperience.Description}");

                if (workingExperience.From != null)
                {
                    fluentConsole.Write($" from {workingExperience.From.Value.Year}");
                    if (workingExperience.To != null)
                        fluentConsole.Write($" to {workingExperience.To.Value.Year}");
                }

                fluentConsole.NewLine();
            }

            return fluentConsole;
        }

        /// <summary>
        /// It writes a list of informations
        /// </summary>
        /// <param name="fluentConsole"></param>
        /// <param name="informations"></param>
        /// <returns></returns>
        public static FluentConsole Write(
            this FluentConsole fluentConsole, 
            IEnumerable<string> informations)
        {
            foreach (var information in informations)
            {
                fluentConsole
                    .Tab().Write($"· {information}")
                    .NewLine();
            }

            return fluentConsole;
        }

        /// <summary>
        /// It writes a list of links
        /// </summary>
        /// <param name="fluentConsole"></param>
        /// <param name="links"></param>
        /// <returns></returns>
        public static FluentConsole Write(
            this FluentConsole fluentConsole,
            IEnumerable<Link> links)
        {
            var whatToWrite = new List<string>();

            foreach (var link in links.OrderBy(l => l.Title))
            {
                var text = link.Title;

                if (link.ShowUrl)
                {
                    text = $"{text} \t{link.Url}";
                }

                whatToWrite.Add(text);
            }

            fluentConsole.Write(whatToWrite);
            return fluentConsole;
        }
    }
}
