using CurriculumVitaeExporter.Domain;
using CurriculumVitaeExporter.Infrastructure;
using Newtonsoft.Json;
using System;
using System.IO;

namespace CurriculumVitaeExporter.Implementations
{
    public sealed class JsonFileCurriculumProvider : ICurriculumProvider
    {
        private readonly CurriculumVitae _curriculumVitae;

        public JsonFileCurriculumProvider(string jsonFileFullPath)
        {
            if (string.IsNullOrWhiteSpace(jsonFileFullPath))
            {
                throw new ArgumentException("Curriculum file path cannot be empty", nameof(jsonFileFullPath));
            }

            var curriculumVitaeJson = File.ReadAllText(jsonFileFullPath);
            _curriculumVitae = JsonConvert.DeserializeObject<CurriculumVitae>(curriculumVitaeJson);
        }

        public CurriculumVitae Get()
            => _curriculumVitae;
    }
}
