using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.QuickSight.Dashboard
{
    /// <summary>
    /// AWS::QuickSight::Dashboard ExportToCSVOption
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-exporttocsvoption.html
    /// </summary>
    public class ExportToCSVOption
    {

        /// <summary>
        /// AvailabilityStatus
        /// Availability status.
        /// Required: No
        /// Type: String
        /// Allowed values: DISABLED | ENABLED
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AvailabilityStatus")]
        public Union<string, IntrinsicFunction> AvailabilityStatus { get; set; }

    }
}
