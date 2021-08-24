using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppFlow.Flow
{
    /// <summary>
    /// AWS::AppFlow::Flow LookoutMetricsDestinationProperties
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-lookoutmetricsdestinationproperties.html
    /// </summary>
    public class LookoutMetricsDestinationProperties
    {

        /// <summary>
        /// Object
        /// The object specified in the Amazon Lookout for Metrics flow destination.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Object")]
        public Union<string, IntrinsicFunction> Object { get; set; }

    }
}
