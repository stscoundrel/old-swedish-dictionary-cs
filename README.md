# Old Swedish Dictionary

Old Swedish Dictionary for C# / .NET. The dictionary consists of 40 000+ Old Swedish words with Swedish translations.

Based on K.F. Söderwall's Medieval Swedish Dictionary

### Install

```
dotnet add package OldSwedishDictionary
```

### Usage


```csharp
using OldSwedishDictionary;

// Get all dictionary entries.
var dictionary = new Dictionary();
var result = dictionary.GetEntries();
Console.WriteLine(dictionar.Count); // 41 744 entries.

// Individual entry contains headword, part of speech, grammatical aspect, definitions and possibly alternative forms.
DictionaryEntry entry = result[100];
Console.WriteLine(entry.Headword); // af bränna
Console.WriteLine(entry.PartOfSpeech); // vb
Console.WriteLine(entry.GrammaticalAspect); // v
Console.WriteLine(entry.Information); // empty string in this case, some entries contain additional information.
Console.WriteLine(entry.Definition); // afbränna, genom eld förstöra. hans trähws the af brendhe [...] etc.

// ToString is overwritten for generic presentation.
Console.WriteLine(entry.ToString()); // [HEADWORD] - [FIRST DEFINITION]

```

### About "Dictionary of Old Swedish"

_"Ordbok Öfver svenska medeltids-språket"_ dictionary was published in late 1884—1918 by K.F. Söderwall. Additional supplement to it was published in 1953—1973.

Old Swedish developed from Old East Norse, the eastern dialect of Old Norse, at the end of the Viking Age. Early Old Swedish was spoken from about 1225 until about 1375, and Late Old Swedish was spoken from about 1375 until about 1526.

The original material is licenced under [Creative Commons International (CC BY 4.0)](https://creativecommons.org/licenses/by/4.0/), made available by University of Gothenburg. The source code for this library is under MIT licence.

- https://spraakbanken.gu.se/en/resources/soederwall
- https://spraakbanken.gu.se/en/resources/soederwall-supp

