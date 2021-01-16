using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.QuickSight.Dashboard
{
    /// <summary>
    /// Missing documentation http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dashboard-adhocfilteringoption.html
    /// </summary>
    public class AdHocFilteringOption
    {

        /// <summary>
        /// AvailabilityStatus
        /// </summary>
        [JsonProperty("AvailabilityStatus")]
        public Union<string, IntrinsicFunction> AvailabilityStatus { get; set; }

    }
}
