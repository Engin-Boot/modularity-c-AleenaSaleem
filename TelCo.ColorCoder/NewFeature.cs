using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace Telco.ColorCoder
{
    class ColorMapManual
    {
        public static string getFormattedLine(int pairNumber, string color_pair)
        {
            CultureInfo provider = new CultureInfo("en-us");
            string temp = pairNumber.ToString(provider) + " - " + color_pair + "\n"; 
            return temp;
        }
        public static string GetManual(int numberOfMajorColors, int numberOfMinorColors)
        {
            int outerLoopCount = 0, innerLoopCount = 0, pairNumber = 1;
            string allPairs = "";
            for (outerLoopCount = 0; outerLoopCount < numberOfMajorColors; outerLoopCount++)
            {
                for (innerLoopCount = 0; innerLoopCount < numberOfMinorColors; innerLoopCount++)
                {
                    ColorCode.ColorPair colorPair = ColorMap.GetColorFromPairNumber(pairNumber);
                    allPairs += getFormattedLine(pairNumber, colorPair.ToString());
                    pairNumber++;
                }
            }
            return allPairs;
        }
        public static string FakeGetManual(int numberOfMajorColors, int numberOfMinorColors)
        {
            int outerLoopCount = 0, innerLoopCount = 0, pairNumber = 1;
            string allPairs = "";
            for (outerLoopCount = 0; outerLoopCount < numberOfMajorColors; outerLoopCount++)
            {
                for (innerLoopCount = 0; innerLoopCount < numberOfMinorColors; innerLoopCount++)
                {
                    string color_pair = numberOfMajorColors.ToString();
                    color_pair += numberOfMinorColors.ToString();
                    allPairs += color_pair;
                    pairNumber++;
                }
            }
            return allPairs;
        }

    }
}
