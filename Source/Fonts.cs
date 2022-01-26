using System;
using System.Drawing.Text;

namespace SpicetifySettingsApp.Source
{
    internal class Fonts
    {
        public static PrivateFontCollection Pfc = new PrivateFontCollection();
        public static void LoadFonts()
        {
            LoadFontFromResx(SpicetifyManager.Properties.Resources.OpenSans_Regular);
            LoadFontFromResx(SpicetifyManager.Properties.Resources.OpenSans_SemiBold);
        }

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont, IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private static void LoadFontFromResx(byte[] font)
        {
            byte[] fontData = font;
            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            uint dummy = 0;
            Pfc.AddMemoryFont(fontPtr, font.Length);
            AddFontMemResourceEx(fontPtr, (uint)font.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);
        }
    }
}