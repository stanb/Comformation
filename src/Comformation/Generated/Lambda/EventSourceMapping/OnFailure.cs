using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Lambda.EventSourceMapping
{
    /// <summary>
    /// AWS::Lambda::EventSourceMapping OnFailure
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-eventsourcemapping-onfailure.html
    /// </summary>
    public class OnFailure
    {

        /// <summary>
        /// Destination
        /// The Amazon Resource Name (ARN) of the destination resource.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Destination")]
        public Union<string, IntrinsicFunction> Destination { get; set; }

    }
}
