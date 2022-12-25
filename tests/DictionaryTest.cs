using Xunit;
using System;
using OldSwedishDictionary;

using System.Collections.Generic;

namespace OldSwedishDictionaryTest;

public class DictionaryTest
{
    [Fact]
    public void DictionaryHasCorrectAmountOfEntriesTest()
    {
        var dictionary = new Dictionary();
        var result = dictionary.GetEntries();

        Assert.Equal(41744, result.Count);
    }

    [Fact]
    public void DictionaryHasExpectedContentTest()
    {
        var dictionary = new Dictionary();
        var result = dictionary.GetEntries();

        Assert.Equal("af bränna", result[100].Headword);
        Assert.Equal(new List<string> { "vb" }, result[100].PartOfSpeech);
        Assert.Equal("v.", result[100].GrammaticalAspect);
        Assert.Equal("", result[100].Information);
        Assert.Equal("afbränna, genom eld förstöra. hans trähws the af brendhe  RK 2: 2757 . ib 1511. halff stadhen är affbrändh  BSH 5: 132 (  1506) . Jfr bränna af.", result[100].Definitions[0]);
        Assert.Equal(new List<string>(), result[100].AlternativeForms);

        Assert.Equal("annat thera", result[1000].Headword);
        Assert.Equal(new List<string> { "kn" }, result[1000].PartOfSpeech);
        Assert.Equal("konj.", result[1000].GrammaticalAspect);
        Assert.Equal("", result[1000].Information);
        Assert.Equal(" (eg. n. af annar i förening med gen. pl. af pron. thän) antingen. annat thera . . . älla, antingen . . . eller. annat thera skal jach felle thegh dödhan eller tu mik  Di 218 .  \" maa han i noghraa mattho wara annath thera gwdh eller man Lg 3: 108. \"", result[1000].Definitions[0]);
        Assert.Equal(new List<string>(), result[1000].AlternativeForms);

        Assert.Equal("löna", result[20000].Headword);
        Assert.Equal(new List<string> { "vb" }, result[20000].PartOfSpeech);
        Assert.Equal("v.", result[20000].GrammaticalAspect);
        Assert.Equal("", result[20000].Information);
        Assert.Equal("löna, vedergälla. \" med personens dat. och ack. betecknande det för hvilket lön gifves. minom och ack. betecknande det för hvilket lön gifves. minom winom lönir iak lydhno oc älskogha mz miskund \" MB 1: 332 . hånom hans gif löna  KS 70 (112, 77) . gudh löne henne sin stora kärlek  Lg 807 .  KL 296 . han honom thz ille lönte  RK 2: 3459 . - pass. thz kan thöm aldrigh vardha lönt  Iv 4959 . - med personens dat. och ack. betecknande det som gifves ss lön. honum löna synda giäl  Al 2329 . - med personens dat. them löne  RK 2: 3216 .  \" löna wäl jlum \" Bil 104 .  \" iak lönir hwariom enom äptir sinne forskullan \" Bir 1: 381 .  MB 2: 369 .  \" om honum skwlde saa wordhe lönth for hans langlige . . . trotieniste \" BSH 4: 220 ( 1497) . - löna, aflöna. them som ey löna sino ärfuodhis folke rättelica  MP 2: 111 .  \" löne . . . af thy sama sinom piltom oc tiänarom \" Bir 5: 115 .  ib 116 .  \" sinom soldenärom skulu the ey vara pliktoghe antiggia harnisk. kost äller fordenskap til land ällir watn. ey oc gull äller päninga til them at löna \" MB 2: 242 .  ib 243 . - betala. badh löna sik  Bo 14 . - belöna. war gudh ther badhe lönar wälgerninga ok plicta synde  Bil 458 . ", result[20000].Definitions[0]);
        Assert.Equal(new List<string>{
            "lönar Bil 458 . ",
            "lönir MB 1: 332,  Bir 1: 381 . ",
            "löne: atir löne  ib 40 ; ",
            "atirlöne ib 2: 89 . ",
            "lönther: lönth BSH 4: 220 ( 1497)),",
            "löna i gen , ",
        }, result[20000].AlternativeForms);
    }
}