using System;
using System.Collections.Generic;
using SkiaSharp;
using System.IO;
using SkiaSharp.Views.Forms;
using Xamarin.Forms;
using System.Reflection;

namespace Helloworld
{
	public partial class DrawingImage : ContentPage
	{
		SKBitmap resourceBitmap;

		public DrawingImage()
		{
			InitializeComponent();
			//string resourceID = "Helloworld.Media.monkey.png";
			//Assembly assembly = GetType().GetTypeInfo().Assembly;
			//using (Stream stream = assembly.GetManifestResourceStream(resourceID))
			//using (SKManagedStream skStream = new SKManagedStream(stream))
			//{
			//	resourceBitmap = SKBitmap.Decode(skStream); // System.NullReference
			//}
		}

		void OnCanvasViewPaintSurface(object sender, SKPaintSurfaceEventArgs args)
		{
			//SKImageInfo info = args.Info;
			//SKSurface surface = args.Surface;
			//SKCanvas canvas = surface.Canvas;

			//canvas.Clear();
			//if (resourceBitmap != null)
			//{
			//	canvas.DrawBitmap(resourceBitmap,
			//		new SKRect(0, info.Height / 3, info.Width, 2 * info.Height / 3));
			//}
			//string resourceID = "Helloworld.Media.icon.png";
			//Assembly assembly = GetType().GetTypeInfo().Assembly;

			//Stream stream = assembly.GetManifestResourceStream(resourceID);
			//SKManagedStream skStream = new SKManagedStream(stream);
			//SKBitmap _bitmap = SKBitmap.Decode(skStream);
			//using (var paint = new SKPaint())
			//{
			//	SKSize imgSize = new SKSize(_bitmap.Width, _bitmap.Height);
			//	SKRect aspectRect = new SKRect(0, 0, 300, 300);
			//	//GetAspectRectangle(SKRect.Create(psea.Info.Width, psea.Info.Height));
			//	args.Surface.Canvas.DrawBitmap(_bitmap, aspectRect, paint);
			//}
			//Initialize the Canvas  
			SKSurface vSurface = args.Surface;
			SKCanvas vCanvas = vSurface.Canvas;
			//Clear the Canvas  
			vCanvas.Clear();
			//Creating the Paint object to color the Items  
			SKPaint vBlackPaint = new SKPaint
			{
				Color = SKColors.Black,
				StrokeWidth = 5,
				StrokeCap = SKStrokeCap.Round,
				TextSize = 60
			};
			SKPaint vWhitePaint = new SKPaint
			{
				Color = SKColors.White
			};
			var vRectangle = new SKRect(100, 100, 900, 900);
			vCanvas.DrawRect(vRectangle, vBlackPaint);
			var vWhiteRectangle = new SKRect(105, 105, 895, 895);
			vCanvas.DrawRect(vWhiteRectangle, vWhitePaint);
			//Diagnol Lines  
			vCanvas.DrawLine(100, 100, 900, 900, vBlackPaint);
			vCanvas.DrawLine(900, 100, 100, 900, vBlackPaint);
			//Drawing the Numbers between the lines  
			vCanvas.DrawText("1", 500, 300, vBlackPaint);
			vCanvas.DrawText("2", 260, 200, vBlackPaint);
			vCanvas.DrawText("3", 150, 350, vBlackPaint);
			vCanvas.DrawText("4", 250, 500, vBlackPaint);
			vCanvas.DrawText("5", 150, 700, vBlackPaint);
			vCanvas.DrawText("6", 260, 800, vBlackPaint);
			vCanvas.DrawText("7", 500, 700, vBlackPaint);
			vCanvas.DrawText("8", 670, 830, vBlackPaint);
			vCanvas.DrawText("9", 780, 700, vBlackPaint);
			vCanvas.DrawText("10", 670, 500, vBlackPaint);
			vCanvas.DrawText("11", 780, 350, vBlackPaint);
			vCanvas.DrawText("12", 670, 200, vBlackPaint);
			//The Side lines for creating other boxes  
			vCanvas.DrawLine(100, 500, 500, 100, vBlackPaint);
			vCanvas.DrawLine(100, 500, 500, 900, vBlackPaint);
			vCanvas.DrawLine(500, 100, 900, 500, vBlackPaint);
			vCanvas.DrawLine(500, 900, 900, 500, vBlackPaint);
		}
	}
}
