using System.Drawing;

namespace org.ek.HandMeAFile.commons.ApiWrapper.System.Drawing
{
    public class BitmapWrapper : IBitmap
    {
        // ReSharper disable once NotAccessedField.Local
        private readonly Bitmap m_orgBitmap;

        public BitmapWrapper(Bitmap orgBitmap)
        {
            m_orgBitmap = orgBitmap;
        }
    }
}