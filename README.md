GardenFaire2
============

This repo stores the resources for the GardenFaire.ca website.

The `Orchard.Web.1.10.3.GardenFaire/` directory contains an up-to-date version of the GardenFaire website.

### Run Locally

We can run it locally like this: 

    iisexpress /path:C:\dev\bigfont\GardenFaire2\Orchard.Web.1.10.3.GardenFaire

### Deploy a ZIP file

We can deploy it like this: 

    Compress-Archive -Path .\Orchard.Web.1.10.3.GardenFaire\* -DestinationPath .\Orchard.Web.1.10.3.GardenFaire.ZipDeploy

Then navigate to https://gardenfaire2-staging.scm.azurewebsites.net/ZipDeployUI and drag the .zip file into the UI.

See also: https://docs.microsoft.com/en-us/azure/app-service/deploy-zip
