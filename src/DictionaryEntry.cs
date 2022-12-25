using System.Collections.Generic;

using System.Text.Json.Serialization;

namespace OldSwedishDictionary;

public readonly struct DictionaryEntry
{
    [JsonPropertyName("a")]
    public string Headword { get; init; }
    [JsonPropertyName("b")]
    public List<string> PartOfSpeech { get; init; }
    [JsonPropertyName("c")]
    public string GrammaticalAspect { get; init; }
    [JsonPropertyName("d")]
    public string Information { get; init; }
    [JsonPropertyName("e")]
    public List<string> Definitions { get; init; }
    [JsonPropertyName("f")]
    public List<string> AlternativeForms { get; init; }

    public override string ToString() => $"{Headword} - {Definitions[0]}";

    public DictionaryEntry(string headword, List<string> partOfSpeech, string grammaticalAspect, string information, List<string> definitions, List<string> alternativeForms)
    {
        Headword = headword;
        PartOfSpeech = partOfSpeech;
        GrammaticalAspect = grammaticalAspect;
        Information = information;
        Definitions = definitions;
        AlternativeForms = alternativeForms;
    }

}