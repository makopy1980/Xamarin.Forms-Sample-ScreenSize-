using ScreenSize;
using Xamarin.Forms;

namespace XFScreenSizeSample
{
    public partial class XFScreenSizeSamplePage : ContentPage
    {
        public XFScreenSizeSamplePage()
        {
            InitializeComponent();
        }

        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);

            // 画面サイズを取得
            var screenSize = DependencyService.Get<IScreenSize>().GetScreenSize();

            System.Diagnostics.Debug.WriteLine("[Page] width: {0} height: {1} [Screen] width: {2} height: {3}", 
                                               width, height, screenSize.Width, screenSize.Height);

        }
    }
}
