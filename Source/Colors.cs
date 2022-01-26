using System.Drawing;

namespace SpicetifySettingsApp.Source
{
    internal class Colors
    {
        public static Color GetBg(int elevationStep)
        {
            switch(elevationStep)
            {
            case 0:
                return Color.FromArgb(18, 18, 18);
            case 1:
                return Color.FromArgb(29, 29, 29);
            case 2:
                return Color.FromArgb(33, 33, 33);
            case 3:
                return Color.FromArgb(36, 36, 36);
            case 4:
                return Color.FromArgb(38, 38, 38);
            case 5:
                return Color.FromArgb(44, 44, 44);
            case 6:
                return Color.FromArgb(45, 45, 45);
            case 7:
                return Color.FromArgb(50, 50, 50);
            case 8:
                return Color.FromArgb(53, 53, 53);
            case 9:
                return Color.FromArgb(55, 55, 55);
            default:
                return Color.FromArgb(18, 18, 18);
            }
        }

        public static Color Primary = Color.FromArgb(234, 82, 58);
        public static Color TxtLight = SystemColors.ControlLightLight;
        public static Color TxtDark = SystemColors.ControlText;
    }
}