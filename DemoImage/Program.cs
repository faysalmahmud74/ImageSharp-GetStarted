/*using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Formats.Png;
using SixLabors.ImageSharp.Processing;
using System.IO;
using static System.Net.Mime.MediaTypeNames;

using (Image image = Image.Load("C:/Users/faysa/Desktop/share_flower_fullsize.jpg"))
{
    image.Mutate(x => x.Resize(image.Width / 2, image.Height / 2)); //Mutate function

    image.Save("C:/Users/faysa/Desktop/bar.jpg");
}

int width = 1080;
int height = 500;

using (Image<Rgba32> Image = new (width, height))
{
    Image.Save("C:/Users/faysa/Desktop/canvas.jpg");
    //Image.SaveAsPng("C:/Users/faysa/Desktop/canvas.jpg");
    //Image.SaveAsGif("C:/Users/faysa/Desktop/canvas.jpg");
    //Image.SaveAsTiff("C:/Users/faysa/Desktop/canvas.jpg");

}*/

//Clone Function

/*using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;
using SixLabors.ImageSharp.Formats.Png;

using (Image image = Image.Load("C:/Users/faysa/Desktop/share_flower_fullsize.jpg"))
{
    using (Image copy = image.Clone(x => x.Resize(image.Width / 2, image.Height / 2)))
    {
        copy.Save("C:/Users/faysa/Desktop/bar.jpg", new PngEncoder());
    }
}*/
/*using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;
using SixLabors.Shapes;
using SixLabors.ImageSharp.Processing.Processors.Drawing;



class Program
{
    static void Main()
    {
        // Define the dimensions of the image
        int width = 800;
        int height = 600;

        // Create a new image with RGB color and a white background
        using (var image = new Image<Rgb24>(width, height, Color.White))
        {
            // Your image manipulation code here
            Star star = new(x: 100.0f, y: 100.0f, prongs: 5, innerRadii: 20.0f, outerRadii: 30.0f);

            image.Mutate(x => x.Fill(Color.Red, star));

            // Save the image to a file
            image.Save("output.png");
        }
    }
}*/
/*

using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;
using SixLabors.ImageSharp.Processing.Processors.Drawing;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Drawing.Processing;
using SixLabors.Shapes;

int height = 400;
int width = 400;

Image image = new Image<Rg32>(height, width);

DrawingOptions options = new()
{
    GraphicsOptions = new()
    {
        ColorBlendingMode = PixelColorBlendingMode.Multiply
    }

};

PatternBrush brush = Brushes.Horizontal(Color.Red, Color.Blue);
PatternPen pen = Pens.DashDot(Color.Green, 5);
Star star = new(x: 100.0f, y: 100.0f, prongs: 5, innerRadii: 20.0f, outerRadii: 30.0f);

// Draws a star with horizontal red and blue hatching with a dash-dot pattern outline.
image.Mutate(x => x.Fill(options, brush, star)
                   .Draw(option, pen, star));*/

/*
using SixLabors.Fonts;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Drawing.Processing;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Processing;
using System;
using System.Numerics;
using static System.Net.Mime.MediaTypeNames;

class Program
{
    static void Main()
    {
        int width = 800;
        int height = 600;

        using (var image = new Image<Rgba32>(width, height, Rgba32.ParseHex("ffffff")))
        {
            var font = new Font(SystemFonts.Get("Arial"), 36, FontStyle.Regular);


            var size = TextMeasurer.MeasureSize("Pricetag", new TextOptions(font));
            var textPosition = new PointF((width - size.Width)/2, (height - size.Height)/5);

            var size1 = TextMeasurer.MeasureSize("BDT 500.00", new TextOptions(font));
            var textPosition1 = new PointF((width - size1.Width) / 2, (height - size1.Height) / 3);

            var size2 = TextMeasurer.MeasureSize("||||||||||||||||||", new TextOptions(font));
            var textPosition2 = new PointF((width - size2.Width) / 2, (height - size2.Height) / 2);



            image.Mutate(x => x.DrawText("Pricetag!", font, Color.Black, textPosition));
            image.Mutate(x => x.DrawText("BDT 500.00", font, Color.Red, textPosition1));
            image.Mutate(x => x.DrawText("||||||||||||||||||", font, Color.Black, textPosition2));


            // Save the image to a file
        }
    }
}*/
/*

using System;
using System.IO;
using SixLabors.ImageSharp;
using SixLabors.Fonts;
using SixLabors.ImageSharp.Processing;
using SixLabors.ImageSharp.Drawing.Processing;

class Program
{
    static void Main()
    {
        int width = 800;
        int height = 600;

        using (var image = new Image<Rgba32>(width, height, Rgba32.ParseHex("ffffff")))
        {
            Font font = SystemFonts.CreateFont("Arial", 20, FontStyle.Regular);

            var size = TextMeasurer.MeasureSize("Pricetag", new TextOptions(font));
            var size1 = TextMeasurer.MeasureSize("BDT 500.00", new TextOptions(font));
            var size2 = TextMeasurer.MeasureSize("||||||||||||||||||", new TextOptions(font));




            // Draw the first line
            PointF position1 = new PointF((width - size.Width) / 2, 50);
            image.Mutate(x => x.DrawText("Price tag", font, Color.Black, position1));

            // Draw the second line
            PointF position2 = new PointF((width - size1.Width) / 2, 100);
            image.Mutate(x => x.DrawText("Price 500", font, Color.Black, position2));

            // Draw the third line
            PointF position3 = new PointF((width - size2.Width) / 2, 150);
            image.Mutate(x => x.DrawText("BarCode", font, Color.Black, position3));

            // Save the image
            image.Save("C:/Users/faysa/Desktop/output.png");

        }
    }
}
*/

/*
using System;
using System.IO;
using SixLabors.ImageSharp;
using SixLabors.Fonts;
using SixLabors.ImageSharp.Processing;
using SixLabors.ImageSharp.Drawing.Processing;

class Program
{
    static void Main()
    {
        int width = 800;
        int height = 600;

        using (var image = new Image<Rgba32>(width, height))
        {
            Font font = SystemFonts.CreateFont("Arial", 20, FontStyle.Regular);

            // Define the text lines
            string[] lines = { "Price tag", "Price 500", "BarCode" };

            var size = TextMeasurer.MeasureSize("Pricetag", new TextOptions(font));
            var size1 = TextMeasurer.MeasureSize("BDT 500.00", new TextOptions(font));
            var size2 = TextMeasurer.MeasureSize("||||||||||||||||||", new TextOptions(font));

            float totalHeight = size.Height + size1.Height + size2.Height;



            // Calculate total height of text block
            //float totalHeight = lines.Length * font.GetLineHeight();

            // Calculate starting position for vertical centering
            float startY = (height - totalHeight) / 2;

            // Draw each line
            for (int i = 0; i < lines.Length; i++)
            {
                float lineY = startY + i * font.GetLineHeight();
                PointF position = new PointF((width - font.MeasureString(lines[i]).Width) / 2, lineY);
                image.Mutate(x => x.DrawText(lines[i], font, Color.Black, position));
            }

            // Save the image
            using (var fs = new FileStream("output.png", FileMode.Create))
            {
                image.SaveAsPng(fs);
            }
        }
    }
}*/


/*using System;
using System.IO;
using SixLabors.ImageSharp;
using SixLabors.Fonts;
using SixLabors.ImageSharp.Processing;
using SixLabors.ImageSharp.Drawing.Processing;

class Program
{
    static void Main()
    {
        int width = 178;
        int height = 100;

        using (var image = new Image<Rgba32>(width, height, Rgba32.ParseHex("ffffff")))
        {
            Font font = SystemFonts.CreateFont("Arial", 15, FontStyle.Regular);

            string[] lines = {"Price Tag", "BDT 500.00", "||||||||||||||||||" };

            float totalHeight = 0;

            foreach (var line in lines)
            {
                var size = TextMeasurer.MeasureSize(line, new TextOptions(font));
                totalHeight += (size.Height + 10);
            }

            float startY = (height - totalHeight) / 2;

            foreach (var line in lines)
            {
                var size = TextMeasurer.MeasureSize(line, new TextOptions(font));
                float lineY = startY;
                PointF position = new PointF((width - size.Width) / 2, lineY);
                image.Mutate(x => x.DrawText(line, font, Color.Black, position));
                startY += (size.Height + 15);
            }

            image.Save("C:/Users/faysa/Desktop/output.png");

        }
    }
}


//A4 Size ...................................//
using System;
using System.IO;
using SixLabors.ImageSharp;
using SixLabors.Fonts;
using SixLabors.ImageSharp.Processing;
using SixLabors.ImageSharp.Drawing.Processing;

class Program
{
    static void Main()
    {
        int a4Width = (int)(8.27 * 96);
        int a4Height = (int)(11.69 * 96);

        using (var a4Image = new Image<Rgba32>(a4Width, a4Height, Rgba32.ParseHex("ffffff")))
        {
            int width = 178;
            int height = 100;

            Font font = SystemFonts.CreateFont("Arial", 15, FontStyle.Regular);

            string[] lines = { "Price Tag", "BDT 500.00", "||||||||||||||||||" };

            float totalHeight = 0;

            foreach (var line in lines)
            {
                var size = TextMeasurer.MeasureSize(line, new TextOptions(font));
                totalHeight += (size.Height + 10);
            }

            float startY = (height - totalHeight) / 2;

            using (var image = new Image<Rgba32>(width, height, Rgba32.ParseHex("ffffff")))
            {
                foreach (var line in lines)
                {
                    var size = TextMeasurer.MeasureSize(line, new TextOptions(font));
                    float lineY = startY;
                    PointF position = new PointF((width - size.Width) / 2, lineY);
                    image.Mutate(x => x.DrawText(line, font, Color.Black, position));
                    startY += (size.Height + 15);
                }

                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        int xPos = j * (width + 20);
                        int yPos = i * (height + 20);

                        a4Image.Mutate(x => x.DrawImage(image, new Point(xPos, yPos), 1f));
                    }
                }
            }

            a4Image.Save("C:/Users/faysa/Desktop/a4output.png");
        }
    }
}
*/
using System;
using System.IO;
using SixLabors.ImageSharp;
using SixLabors.Fonts;
using SixLabors.ImageSharp.Processing;
using SixLabors.ImageSharp.Drawing.Processing;

class Program
{
    static void Main()
    {
        int a4Width = (int)(8.27 * 96);
        int a4Height = (int)(11.69 * 96);

        //int imagesPerPage = 36;
        //int totalImages = 100;

        
        int pageArea = a4Width * a4Height;

        using (var a4Image = new Image<Rgba32>(a4Width, a4Height, Rgba32.ParseHex("ffffff")))
        {
            int width = 178;
            int height = 100;

            Font font = SystemFonts.CreateFont("Arial", 15, FontStyle.Regular);

            string[] lines = { "Price Tag", "BDT 500.00", "||||||||||||||||||" };

            float totalHeight = 0;

            foreach (var line in lines)
            {
                var size = TextMeasurer.MeasureSize(line, new TextOptions(font));
                totalHeight += (size.Height + 10);
            }

            float startY = (height - totalHeight) / 2;

            using (var image = new Image<Rgba32>(width, height, Rgba32.ParseHex("ffffff")))
            {
                foreach (var line in lines)
                {
                    var size = TextMeasurer.MeasureSize(line, new TextOptions(font));
                    float lineY = startY;
                    PointF position = new PointF((width - size.Width) / 2, lineY);
                    image.Mutate(x => x.DrawText(line, font, Color.Black, position));
                    startY += (size.Height + 15);
                }

                int imageArea = width * height;

                int pageCount = (int)Math.Ceiling((double)pageArea / imageArea);
                //var page = 

                for (int page = 0; page < pageCount; page++)
                {
                    for (int i = 0; i < Math.Min(imageArea, pageArea - page * imageArea); i++)
                    {
                        int row = i / 4;
                        int col = i / 4;

                        int xPos = col * (width + 20);
                        int yPos = row * (height + 20);

                        a4Image.Mutate(x => x.DrawImage(image, new Point(xPos, yPos), 1f));
                    }

                    if (page < pageCount - 1)
                    {
                        a4Image.Save($"C:/Users/faysa/Desktop/a4output_page{page + 1}.png");
                        a4Image.Mutate(x => x.BackgroundColor(Rgba32.ParseHex("ffffff")));
                    }
                    else
                    {
                        a4Image.Save($"C:/Users/faysa/Desktop/a4output.png");
                    }
                }
            }
        }
    }
}


/*
using System;
using System.IO;
using SixLabors.ImageSharp;
using SixLabors.Fonts;
using SixLabors.ImageSharp.Processing;
using SixLabors.ImageSharp.Drawing.Processing;

class Program
{
    static void Main()
    {
        int a4Width = (int)(8.27 * 96); // A4 size in pixels at 96 DPI
        int a4Height = (int)(11.69 * 96);

        int imagesPerPage = 36; // Number of images per A4 page
        int totalImages = 100;  // Total images needed

        using (var a4Image = new Image<Rgba32>(a4Width, a4Height, Rgba32.ParseHex("ffffff")))
        {
            int width = 178;
            int height = 100;

            Font font = SystemFonts.CreateFont("Arial", 15, FontStyle.Regular);

            string[] lines = { "Price Tag", "BDT 500.00", "||||||||||||||||||" };

            float totalHeight = 0;

            foreach (var line in lines)
            {
                var size = TextMeasurer.MeasureSize(line, new TextOptions(font));
                totalHeight += (size.Height + 10);
            }

            float startY = (height - totalHeight) / 2;

            using (var image = new Image<Rgba32>(width, height, Rgba32.ParseHex("ffffff")))
            {
                foreach (var line in lines)
                {
                    var size = TextMeasurer.MeasureSize(line, new TextOptions(font));
                    float lineY = startY;
                    PointF position = new PointF((width - size.Width) / 2, lineY);
                    image.Mutate(x => x.DrawText(line, font, Color.Black, position));
                    startY += (size.Height + 15);
                }

                int pageCount = (int)Math.Ceiling((double)totalImages / imagesPerPage);

                for (int page = 0; page < pageCount; page++)
                {
                    for (int i = 0; i < Math.Min(imagesPerPage, totalImages - page * imagesPerPage); i++)
                    {
                        int row = i / 4;
                        int col = i % 4;

                        int xPos = col * (width + 20);
                        int yPos = row * (height + 20);

                        a4Image.Mutate(x => x.DrawImage(image, new Point(xPos, yPos), 1f));
                    }

                    if (page < pageCount - 1)
                    {
                        a4Image.Save($"C:/Users/faysa/Desktop/a4output_page{page + 1}.png");
                        a4Image.Mutate(x => x.BackgroundColor(Rgba32.ParseHex("ffffff"))); // Reset background for next page
                    }
                    else
                    {
                        a4Image.Save($"C:/Users/faysa/Desktop/a4output.png");
                    }
                }
            }
        }
    }
}


*/


