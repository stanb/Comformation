using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel CdiInputSpecification
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-cdiinputspecification.html
    /// </summary>
    public class CdiInputSpecification
    {

        /// <summary>
        /// Resolution
        /// Maximum CDI input resolution
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Resolution")]
        public Union<string, IntrinsicFunction> Resolution { get; set; }

    }
}
