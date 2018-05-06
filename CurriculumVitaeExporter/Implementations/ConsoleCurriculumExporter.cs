using CurriculumVitaeExporter.Domain;
using CurriculumVitaeExporter.Fluence;
using CurriculumVitaeExporter.Infrastructure;
using System;
using System.Globalization;
using System.Text;

// TODO:
// fai una libreria con questo
// mettici di fianco app a console per usarla col mio curriculum

namespace CurriculumVitaeExporter.Implementations
{
    public sealed class ConsoleCurriculumExporter : ICurriculumExporter
    {
        private readonly ConsoleColor _titleColor = ConsoleColor.Blue;
        private readonly FluentConsole _fluentConsole;

        public ConsoleCurriculumExporter()
        {
            _fluentConsole = new FluentConsole()
                .Encoding(Encoding.UTF8)
                .TextColor(ConsoleColor.Black)
                .BackgroundColor(ConsoleColor.White)
                .Size(110, 44);
        }

        public void Export(CurriculumVitae curriculumVitae)
        {
            if (curriculumVitae == null)
                throw new ArgumentNullException(nameof(curriculumVitae));

            _fluentConsole

                .Title($"{curriculumVitae.FullName} - Curriculum Vitae")

                .NewLine()
                .NewLine()
                .NewLine().Tab().Write(curriculumVitae.FullName, _titleColor)
                .NewLine().Tab().Write(curriculumVitae.Headline)
                .NewLine().Tab().Write(curriculumVitae.CurrentPosition)

                .NewLine().Tab().HorizontalLine(40)

                .NewLine().Tab().Write(curriculumVitae.Address)
                .NewLine().Tab().Write(curriculumVitae.Email)
                .NewLine().Tab().Write(curriculumVitae.BirthDate.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture))
                .NewLine()
                .NewLine()

                .NewLine().Tab().Write("Experience", _titleColor)
                .NewLine().Write(curriculumVitae.Experiences)

                .NewLine().Tab().Write("Education", _titleColor)
                .NewLine().Write(curriculumVitae.Education)

                .NewLine().Tab().Write("Skills", _titleColor)
                .NewLine().Write(curriculumVitae.Skills)

                .NewLine().Tab().Write("Projects", _titleColor)
                .NewLine().Write(curriculumVitae.Projects)

                .NewLine().Tab().Write("Hobbies", _titleColor)
                .NewLine().Write(curriculumVitae.Hobbies)

                .NewLine().Tab().Write("Links", _titleColor)
                .NewLine().Write(curriculumVitae.Links)

                .NewLine();
        }
    }
}
