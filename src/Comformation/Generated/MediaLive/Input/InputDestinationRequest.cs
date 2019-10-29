using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Input
{
    /// <summary>
    /// AWS::MediaLive::Input InputDestinationRequest
    /// The settings for a push input, to set up the destination addresses on MediaLive.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-inputdestinationrequest.html
    /// </summary>
    public class InputDestinationRequest
    {

        /// <summary>
        /// StreamName
        /// The stream name (application name/application instance) for the location the RTMP source content
        /// will be pushed to in MediaLive.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("StreamName")]
        public Union<string, IntrinsicFunction> StreamName { get; set; }

    }
}
