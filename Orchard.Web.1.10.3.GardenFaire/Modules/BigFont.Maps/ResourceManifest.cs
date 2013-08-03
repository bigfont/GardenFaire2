using Orchard.UI.Resources;

namespace Orchard.Blogs
{
    public class ResourceManifest : IResourceManifestProvider
    {
        // This ApiKey is associated with the GardenFaire account at Google Cloud.
        // That account is managed by admin@shaunluttin.com account.
        private const string ApiKey = "AIzaSyDDzdCAFi4akOsGIq_34jroys1tV1alATI";

        public void BuildManifests(ResourceManifestBuilder builder)
        {
            var manifest = builder.Add();

            manifest.DefineScript("GoogleMapsApi")
                .SetUrl($"https://maps.googleapis.com/maps/api/js?sensor=false&key={ApiKey}");

            manifest.DefineScript("BigFontMap_MultipleMarkers")
                .SetUrl("BigFontMap_MultipleMarkers.min.js")
                .SetDependencies("GoogleMapsApi");

            manifest.DefineScript("BigFontMap_SingleMarker")
                .SetUrl("BigFontMap_SingleMarker.min.js")
                .SetDependencies("GoogleMapsApi");
        }
    }
}
