using CurriculumVitaeExporter.Domain;

namespace CurriculumVitaeExporter.Infrastructure
{
    /// <summary>
    /// An abstraction to export a <see cref="CurriculumVitae"/>
    /// </summary>
    public interface ICurriculumExporter
    {
        void Export(CurriculumVitae curriculumVitae);
    }
}
