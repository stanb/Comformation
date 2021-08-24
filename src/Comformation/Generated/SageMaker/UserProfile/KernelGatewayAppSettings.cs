using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SageMaker.UserProfile
{
    /// <summary>
    /// AWS::SageMaker::UserProfile KernelGatewayAppSettings
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-kernelgatewayappsettings.html
    /// </summary>
    public class KernelGatewayAppSettings
    {

        /// <summary>
        /// CustomImages
        /// A list of custom SageMaker images that are configured to run as a KernelGateway app.
        /// Required: No
        /// Type: List of CustomImage
        /// Maximum: 30
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CustomImages")]
        public List<CustomImage> CustomImages { get; set; }

        /// <summary>
        /// DefaultResourceSpec
        /// The default instance type and the Amazon Resource Name (ARN) of the default SageMaker image used by
        /// the KernelGateway app.
        /// Required: No
        /// Type: ResourceSpec
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DefaultResourceSpec")]
        public ResourceSpec DefaultResourceSpec { get; set; }

    }
}
