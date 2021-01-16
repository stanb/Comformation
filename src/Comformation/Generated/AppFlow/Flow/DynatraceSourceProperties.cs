using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppFlow.Flow
{
    /// <summary>
    /// AWS::AppFlow::Flow DynatraceSourceProperties
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-dynatracesourceproperties.html
    /// </summary>
    public class DynatraceSourceProperties
    {

        /// <summary>
        /// Object
        /// The object specified in the Dynatrace flow source.
        /// Required: Yes
        /// Type: String
        /// Maximum: 512
        /// Pattern: \S+
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Object")]
        public Union<string, IntrinsicFunction> Object { get; set; }

    }
}
