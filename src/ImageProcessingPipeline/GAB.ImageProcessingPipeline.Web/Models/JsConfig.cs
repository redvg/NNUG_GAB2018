using GAB.ImageProcessingPipeline.Common;
using GAB.ImageProcessingPipeline.Common.Storage;

namespace GAB.ImageProcessingPipeline.Web.Models
{
    public class JsConfig
    {
        private string StorageBaseUrl => CloudBlobStorage.GetBaseUri();

        public string OriginalsContainerUrl => StorageBaseUrl + BlobContainers.Originals + "/";
        public string LargeImagesContainerUrl => StorageBaseUrl + BlobContainers.ScaledLarge + "/";
        public string MediumImagesContainerUrl => StorageBaseUrl + BlobContainers.ScaledMedium + "/";
        public string SmallImagesContainerUrl => StorageBaseUrl + BlobContainers.ScaledSmall + "/";
        public string ExifContainerUrl => StorageBaseUrl + BlobContainers.Exif + "/";
        public string CognitiveServicesContainerUrl => StorageBaseUrl + BlobContainers.CognitiveServices + "/";
        public string LargeColorMatrixContainerUrl => StorageBaseUrl + BlobContainers.ColorMatrixLarge + "/";
        public string MediumColorMatrixContainerUrl => StorageBaseUrl + BlobContainers.ColorMatrixMedium + "/";
        public string SmallColorMatrixContainerUrl => StorageBaseUrl + BlobContainers.ColorMatrixSmall + "/";
    }
}
