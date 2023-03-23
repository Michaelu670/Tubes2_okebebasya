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
        public static readonly Color Default = Color.FromArgb(0xED, 0xF1, 0xD6);
        public static readonly Color Obstacle = Color.Black;
        public static readonly Color KrustyKrab = Color.Aquamarine;

        public static readonly Color SearchHead = Color.FromArgb(0x59, 0x5C, 0xFF);

        public static readonly Color PathHead  = Color.FromArgb(0x5C, 0xB2, 0x70);
        public static readonly Color PathOnce  = Color.FromArgb(0xE9, 0xD0, 0x22);
        public static readonly Color PathTwice = Color.FromArgb(0xF4, 0xB7, 0x16);
        public static readonly Color PathOften = Color.FromArgb(0xFF, 0x9D, 0x09);

        public static readonly Color Processing = Color.Blue;
        public static readonly Color ProcessFinished = Color.Yellow;

        public static readonly Dictionary<Color, Color> NextColorDict = new Dictionary<Color, Color>()
        {
            {Default, PathOnce },
            {PathOnce, PathTwice },
            {PathTwice, PathOften },
            {PathOften, PathOften }
        };

        public static Color NextColor(Color color)
        {
            if (NextColorDict.Keys.Contains(color))
            {
                return NextColorDict[color];
            }
            return PathOnce;
        }
    }

}
