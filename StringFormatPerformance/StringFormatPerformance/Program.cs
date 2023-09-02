using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Diagnosers;
using BenchmarkDotNet.Diagnostics.Windows;
using BenchmarkDotNet.Running;
using System.Text.RegularExpressions;

namespace StringFormatPerformanceTest
{
    [Config(typeof(Config))]
    public class StringTests
    {
        private class Config : ManualConfig
        {
            public Config() => AddDiagnoser(MemoryDiagnoser.Default, new EtwProfiler());
        }

        static Dictionary<TextSearchType, string> TextSearch = new Dictionary<TextSearchType, string>()
        {
            { TextSearchType.replace1_1, "A"},
            { TextSearchType.replace1_2, "D"},
            { TextSearchType.replace1_3, "M"},
            { TextSearchType.replace1_4, "K"},
            { TextSearchType.replace1_n, "+"},
            { TextSearchType.replace2_1, "In"},
            { TextSearchType.replace2_2, "Et"},
            { TextSearchType.replace2_3, "Ut"},
            { TextSearchType.replace2_4, "El"},
            { TextSearchType.replace2_n, "yy"},
            { TextSearchType.replace3_1, "Sed"},
            { TextSearchType.replace3_2, "Ama"},
            { TextSearchType.replace3_3, "Nec"},
            { TextSearchType.replace3_4, "Lig"},
            { TextSearchType.replace3_n, "asd"},
            { TextSearchType.replace5_1, "Nulla"},
            { TextSearchType.replace5_2, "Ipsum"},
            { TextSearchType.replace5_3, "dolor"},
            { TextSearchType.replace5_4, "risus"},
            { TextSearchType.replace5_n, "usris"},
            { TextSearchType.replace8_1, "Consect"},
            { TextSearchType.replace8_2, "Egestas"},
            { TextSearchType.replace8_3, "Suspend"},
            { TextSearchType.replace8_4, "Posuere"},
            { TextSearchType.replace8_n, "Susu3re"},
            { TextSearchType.replace13_1, "Elementum od"},
            { TextSearchType.replace13_2, "Dictumst.Dui"},
            { TextSearchType.replace13_3, "Dui libero e"},
            { TextSearchType.replace13_4, "Aenean condi"},
            { TextSearchType.replace13_n, "Elementum co"},
            { TextSearchType.replace21_1, "Etiam bibendum a ex "},
            { TextSearchType.replace21_2, "Fringilla malesuada."},
            { TextSearchType.replace21_3, "Viverra bibendum.Pro"},
            { TextSearchType.replace21_4, "Viverra bibendum.Pro"},
            { TextSearchType.replace21_n, "non Fringilla male24"},
            { TextSearchType.replace34_1, "Ultricies nulla libero, nec ferme"},
            { TextSearchType.replace34_2, "Porta ligula eleifend.Vivamus nec"},
            { TextSearchType.replace34_3, "Integer vel luctus turpis.Nunc v"},
            { TextSearchType.replace34_4, "Quisque euismod metus id diam mat"},
            { TextSearchType.replace34_n, "Quisque Porta metus id Vivamus at"},
            { TextSearchType.replace55_1, "Integer vel luctus turpis. Nunc venenatis, justo id eu"},
            { TextSearchType.replace55_2, "Quisque euismod metus id diam mattis, eu feugiat sapie"},
            { TextSearchType.replace55_3, "Sed nec justo nec tortor malesuada tincidunt in nec pu"},
            { TextSearchType.replace55_4, "nec ligula consectetur luctus nec vel augue.Integer id"},
            { TextSearchType.replace55_n, "ligula consectetur luctus luctus luctus augue.Integer2"},
            { TextSearchType.replace_89_1, "Integer vel luctus turpis. Nunc venenatis, justo id euismod posuere, velit neque euismod"},
            { TextSearchType.replace_89_2, "Quisque euismod metus id diam mattis, eu feugiat sapien convallis. Donec rhoncus turpis "},
            { TextSearchType.replace_89_3, "Sed nec justo nec tortor malesuada tincidunt in nec purus. Curabitur congue augue in cur"},
            { TextSearchType.replace_89_4, "nec ligula consectetur luctus nec vel augue. Integer id mi in orci auctor bibendum.Fusce"},
            { TextSearchType.replace_89_n, "nec ligula tortor luctus neque vel augue. euismod id mi Nunc orci auctor bibendum.Fu2sce"},
        };

        static Dictionary<TextSizeType, string> Texts = new Dictionary<TextSizeType, string>();

        public enum TextSizeType
        {
            text10 = 10,
            text50 = 50,
            text100 = 100,
            text500 = 500,
            text1_000 = 1_000,
            text5_000 = 5_000,
            text10_000 = 10_000,
            text50_000 = 50_000,
            text100_000 = 100_000,
            text500_000 = 500_000,
        }

        public enum TextSearchType
        {
            replace1_1,
            replace1_2,
            replace1_3,
            replace1_4,
            replace1_n,
            replace2_1,
            replace2_2,
            replace2_3,
            replace2_4,
            replace2_n,
            replace3_1,
            replace3_2,
            replace3_3,
            replace3_4,
            replace3_n,
            replace5_1,
            replace5_2,
            replace5_3,
            replace5_4,
            replace5_n,
            replace8_1,
            replace8_2,
            replace8_3,
            replace8_4,
            replace8_n,
            replace13_1,
            replace13_2,
            replace13_3,
            replace13_4,
            replace13_n,
            replace21_1,
            replace21_2,
            replace21_3,
            replace21_4,
            replace21_n,
            replace34_1,
            replace34_2,
            replace34_3,
            replace34_4,
            replace34_n,
            replace55_1,
            replace55_2,
            replace55_3,
            replace55_4,
            replace55_n,
            replace_89_1,
            replace_89_2,
            replace_89_3,
            replace_89_4,
            replace_89_n,
        }

        static StringTests()
        {
            string filePath = @"text.txt";
            string value = File.ReadAllText(filePath);

            foreach (TextSizeType size in Enum.GetValues(typeof(TextSizeType)))
            {
                Texts.Add(size, value.Substring(0, (int)size));
            }
        }


        [Params(TextSearchType.replace1_1, TextSearchType.replace1_2, TextSearchType.replace1_3, TextSearchType.replace1_4, TextSearchType.replace1_n, TextSearchType.replace2_1, TextSearchType.replace2_2, TextSearchType.replace2_3, TextSearchType.replace2_4, TextSearchType.replace2_n, TextSearchType.replace3_1, TextSearchType.replace3_2, TextSearchType.replace3_3, TextSearchType.replace3_4, TextSearchType.replace3_n, TextSearchType.replace5_1, TextSearchType.replace5_2, TextSearchType.replace5_3, TextSearchType.replace5_4, TextSearchType.replace5_n, TextSearchType.replace8_1, TextSearchType.replace8_2, TextSearchType.replace8_3, TextSearchType.replace8_4, TextSearchType.replace8_n, TextSearchType.replace13_1, TextSearchType.replace13_2, TextSearchType.replace13_3, TextSearchType.replace13_4, TextSearchType.replace13_n, TextSearchType.replace21_1, TextSearchType.replace21_2, TextSearchType.replace21_3, TextSearchType.replace21_4, TextSearchType.replace21_n, TextSearchType.replace34_1, TextSearchType.replace34_2, TextSearchType.replace34_3, TextSearchType.replace34_4, TextSearchType.replace34_n, TextSearchType.replace55_1, TextSearchType.replace55_2, TextSearchType.replace55_3, TextSearchType.replace55_4, TextSearchType.replace55_n, TextSearchType.replace_89_1, TextSearchType.replace_89_2, TextSearchType.replace_89_3, TextSearchType.replace_89_4, TextSearchType.replace_89_n)]
        public TextSearchType SearchTextSearch;

        [Params(TextSearchType.replace1_1, TextSearchType.replace1_2, TextSearchType.replace1_3, TextSearchType.replace1_4, TextSearchType.replace1_n, TextSearchType.replace2_1, TextSearchType.replace2_2, TextSearchType.replace2_3, TextSearchType.replace2_4, TextSearchType.replace2_n, TextSearchType.replace3_1, TextSearchType.replace3_2, TextSearchType.replace3_3, TextSearchType.replace3_4, TextSearchType.replace3_n, TextSearchType.replace5_1, TextSearchType.replace5_2, TextSearchType.replace5_3, TextSearchType.replace5_4, TextSearchType.replace5_n, TextSearchType.replace8_1, TextSearchType.replace8_2, TextSearchType.replace8_3, TextSearchType.replace8_4, TextSearchType.replace8_n, TextSearchType.replace13_1, TextSearchType.replace13_2, TextSearchType.replace13_3, TextSearchType.replace13_4, TextSearchType.replace13_n, TextSearchType.replace21_1, TextSearchType.replace21_2, TextSearchType.replace21_3, TextSearchType.replace21_4, TextSearchType.replace21_n, TextSearchType.replace34_1, TextSearchType.replace34_2, TextSearchType.replace34_3, TextSearchType.replace34_4, TextSearchType.replace34_n, TextSearchType.replace55_1, TextSearchType.replace55_2, TextSearchType.replace55_3, TextSearchType.replace55_4, TextSearchType.replace55_n, TextSearchType.replace_89_1, TextSearchType.replace_89_2, TextSearchType.replace_89_3, TextSearchType.replace_89_4, TextSearchType.replace_89_n)]
        public TextSearchType ReplaceTextSearch;

        [Params(TextSizeType.text10, TextSizeType.text50, TextSizeType.text100, TextSizeType.text500, TextSizeType.text1_000, TextSizeType.text5_000, TextSizeType.text10_000, TextSizeType.text50_000, TextSizeType.text100_000, TextSizeType.text500_000)]
        public TextSizeType TextSize;


        private string Text;
        private string SearchText;
        private string ReplaceText;

        [GlobalSetup]
        public void Setup()
        {
            Text = Texts[TextSize];
            ReplaceText = TextSearch[ReplaceTextSearch];
            SearchText = TextSearch[SearchTextSearch];
        }

        [Benchmark]
        public void StringReplace()
        {
            var value = Text.Replace(SearchText, ReplaceText);
        }

        [Benchmark]
        public void RegexrReplace()
        {
            var result = Regex.Replace(Text, SearchText, ReplaceText);
        }

        class Program
        {
            static void Main(string[] args)
            {
                var summary = BenchmarkRunner.Run<StringTests>();
            }
        }
    }
}