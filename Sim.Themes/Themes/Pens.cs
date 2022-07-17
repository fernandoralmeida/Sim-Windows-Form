using System.Drawing;

namespace Sim.Gui.Themes
{
    public static class Pens
    {
        public static Pen Control { get; set; }
        public static Pen ControlLight { get; set; }
        public static Pen ControlLightLight { get; set; }
        public static Pen ControlDark { get; set; }
        public static Pen ControlDarkDark { get; set; }
        public static Pen ControlDisable { get; set; }
        public static Pen ControlHighLight { get; set; }
        public static Pen ControlHighLightDark { get; set; }
        public static Pen ControlHighLightDarkDark { get; set; }

        private static Pen dashedpen;
        private static Pen dashedpendark;
        private static Pen dashedpendarkdark;

        public static Pen DashedHighLight
        {
            get { return dashedpen; }
            set
            {
                float[] dashValues = { 1, 1, 1, 1 };
                value.DashPattern = dashValues;
                dashedpen = value;
            }
        }

        public static Pen DashedHighLightDark
        {
            get { return dashedpendark; }
            set
            {
                float[] dashValues = { 1, 1, 1, 1 };
                value.DashPattern = dashValues;
                dashedpendark = value;
            }
        }

        public static Pen DashedHighLightDarkDark
        {
            get { return dashedpendarkdark; }
            set
            {
                float[] dashValues = { 1, 1, 1, 1 };
                value.DashPattern = dashValues;
                dashedpendarkdark = value;
            }
        }

        public static Pen Font { get; set; }
        public static Pen FontHighlight { get; set; }
    }
}
