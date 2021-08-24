using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SageMaker.UserProfile
{
    /// <summary>
    /// AWS::SageMaker::UserProfile CustomImage
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-customimage.html
    /// </summary>
    public class CustomImage
    {

        /// <summary>
        /// AppImageConfigName
        /// The name of the AppImageConfig.
        /// Required: Yes
        /// Type: String
        /// Maximum: 63
        /// Pattern: ^[a-zA-Z0-9](-*[a-zA-Z0-9]){0,62}
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AppImageConfigName")]
        public Union<string, IntrinsicFunction> AppImageConfigName { get; set; }

        /// <summary>
        /// ImageName
        /// The name of the CustomImage. Must be unique to your account.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 63
        /// Pattern: ^[a-zA-Z0-9]([-. ]?[a-zA-Z0-9]){0,62}$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ImageName")]
        public Union<string, IntrinsicFunction> ImageName { get; set; }

        /// <summary>
        /// ImageVersionNumber
        /// The version number of the CustomImage.
        /// Required: No
        /// Type: Integer
        /// Minimum: 0
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ImageVersionNumber")]
        public Union<int, IntrinsicFunction> ImageVersionNumber { get; set; }

    }
}
