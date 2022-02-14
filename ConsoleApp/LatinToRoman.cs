namespace ConsoleApp
{
    public class LatinToRoman
    {
        public string LatinToRomanConverter(int number)
        {
            if ((number < 0) || (number > 3999)) throw new ArgumentOutOfRangeException("Insert value between 1 and 3999");
            if (number < 1) return string.Empty;
            if (number >= 1000) return "M" + LatinToRomanConverter(number - 1000);
            if (number >= 900) return "CM" + LatinToRomanConverter(number - 900);
            if (number >= 500) return "D" + LatinToRomanConverter(number - 500);
            if (number >= 400) return "CD" + LatinToRomanConverter(number - 400);
            if (number >= 100) return "C" + LatinToRomanConverter(number - 100);
            if (number >= 90) return "XC" + LatinToRomanConverter(number - 90);
            if (number >= 50) return "L" + LatinToRomanConverter(number - 50);
            if (number >= 40) return "XL" + LatinToRomanConverter(number - 40);
            if (number >= 10) return "X" + LatinToRomanConverter(number - 10);
            if (number >= 9) return "IX" + LatinToRomanConverter(number - 9);
            if (number >= 5) return "V" + LatinToRomanConverter(number - 5);
            if (number >= 4) return "IV" + LatinToRomanConverter(number - 4);
            if (number >= 1) return "I" + LatinToRomanConverter(number - 1);
            throw new ArgumentOutOfRangeException("Something bad happened");
        }
    }
}