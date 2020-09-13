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
        public static void TestExpectingColorPairwhenCalledWithAValidpairNumber
            (int pairNumber,Color ExpectedMajor,Color ExpectedMinor) {
            ColorCode.ColorPair testPair1 = ColorMap.GetColorFromPairNumber(pairNumber);
            Console.WriteLine("[In]Pair Number: {0},[Out] Colors: {1}\n", pairNumber, testPair1);
            Debug.Assert(testPair1.majorColor == ExpectedMajor);
            Debug.Assert(testPair1.minorColor == ExpectedMinor);
        }

        public static void TestExpectingPairNumberwhenCalledWithAValidColorPair(Color Major,Color Minor,int ExpectedPairNumber) 
        {
            int pairNumber;
            ColorCode.ColorPair testPair = new ColorCode.ColorPair() { majorColor = Major, minorColor = Minor };
            pairNumber = ColorMap.GetPairNumberFromColor(testPair);
            Console.WriteLine("[In]Colors: {0}, [Out] PairNumber: {1}\n", testPair, pairNumber);
            Debug.Assert(pairNumber == ExpectedPairNumber);

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
                    //ColorCode.ColorPair colorPair = ColorMap.GetColorFromPairNumber(pairNumber);
                    allPairs += color_pair;
                    pairNumber++;
                }
            }
            return allPairs;
        }
        static void Main(string[] args)
        {
            int minorSize = ColorCode.colorMapMajor.Length;
            int majorSize = ColorCode.colorMapMajor.Length;
            int pairNumber = 4;
            TestExpectingColorPairwhenCalledWithAValidpairNumber(pairNumber, Color.White, Color.Brown);
            TestExpectingColorPairwhenCalledWithAValidpairNumber(pairNumber=5, Color.White, Color.SlateGray);
            TestExpectingColorPairwhenCalledWithAValidpairNumber(pairNumber=23, Color.Violet, Color.Green);

            TestExpectingPairNumberwhenCalledWithAValidColorPair(Color.Yellow,Color.Green, 18);
            TestExpectingPairNumberwhenCalledWithAValidColorPair(Color.Red, Color.Blue, 6);


            //Tests for getManual() function
            string Manual = FakeGetManual(1, 1);
            Debug.Assert(Manual == "11");
            Console.WriteLine(Manual);

            Manual = FakeGetManual(1, 0);
            Debug.Assert(Manual == "");
            Console.WriteLine(Manual);

            Manual = FakeGetManual(0,0);
            Debug.Assert(Manual == "");
            Console.WriteLine(Manual);
        }
    }
}
