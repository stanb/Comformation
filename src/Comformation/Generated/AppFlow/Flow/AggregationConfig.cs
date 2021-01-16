using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppFlow.Flow
{
    /// <summary>
    /// AWS::AppFlow::Flow AggregationConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-aggregationconfig.html
    /// </summary>
    public class AggregationConfig
    {

        /// <summary>
        /// AggregationType
        /// Specifies whether Amazon AppFlow aggregates the flow records into a single file, or leave them
        /// unaggregated.
        /// Required: No
        /// Type: String
        /// Allowed values: None | SingleFile
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AggregationType")]
        public Union<string, IntrinsicFunction> AggregationType { get; set; }

    }
}
