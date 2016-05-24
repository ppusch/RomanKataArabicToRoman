using System.Text;
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
            Check.That(romanSymbol).IsEqualTo("I");
        }
        [Test]
        public void return_II_when_Arabic_Number_is_2()
        {
            var romanConverter = new RomanConverter();
            string romanSymbol = romanConverter.ArabicToRoman(2);
            Check.That(romanSymbol).IsEqualTo("II");
        }
     [Test]
        public void return_III_when_Arabic_Number_is_3()
        {
            var romanConverter = new RomanConverter();
            string romanSymbol = romanConverter.ArabicToRoman(3);
            Check.That(romanSymbol).IsEqualTo("III");
        }
    [Test]
        public void return_IV_when_Arabic_Number_is_4()
        {
            var romanConverter = new RomanConverter();
            string romanSymbol = romanConverter.ArabicToRoman(4);
            Check.That(romanSymbol).IsEqualTo("IV");
        }
     [Test]
        public void return_V_when_Arabic_Number_is_5()
        {
            var romanConverter = new RomanConverter();
            string romanSymbol = romanConverter.ArabicToRoman(5);
            Check.That(romanSymbol).IsEqualTo("V");
        }
  [Test]
        public void return_VI_when_Arabic_Number_is_6()
        {
            var romanConverter = new RomanConverter();
            string romanSymbol = romanConverter.ArabicToRoman(6);
            Check.That(romanSymbol).IsEqualTo("VI");
        }
    [Test]
        public void return_VII_when_Arabic_Number_is_7()
        {
            var romanConverter = new RomanConverter();
            string romanSymbol = romanConverter.ArabicToRoman(7);
            Check.That(romanSymbol).IsEqualTo("VII");
        }
       [Test]
        public void return_VIII_when_Arabic_Number_is_8()
        {
            var romanConverter = new RomanConverter();
            string romanSymbol = romanConverter.ArabicToRoman(8);
            Check.That(romanSymbol).IsEqualTo("VIII");
        }
    }

    public class RomanConverter
    {
        public string ArabicToRoman(int arabicValue)
        {
            var romanStringBuilder = new StringBuilder();
            if (arabicValue == 4) return "IV";
            while (arabicValue >= 5)
            {
                romanStringBuilder.Append("V");
                arabicValue= arabicValue -5;
            }
             while (arabicValue > 0)
            {
                romanStringBuilder.Append("I");
                arabicValue--;
            }
            return romanStringBuilder.ToString();

        }
    }
}
