using System.Collections.Generic;

namespace OldSwedishDictionary;

public readonly struct DictionaryEntry
{
    public string Headword { get; init; }
    public string PartOfSpeech { get; init; }
    public string GrammaticalAspect { get; init; }
    public List<string> Definitions { get; init; }
    public List<string> AlternativeForms { get; init; }

    public override string ToString() => $"{Headword} - {Definitions[0]}";

    public DictionaryEntry(string headword, string partOfSpeech, string grammaticalAspect, List<string> definitions, List<string> alternativeForms)
    {
        Headword = headword;
        PartOfSpeech = partOfSpeech;
        GrammaticalAspect = grammaticalAspect;
        Definitions = definitions;
        AlternativeForms = alternativeForms;
    }

}