using CurriculumVitaeExporter.Domain;

namespace CurriculumVitaeExporter.Infrastructure
{
    public interface ICurriculumProvider
    {
        CurriculumVitae Get();
    }
}
