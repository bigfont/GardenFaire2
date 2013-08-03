namespace Mello.ImageGallery.Models.Plugins.BootstrapCarousel
{
    public class BootstrapCarousel : ImageGalleryPlugin
    {
        private readonly BootstrapCarouselSettings _settings;
        public BootstrapCarousel(BootstrapCarouselSettings settings)
        {
            _settings = settings;
        }
        public override string ToString(string cssSelector)
        {
            // This must match the method call to .carousel() in the bootstrap-carousel.js file.        
            return string.Format("$('{0}').carousel({1});", cssSelector, _settings);
        }
        public override string ImageGalleryTemplateName
        {
            get { return "Parts/Plugins/BootstrapCarousel"; }
        }
    }
}