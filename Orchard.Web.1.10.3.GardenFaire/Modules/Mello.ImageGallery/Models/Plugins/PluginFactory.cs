using Mello.ImageGallery.Models.Plugins.LightBox;
using Mello.ImageGallery.Models.Plugins.PrettyPhoto;
using Mello.ImageGallery.Models.Plugins.SlideViewerPro;
using Mello.ImageGallery.Models.Plugins.BootstrapCarousel;
using Mello.ImageGallery.Models.Plugins.BootstrapThumbnails;

namespace Mello.ImageGallery.Models.Plugins
{
    public abstract class PluginFactory
    {
        public static PluginFactory GetFactory(Plugin plugin)
        {
            if (plugin == Plugins.Plugin.PrettyPhoto)
            {
                return new PrettyPhotoFactory();
            }
            if (plugin == Plugins.Plugin.SlideViewerPro)
            {
                return new SlideViewerProFactory();
            }
            if (plugin == Plugins.Plugin.BootstrapCarousel)
            {
                return new BootstrapCarouselFactory();
            }
            if (plugin == Plugins.Plugin.BootstrapThumbnails)
            {
                return new BootstrapThumbnailsFactory();
            }
            return new LightBoxFactory();
        }

        public abstract ImageGalleryPlugin Plugin { get; }

        public abstract PluginResourceDescriptor PluginResourceDescriptor { get; }
    }
}