using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ECR.Repository
{
    /// <summary>
    /// AWS::ECR::Repository ImageScanningConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecr-repository-imagescanningconfiguration.html
    /// </summary>
    public class ImageScanningConfiguration
    {

        /// <summary>
        /// ScanOnPush
        /// The setting that determines whether images are scanned after being pushed to a repository. If set to
        /// true, images will be scanned after being pushed. If this parameter is not specified, it will default
        /// to false and images will not be scanned unless a scan is manually started.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ScanOnPush")]
        public Union<bool, IntrinsicFunction> ScanOnPush { get; set; }

    }
}
