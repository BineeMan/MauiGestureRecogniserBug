
using Microsoft.Maui.Controls.Shapes;
using System.Diagnostics;
using Debug = System.Diagnostics.Debug;

namespace MauiGestureRecogniserBug;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
        DrawPolygon();
    }

	private void DrawPolygon()
	{
        PointCollection points = new[]
        {
            new Point(300, 100),
            new Point(400, 100),
            new Point(400, 400),
            new Point(300, 400),
            new Point(300, 100),
        };

        Polygon polygon = new Polygon()
        {
            Points = points,
            Fill = Color.FromRgb(137, 137, 137),
            Stroke = Brush.Gray,
            StrokeThickness = 0,
            IsEnabled = true,
            BackgroundColor = Colors.Red
        };

        TapGestureRecognizer tapGestureRecognizer = new TapGestureRecognizer();
        tapGestureRecognizer.Tapped += TapGestureRecognizerPolygon_Tapped;
        polygon.GestureRecognizers.Add(tapGestureRecognizer);

        absoluteLayout.Add(polygon);
    }

    private void TapGestureRecognizerPolygon_Tapped(object sender, TappedEventArgs e)
    {
        Debug.WriteLine("Polygon Tapped");
    }

    private void AbsoluteLayout_Tapped(object sender, TappedEventArgs e)
	{
		Debug.WriteLine("AbsoluteLayout Tapped");
	}

}

