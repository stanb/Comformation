using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.QuickSight.Dashboard
{
    /// <summary>
    /// Missing documentation http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-exporttocsvoption.html
    /// </summary>
    public class ExportToCSVOption
    {

        /// <summary>
        /// AvailabilityStatus
        /// </summary>
        [JsonProperty("AvailabilityStatus")]
        public Union<string, IntrinsicFunction> AvailabilityStatus { get; set; }

    }
}
