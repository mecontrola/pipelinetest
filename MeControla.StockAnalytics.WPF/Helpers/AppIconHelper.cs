using System.Windows.Media;

namespace MeControla.StockAnalytics.WPF.Helpers
{
    public class AppIconHelper
    {
        private const string PATH_IMAGE_ICON_ADD_16 = "Resources/Images/add_icon_16.png";
        private const string PATH_IMAGE_ICON_ACTIVE_16 = "Resources/Images/active_icon_16.png";
        private const string PATH_IMAGE_ICON_DELETE_16 = "Resources/Images/delete_icon_16.png";
        private const string PATH_IMAGE_ICON_FILTER_16 = "Resources/Images/filter_icon_16.png";
        private const string PATH_IMAGE_ICON_PLAY_16 = "Resources/Images/play_icon_16.png";
        private const string PATH_IMAGE_ICON_SAVE_16 = "Resources/Images/save_icon_16.png";
        private const string PATH_IMAGE_ICON_UPDATE_16 = "Resources/Images/update_icon_16.png";

        private const string PATH_IMAGE_LOGO = "Resources/Images/splash-logo.png";
        private const string PATH_IMAGE_ILLUSTRATION = "Resources/Images/splash-illustration.png";

        public static ImageSource IconAdd16 { get; } = ResourceImage.GetByAssembly(PATH_IMAGE_ICON_ADD_16);
        public static ImageSource IconActive16 { get; } = ResourceImage.GetByAssembly(PATH_IMAGE_ICON_ACTIVE_16);
        public static ImageSource IconDelete16 { get; } = ResourceImage.GetByAssembly(PATH_IMAGE_ICON_DELETE_16);
        public static ImageSource IconFilter16 { get; } = ResourceImage.GetByAssembly(PATH_IMAGE_ICON_FILTER_16);
        public static ImageSource IconPlay16 { get; } = ResourceImage.GetByAssembly(PATH_IMAGE_ICON_PLAY_16);
        public static ImageSource IconSave16 { get; } = ResourceImage.GetByAssembly(PATH_IMAGE_ICON_SAVE_16);
        public static ImageSource IconUpdate16 { get; } = ResourceImage.GetByAssembly(PATH_IMAGE_ICON_UPDATE_16);

        public static ImageSource IconLogo { get; } = ResourceImage.GetByAssembly(PATH_IMAGE_LOGO);
        public static ImageSource IconIllustration { get; } = ResourceImage.GetByAssembly(PATH_IMAGE_ILLUSTRATION);
    }
}