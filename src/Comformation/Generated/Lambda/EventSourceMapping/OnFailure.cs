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
        /// Minimum: 0
        /// Maximum: 350
        /// Pattern: ^$|arn:(aws[a-zA-Z0-9-]*):([a-zA-Z0-9\-])+:([a-z]{2}(-gov)?-[a-z]+-\d{1})?:(\d{12})?:(. *)
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Destination")]
        public Union<string, IntrinsicFunction> Destination { get; set; }

    }
}
