using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.QuickSight.Dashboard
{
    /// <summary>
    /// AWS::QuickSight::Dashboard IntegerParameter
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-integerparameter.html
    /// </summary>
    public class IntegerParameter
    {

        /// <summary>
        /// Values
        /// The values for the integer parameter.
        /// Required: Yes
        /// Type: List of Double
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Values")]
        public List<Union<double, IntrinsicFunction>> Values { get; set; }

        /// <summary>
        /// Name
        /// The name of the integer parameter.
        /// Required: Yes
        /// Type: String
        /// Pattern: . *\S. *
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

    }
}
