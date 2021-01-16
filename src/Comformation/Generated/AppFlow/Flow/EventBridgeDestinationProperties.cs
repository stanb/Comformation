using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppFlow.Flow
{
    /// <summary>
    /// AWS::AppFlow::Flow EventBridgeDestinationProperties
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-eventbridgedestinationproperties.html
    /// </summary>
    public class EventBridgeDestinationProperties
    {

        /// <summary>
        /// Object
        /// The object specified in the Amazon EventBridge flow destination.
        /// Required: Yes
        /// Type: String
        /// Maximum: 512
        /// Pattern: \S+
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Object")]
        public Union<string, IntrinsicFunction> Object { get; set; }

        /// <summary>
        /// ErrorHandlingConfig
        /// The object specified in the Amplitude flow source.
        /// Required: No
        /// Type: ErrorHandlingConfig
        /// Maximum: 512
        /// Pattern: \S+
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ErrorHandlingConfig")]
        public ErrorHandlingConfig ErrorHandlingConfig { get; set; }

    }
}
