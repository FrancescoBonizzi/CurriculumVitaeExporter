using CurriculumVitaeExporter.Domain;
using CurriculumVitaeExporter.Infrastructure;
using Newtonsoft.Json;
using System;
using System.IO;

namespace CurriculumVitaeExporter.Implementations
{
    /// <summary>
    /// An implementation of <see cref="ICurriculumProvider"/> that loads a <see cref="CurriculumVitae"/> from a json file
    /// according to its domain definition
    /// </summary>
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
