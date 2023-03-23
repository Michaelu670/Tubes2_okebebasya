using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal static class GridColor
    {
        public static readonly Dictionary<string, Color> ColorList = new Dictionary<string, Color>()
        {
            {"Default", Color.FromArgb(0xED, 0xF1, 0xD6) },
            {"Obstacle", Color.Black },
            {"KrustyKrab", Color.Aquamarine },

            {"SearchHead", Color.FromArgb(0x59, 0x5C, 0xFF) },
            {"SearchTrailFive", Color.FromArgb(0x90, 0xAA, 0xFF) },
            {"SearchTrailElse", Color.FromArgb(0xB4, 0xDE, 0xFF) },

            {"PathHead", Color.FromArgb(0x5C, 0xB2, 0x70) },
            {"PathOnce", Color.FromArgb(0xE9, 0xD0, 0x22) },
            {"PathTwice", Color.FromArgb(0xF4, 0xB7, 0x16) },
            {"PathOften", Color.FromArgb(0xFF, 0x9D, 0x09) },

            {"Processing", Color.Blue },
            {"ProcessFinished", Color.Yellow }

        };

        public static readonly Dictionary<Color, Color> NextColorDict = new Dictionary<Color, Color>()
        {
            {ColorList["Default"], ColorList["PathOnce"] },
            {ColorList["PathOnce"], ColorList["PathTwice"] },
            {ColorList["PathTwice"], ColorList["PathOften"] },
            {ColorList["PathOften"], ColorList["PathOften"] }
        };

        public static Color NextColor(Color color)
        {
            if (NextColorDict.Keys.Contains(color))
            {
                return NextColorDict[color];
            }
            return ColorList["PathOnce"];
        }
    }

}
