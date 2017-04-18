using Xamarin.Forms;

namespace ScreenSize
{
    public interface IScreenSize
    {
        /// <summary>
        /// 画面サイズの取得
        /// </summary>
        /// <returns>画面サイズ</returns>
        Size GetScreenSize();
    }
}
