using Java.Lang;

namespace Top.Defaults.Drawabletoolbox
{
    public partial class DrawableBuilder
    {
        public DrawableBuilder GradientColors(int startColor, int endColor, int centerColor) => 
            GradientColors(startColor, endColor, Integer(centerColor));

        public DrawableBuilder SolidColorPressed(int color) => SolidColorPressed(Integer(color));

        public DrawableBuilder SolidColorPressedWhenRippleUnsupported(int color) => SolidColorPressedWhenRippleUnsupported(Integer(color));

        public DrawableBuilder SolidColorDisabled(int color) => SolidColorDisabled(Integer(color));

        public DrawableBuilder SolidColorSelected(int color) => SolidColorSelected(Integer(color));

        public DrawableBuilder StrokeColorPressed(int color) => StrokeColorPressed(Integer(color));

        public DrawableBuilder StrokeColorDisabled(int color) => StrokeColorDisabled(Integer(color));

        public DrawableBuilder StrokeColorSelected(int color) => StrokeColorSelected(Integer(color));

        private static Integer Integer(int csharpInt) => new Integer(csharpInt);
    }
}
