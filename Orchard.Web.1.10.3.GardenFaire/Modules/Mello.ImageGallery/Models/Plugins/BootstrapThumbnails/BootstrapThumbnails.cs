namespace Mello.ImageGallery.Models.Plugins.BootstrapThumbnails
{
    public class BootstrapThumbnails : ImageGalleryPlugin
    {
        private readonly BootstrapThumbnailsSettings _settings;
        public BootstrapThumbnails(BootstrapThumbnailsSettings settings)
        {
            _settings = settings;
        }
        public override string ToString(string cssSelector)
        {
            // this isn't necessary, because there is no main javascript function
            //return string.Format("$('{0}').thumbnails({1});", cssSelector, _settings);
            return "";
        }
        public override string ImageGalleryTemplateName
        {
            get { return "Parts/Plugins/BootstrapThumbnails"; }
        }
    }
}