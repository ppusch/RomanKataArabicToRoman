using NFluent;
using NUnit.Framework;

namespace RomanKataArabicToRoman
{
    public class RomanConverterShould
    {
        [Test]
        public void return_I_when_Arabic_Number_is_1()
        {
            var romanConverter = new RomanConverter();
            string romanSymbol = romanConverter.ArabicToRoman(1);
            Check.That(romanSymbol).IsEqualTo(1);
        }
    }

    public class RomanConverter
    {
        public string ArabicToRoman(int arabicValue)
        {
            throw new System.NotImplementedException();
        }
    }
}
