using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ImageBuilder.InfrastructureConfiguration
{
    /// <summary>
    /// AWS::ImageBuilder::InfrastructureConfiguration Logging
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-infrastructureconfiguration-logging.html
    /// </summary>
    public class Logging
    {

        /// <summary>
        /// S3Logs
        /// The Amazon S3 logging configuration.
        /// Required: No
        /// Type: S3Logs
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("S3Logs")]
        public S3Logs S3Logs { get; set; }

    }
}
