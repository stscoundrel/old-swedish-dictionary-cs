using System.Collections.Generic;

using System.Text.Json.Serialization;

namespace OldSwedishDictionary;

public readonly struct DictionaryEntry
{
    [JsonPropertyName("a")]
    public string Headword { get; init; }
    [JsonPropertyName("b")]
    public string PartOfSpeech { get; init; }
    [JsonPropertyName("c")]
    public string GrammaticalAspect { get; init; }
    [JsonPropertyName("d")]
    public List<string> Definitions { get; init; }
    [JsonPropertyName("e")]
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