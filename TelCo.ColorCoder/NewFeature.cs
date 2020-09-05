using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace Telco.ColorCoder
{
    class NewFeature
    {
        public static string GetManual(int numberOfMajorColors, int numberOfMinorColors)
        {
            CultureInfo provider = new CultureInfo("en-us");
            int outerLoopCount = 0, innerLoopCount = 0, pairNumber = 1;
            string allPairs = "";
            for (outerLoopCount = 0; outerLoopCount < numberOfMajorColors; outerLoopCount++)
            {
                for (innerLoopCount = 0; innerLoopCount < numberOfMinorColors; innerLoopCount++)
                {
                    ColorCode.ColorPair colorPair = ColorMap.GetColorFromPairNumber(pairNumber);
                    string temp =pairNumber.ToString(provider)+ " - " + colorPair.ToString();
                    temp += "\n";
                    allPairs += temp;
                    pairNumber++;
                }
            }
            return allPairs;
        }
    }
}
