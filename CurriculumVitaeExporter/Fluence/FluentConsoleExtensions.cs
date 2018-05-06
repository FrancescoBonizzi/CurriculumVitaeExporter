using CurriculumVitaeExporter.Domain;
using System.Collections.Generic;
using System.Linq;

namespace CurriculumVitaeExporter.Fluence
{
    public static class FluentConsoleExtensions
    {
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

        public static FluentConsole Write(
            this FluentConsole fluentConsole,
            IEnumerable<Link> links)
        {
            return fluentConsole.Write(
                links
                .OrderBy(l => l.Title)
                .Select(l => $"{l.Title}: \t{l.Url}"));
        }
    }
}
