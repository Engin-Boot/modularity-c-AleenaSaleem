using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Telco.ColorCoder { 
    class ColorMap {
        public static ColorCode.ColorPair GetColorFromPairNumber(int pairNumber)
        {
            int minorSize = ColorCode.colorMapMajor.Length;
            int majorSize = ColorCode.colorMapMajor.Length;
            if (pairNumber < 1 || pairNumber > minorSize * majorSize){
                throw new ArgumentOutOfRangeException(
                    string.Format("Argument PairNumber:{0} is outside the allowed range", pairNumber));
            }
            int zeroBasedPairNumber = pairNumber - 1;
            int majorIndex = zeroBasedPairNumber / minorSize;
            int minorIndex = zeroBasedPairNumber % minorSize;
            ColorCode.ColorPair pair = new ColorCode.ColorPair()
            {
                majorColor = ColorCode.colorMapMajor[majorIndex],
                minorColor = ColorCode.colorMapMinor[minorIndex]
            };
            return pair;
        }
        public static int GetPairNumberFromColor(ColorCode.ColorPair pair)
        {
            int majorIndex = -1;
            for (int i = 0; i < ColorCode.colorMapMajor.Length; i++){
                if (ColorCode.colorMapMajor[i] == pair.majorColor)
                {
                    majorIndex = i;
                    break;
                }
            }
            int minorIndex = -1;
            for (int i = 0; i < ColorCode.colorMapMinor.Length; i++){
                if (ColorCode.colorMapMinor[i] == pair.minorColor)
                {
                    minorIndex = i;
                    break;
                }
            }
            if (majorIndex == -1 || minorIndex == -1)
                throw new ArgumentException(string.Format("Unknown Colors: {0}", pair.ToString()));
            return (majorIndex * ColorCode.colorMapMinor.Length) + (minorIndex + 1);
        }
    }
}
