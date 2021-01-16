using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppFlow.Flow
{
    /// <summary>
    /// AWS::AppFlow::Flow SalesforceDestinationProperties
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-salesforcedestinationproperties.html
    /// </summary>
    public class SalesforceDestinationProperties
    {

        /// <summary>
        /// Object
        /// The object specified in the Salesforce flow destination.
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
        /// The settings that determine how Amazon AppFlow handles an error when placing data in the Salesforce
        /// destination. For example, this setting would determine if the flow should fail after one insertion
        /// error, or continue and attempt to insert every record regardless of the initial failure.
        /// ErrorHandlingConfig is a part of the destination connector details.
        /// Required: No
        /// Type: ErrorHandlingConfig
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ErrorHandlingConfig")]
        public ErrorHandlingConfig ErrorHandlingConfig { get; set; }

    }
}
