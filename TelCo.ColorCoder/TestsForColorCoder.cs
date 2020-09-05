using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telco.ColorCoder
{
    class TestsForColorCoder
    {
        static void Main(string[] args)
        {
            int minorSize = ColorCode.colorMapMajor.Length;
            int majorSize = ColorCode.colorMapMajor.Length;
            int pairNumber = 4;
            ColorCode.ColorPair testPair1 = ColorMap.GetColorFromPairNumber(pairNumber);
            Console.WriteLine("[In]Pair Number: {0},[Out] Colors: {1}\n", pairNumber, testPair1);
            Debug.Assert(testPair1.majorColor == Color.White);
            Debug.Assert(testPair1.minorColor == Color.Brown);

            pairNumber = 5;
            testPair1 = ColorMap.GetColorFromPairNumber(pairNumber);
            Console.WriteLine("[In]Pair Number: {0},[Out] Colors: {1}\n", pairNumber, testPair1);
            Debug.Assert(testPair1.majorColor == Color.White);
            Debug.Assert(testPair1.minorColor == Color.SlateGray);

            pairNumber = 23;
            testPair1 = ColorMap.GetColorFromPairNumber(pairNumber);
            Console.WriteLine("[In]Pair Number: {0},[Out] Colors: {1}\n", pairNumber, testPair1);
            Debug.Assert(testPair1.majorColor == Color.Violet);
            Debug.Assert(testPair1.minorColor == Color.Green);

            ColorCode.ColorPair testPair2 = new ColorCode.ColorPair() { majorColor = Color.Yellow, minorColor = Color.Green };
            pairNumber = ColorMap.GetPairNumberFromColor(testPair2);
            Console.WriteLine("[In]Colors: {0}, [Out] PairNumber: {1}\n", testPair2, pairNumber);
            Debug.Assert(pairNumber == 18);

            testPair2 = new ColorCode.ColorPair() { majorColor = Color.Red, minorColor = Color.Blue };
            pairNumber = ColorMap.GetPairNumberFromColor(testPair2);
            Console.WriteLine("[In]Colors: {0}, [Out] PairNumber: {1}", testPair2, pairNumber);
            Debug.Assert(pairNumber == 6);
            string Manual = NewFeature.GetManual(majorSize, minorSize);
            Console.WriteLine(Manual);
        }
    }
}
