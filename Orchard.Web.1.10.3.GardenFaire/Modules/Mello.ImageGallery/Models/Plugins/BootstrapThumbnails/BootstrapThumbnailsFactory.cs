namespace Mello.ImageGallery.Models.Plugins.BootstrapThumbnails
{
    public sealed class BootstrapThumbnailsFactory : PluginFactory {
        public BootstrapThumbnailsFactory()
        {
            _pluginResourceDescriptor = new BootstrapThumbnailsResourceDescriptor();
            _plugin = new BootstrapThumbnails(new BootstrapThumbnailsSettings(PluginResourceDescriptor.PluginResourcePath));
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