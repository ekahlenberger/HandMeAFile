using System.Drawing;

namespace org.ek.HandMeAFile.commons.Extensions
{
    public static class ColorExtension
    {
        // unneeded comment
        public static Color LinearScale(this Color a, Color b, float scale)
        {
            int red = (int)((b.R - a.R) * scale + a.R);
            int green = (int)((b.G - a.G) * scale + a.G);
            int blue = (int)((b.B - a.B) * scale + a.B);
            int alpha = (int) ((b.A - a.A) * scale + a.A);
            return Color.FromArgb(alpha, red, green, blue);
        }
    }
}