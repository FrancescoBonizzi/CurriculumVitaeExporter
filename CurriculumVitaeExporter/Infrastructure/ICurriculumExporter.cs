using CurriculumVitaeExporter.Domain;

namespace CurriculumVitaeExporter.Infrastructure
{
    public interface ICurriculumExporter
    {
        void Export(CurriculumVitae curriculumVitae);
    }
}
