using SkiaSharp;
using SkiaSharp.Views.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SkiaSharpDemo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnPaintSample(object sender, SKPaintSurfaceEventArgs e)
        {
            int surfaceWidth = e.Info.Width;
            int surfaceHeight = e.Info.Height;
            SKCanvas canvas = e.Surface.Canvas;
            float side = Math.Min(surfaceHeight, surfaceWidth) * 0.5f;
             
            using (SKPaint paint = new SKPaint())
            {
                canvas.Clear(Color.Black.ToSKColor());  //paint it black
                SKRect r1 = new SKRect(10f, 20f, side, side);
                paint.Color = Color.Blue.ToSKColor();
                canvas.DrawRect(r1, paint);

                paint.Color = Color.Red.ToSKColor();
                canvas.DrawOval(r1, paint);
            }
        }
    }
}
