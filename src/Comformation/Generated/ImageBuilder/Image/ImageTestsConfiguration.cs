using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ImageBuilder.Image
{
    /// <summary>
    /// AWS::ImageBuilder::Image ImageTestsConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-image-imagetestsconfiguration.html
    /// </summary>
    public class ImageTestsConfiguration
    {

        /// <summary>
        /// ImageTestsEnabled
        /// Defines if tests should be executed when building this image.
        /// Required: No
        /// Type: Boolean
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("ImageTestsEnabled")]
        public Union<bool, IntrinsicFunction> ImageTestsEnabled { get; set; }

        /// <summary>
        /// TimeoutMinutes
        /// The maximum time in minutes that tests are permitted to run.
        /// Required: No
        /// Type: Integer
        /// Minimum: 60
        /// Maximum: 1440
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("TimeoutMinutes")]
        public Union<int, IntrinsicFunction> TimeoutMinutes { get; set; }

    }
}
