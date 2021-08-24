using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.QuickSight.Dashboard
{
    /// <summary>
    /// AWS::QuickSight::Dashboard Parameters
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-parameters.html
    /// </summary>
    public class Parameters
    {

        /// <summary>
        /// StringParameters
        /// String parameters.
        /// Required: No
        /// Type: List of StringParameter
        /// Maximum: 100
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("StringParameters")]
        public List<StringParameter> StringParameters { get; set; }

        /// <summary>
        /// DecimalParameters
        /// Decimal parameters.
        /// Required: No
        /// Type: List of DecimalParameter
        /// Maximum: 100
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DecimalParameters")]
        public List<DecimalParameter> DecimalParameters { get; set; }

        /// <summary>
        /// IntegerParameters
        /// Integer parameters.
        /// Required: No
        /// Type: List of IntegerParameter
        /// Maximum: 100
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IntegerParameters")]
        public List<IntegerParameter> IntegerParameters { get; set; }

        /// <summary>
        /// DateTimeParameters
        /// Date-time parameters.
        /// Required: No
        /// Type: List of DateTimeParameter
        /// Maximum: 100
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DateTimeParameters")]
        public List<DateTimeParameter> DateTimeParameters { get; set; }

    }
}
