using Android.App;
using Android.Widget;
using Android.OS;
using Top.Defaults.Drawabletoolbox;
using Android.Graphics;

namespace DrawableToolbox.Sample
{
    [Activity(Label = "DrawableToolbox.Sample", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Main);

            Button button = FindViewById<Button>(Resource.Id.myButton);

            var background = new DrawableBuilder()
                .Rectangle()
                .HairlineBordered()
                .StrokeColor(Color.Red)
                .StrokeColorPressed(Color.Blue)
                .Ripple()
                .RippleColor(Color.Yellow)
                .Build();

            button.Background = background;

            button.Click += delegate { button.Text = $"{count++} clicks!"; };
        }
    }
}

