using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.QuickSight.Dashboard
{
    /// <summary>
    /// AWS::QuickSight::Dashboard DateTimeParameter
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-datetimeparameter.html
    /// </summary>
    public class DateTimeParameter
    {

        /// <summary>
        /// Values
        /// The values for the date-time parameter.
        /// Required: Yes
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Values")]
        public List<Union<string, IntrinsicFunction>> Values { get; set; }

        /// <summary>
        /// Name
        /// A display name for the date-time parameter.
        /// Required: Yes
        /// Type: String
        /// Pattern: . *\S. *
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

    }
}
