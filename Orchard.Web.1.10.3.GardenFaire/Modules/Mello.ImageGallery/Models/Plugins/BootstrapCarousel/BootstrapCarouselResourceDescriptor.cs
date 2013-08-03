namespace Mello.ImageGallery.Models.Plugins.BootstrapCarousel
{
    public class BootstrapCarouselResourceDescriptor : PluginResourceDescriptor
    {
        public BootstrapCarouselResourceDescriptor()
        {
            //TODO: Add javascript to the bootstrap-carousel.min.js file.
            //TODO: Add the javascript if and only if it is not already present on the page, 
            //because duplicating the javascript causes errors, I think. 
            AddScript("Scripts/bootstrap-carousel.min.js");
            AddStyle("Styles/bootstrap-carousel.css");
        }
        public override string PluginName
        {
            get { return "BootstrapCarousel"; }
        }
    }
}