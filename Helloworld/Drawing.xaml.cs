using System;
using System.Collections.Generic;
using SkiaSharp;
using System.IO;
using SkiaSharp.Views.Forms;
using Xamarin.Forms;
using System.Reflection;

namespace Helloworld
{
	public partial class Drawing : ContentPage
	{
		SKBitmap resourceBitmap;
		public Drawing()
		{
			InitializeComponent();
			string resourceID = "Helloworld.Media.icon.png";
			Assembly assembly = GetType().GetTypeInfo().Assembly;
			using (Stream stream = assembly.GetManifestResourceStream(resourceID))
			using (SKManagedStream skStream = new SKManagedStream(stream))
			{
				resourceBitmap = SKBitmap.Decode(skStream); // System.NullReferen			
			}
		}

		void OnCanvasViewPaintSurface(object sender, SKPaintSurfaceEventArgs e)
		{
			//createImage(sender, args);
			var surface = e.Surface;
			var canvas = surface.Canvas;
			canvas.Clear(SKColors.White);

			var w = e.Info.Width;
			var h = e.Info.Height;

			SKColor[] colors;
			colors = new SKColor[] {
				 new SKColor(244, 0, 110, 200), new SKColor(244, 0, 110, 220),
				 new SKColor(244, 0, 110, 240),new SKColor(244, 0, 110, 240),
				 new SKColor(244, 0, 100,240),
				 new SKColor(244, 0, 100),
				 new SKColor(255, 0, 70)
				};
			SKShader shaderLeft = SKShader.CreateLinearGradient(new SKPoint(0, 0), new SKPoint(w, h), colors, null, SKShaderTileMode.Clamp);
			var paint = new SKPaint() { Shader = shaderLeft };
			//canvas.DrawPaint(paint);


			var path2 = new SKPath { FillType = SKPathFillType.EvenOdd };
			path2.MoveTo(0, 0);
			path2.LineTo(0, 140);
			path2.LineTo(140, 140);
			path2.LineTo(0, 0);
			path2.Close();

			var pathStroke2 = new SKPaint
			{
				IsAntialias = true,
				Style = SKPaintStyle.StrokeAndFill,
				Color = new SKColor(0, 0, 0, 30),
				StrokeWidth = 5
			};

			using (var cf = SKColorFilter.CreateBlendMode(new SKColor(244, 0, 110, 200), SKBlendMode.DstIn))
			{
				var transparency = SKColors.White.WithAlpha(127);
				pathStroke2.ColorFilter = cf;

				// ... draw ...
				canvas.DrawPath(path2, pathStroke2);

				pathStroke2.ColorFilter = null;
			}

			var pathStroke3 = new SKPaint
			{
				IsAntialias = true,
				Style = SKPaintStyle.StrokeAndFill,
				Color = new SKColor(0, 0, 0, 30),
				StrokeWidth = 5
			};

			var path3 = new SKPath { FillType = SKPathFillType.EvenOdd };
			path3.MoveTo(170, 0);
			path3.LineTo(170, 140);
			path3.LineTo(300, 140);
			path3.LineTo(170, 0);
			path3.Close();
			canvas.DrawPath(path3, pathStroke3);
		}

		void createImage(object sender, SKPaintSurfaceEventArgs args)
		{
			SKImageInfo info = args.Info;
			SKSurface surface = args.Surface;
			SKCanvas canvas = surface.Canvas;
			canvas.Clear();
			if (resourceBitmap != null)
			{
				canvas.DrawBitmap(resourceBitmap,
					new SKRect(0, 0, info.Width, info.Height));
			}
			SKPaint vBlackPaint = new SKPaint
			{
				Color = SKColors.Black,
				StrokeWidth = 5,
				StrokeCap = SKStrokeCap.Round,
				TextSize = 6
			};
			canvas.DrawLine(0, 0, 200, 200, vBlackPaint);
		}
	}
}
