# CurriculumVitaeExporter

[![Build status](https://flowsoftproject.visualstudio.com/GithubOpenSource/_apis/build/status/CurriculumVitaeExporter)](https://flowsoftproject.visualstudio.com/GithubOpenSource/_build/latest?definitionId=22)

Just a library that defines a **Curriculum Vitae domain** and some abstractions to export it to any format...

...mine is exported as a `Console Application` with a fluent syntax!

# My Curriculum Vitae
![Francesco Bonizzi Curriculum Vitae](FrancescoBonizziConsoleCurriculum/PublishedFiles/FrancescoBonizzi-CurriculumVitae-GitHubCut.jpg)
[Pdf A4 printable version](FrancescoBonizziConsoleCurriculum/PublishedFiles/FrancescoBonizzi-CurriculumVitae.pdf)

[Json version](FrancescoBonizziConsoleCurriculum/FrancescoBonizzi-CV.json)

# Getting started
With the `CurriculumVitaeExporter` library, you have two abstractions to implement:

1. `ICurriculumProvider`: a service that loads a `Domain.CurricullumVitae`
2. `ICurriculumExporter`: a service that, given a `Domain.CurricullumVitae`, outputs it in a specific format.

In the ConsoleApplication project, `FrancescoBonizziConsoleCurriculum`, I used two basic implementations:

```c#
ICurriculumProvider curriculumProvider = new JsonFileCurriculumProvider("FrancescoBonizzi-CV.json");
ICurriculumExporter curriculumExporter = new ConsoleCurriculumExporter();

var curriculumVitae = curriculumProvider.Get();
curriculumExporter.Export(curriculumVitae);
```

One that loads a `CurriculumVitae` from a `Json` file, and one that outputs it to the `Console` in a stilish format. As I currently love the fluent syntax, I wrapped the `System.Console` static instance into a `FluentConsole` to do something like this:

```c#
_fluentConsole

    .Title($"{curriculumVitae.FullName} - Curriculum Vitae")

    .NewLine()
    .NewLine()
    .NewLine().Tab().Write(curriculumVitae.FullName, _titleColor)
    .NewLine().Tab().Write(curriculumVitae.Headline)
    .NewLine().Tab().Write(curriculumVitae.CurrentPosition)
```

...which in my opinion is very elegant to see.

# Building
Simply clone this repository and build the `CurriculumVitaeExporter.sln` solution.

# How to contribute
- Report any issues
- Propose new features / improvements, like implementing new `ICurriculumExporter` in other formats (`PDF`, `HTML`, `MD`...)
- Just telling your opinion :-)
