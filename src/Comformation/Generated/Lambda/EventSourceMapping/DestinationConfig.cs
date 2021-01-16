using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Lambda.EventSourceMapping
{
    /// <summary>
    /// AWS::Lambda::EventSourceMapping DestinationConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-eventsourcemapping-destinationconfig.html
    /// </summary>
    public class DestinationConfig
    {

        /// <summary>
        /// OnFailure
        /// The destination configuration for failed invocations.
        /// Required: No
        /// Type: OnFailure
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("OnFailure")]
        public OnFailure OnFailure { get; set; }

    }
}
