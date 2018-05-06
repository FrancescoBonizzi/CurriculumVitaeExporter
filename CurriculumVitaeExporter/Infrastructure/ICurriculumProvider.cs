using CurriculumVitaeExporter.Domain;

namespace CurriculumVitaeExporter.Infrastructure
{
    /// An abstraction to import a <see cref="CurriculumVitae"/>
    public interface ICurriculumProvider
    {
        CurriculumVitae Get();
    }
}
