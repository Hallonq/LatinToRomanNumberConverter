namespace ConsoleApp
{
    public class Converters
    {
        public int LocalLatin { get; set; }
        public string LocalRoman { get; set; }

        public Converters()
        {
        }

        public Converters(int v)
        {
            LocalLatin = v;
        }

        public string ConvertLatinNumberToRoman()
        {
            LatinToRoman converter = new LatinToRoman();
            LocalRoman = converter.LatinToRomanConverter(LocalLatin);

            return LocalRoman;
        }
    }
}