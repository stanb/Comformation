using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Input
{
    /// <summary>
    /// AWS::MediaLive::Input MediaConnectFlowRequest
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-mediaconnectflowrequest.html
    /// </summary>
    public class MediaConnectFlowRequest
    {

        /// <summary>
        /// FlowArn
        /// The ARN of one or two MediaConnect flows that are the sources for this MediaConnect input.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FlowArn")]
        public Union<string, IntrinsicFunction> FlowArn { get; set; }

    }
}
