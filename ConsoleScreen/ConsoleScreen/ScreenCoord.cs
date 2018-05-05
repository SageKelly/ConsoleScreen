namespace ConsoleScreen
{
    public class ScreenCoord
    {
        public int Left { get; set; }
        public int Top { get; set; }

        public ScreenCoord(int Left = 0, int Top = 0)
        {
            this.Left = Left;
            this.Top = Top;
        }
    }
}