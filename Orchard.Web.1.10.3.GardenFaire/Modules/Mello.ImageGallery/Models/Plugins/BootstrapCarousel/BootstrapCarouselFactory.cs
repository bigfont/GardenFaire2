namespace Mello.ImageGallery.Models.Plugins.BootstrapCarousel
{
    public sealed class BootstrapCarouselFactory : PluginFactory {
        public BootstrapCarouselFactory()
        {
            _pluginResourceDescriptor = new BootstrapCarouselResourceDescriptor();
            _plugin = new BootstrapCarousel(new BootstrapCarouselSettings(PluginResourceDescriptor.PluginResourcePath));
        }

        private readonly ImageGalleryPlugin _plugin;

        private readonly PluginResourceDescriptor _pluginResourceDescriptor;

        public override ImageGalleryPlugin Plugin {
            get { return _plugin; }
        }

        public override PluginResourceDescriptor PluginResourceDescriptor {
            get { return _pluginResourceDescriptor; }
        }
    }
}