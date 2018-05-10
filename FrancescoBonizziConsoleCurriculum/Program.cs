using CurriculumVitaeExporter.Implementations;
using CurriculumVitaeExporter.Infrastructure;
using System;

namespace FrancescoBonizziConsoleCurriculum
{
    class Program
    {
        static void Main(string[] args)
        {
            ICurriculumProvider curriculumProvider;
            ICurriculumExporter curriculumExporter;

            try
            {
                curriculumProvider = new JsonFileCurriculumProvider("FrancescoBonizzi-CV.json");
                curriculumExporter = new ConsoleCurriculumExporter();

                var curriculumVitae = curriculumProvider.Get();
                curriculumExporter.Export(curriculumVitae);

                Console.Read();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Ooops! {ex.Message}");

                Console.Read();
            }
        }
    }
}
