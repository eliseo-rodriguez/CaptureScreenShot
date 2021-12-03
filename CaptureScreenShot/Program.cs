using System.Drawing;
using System.Drawing.Imaging;

var path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

using (var bitmap = new Bitmap(1920, 1080))
{
    using (Graphics g = Graphics.FromImage(bitmap))
    {
        g.CopyFromScreen(0, 0, 0, 0, bitmap.Size, CopyPixelOperation.SourceCopy);
    }
    int imageNumber = 0;
    string fileName = $"{path}/img{imageNumber}.jpg";

    while (File.Exists(fileName))
    {
        imageNumber++;
        fileName = $"{path}/img{imageNumber}.jpg";
    }

    bitmap.Save(fileName, ImageFormat.Jpeg);
}
