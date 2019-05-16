using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SES.ConfigurationSetEventDestination
{
    /// <summary>
    /// AWS::SES::ConfigurationSetEventDestination CloudWatchDestination
    /// Contains information associated with an Amazon CloudWatch event destination to which email sending events are
    /// published.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-configurationseteventdestination-cloudwatchdestination.html
    /// </summary>
    public class CloudWatchDestination
    {

        /// <summary>
        /// DimensionConfigurations
        /// A list of dimensions upon which to categorize your emails when you publish email sending events to
        /// Amazon CloudWatch.
        /// Required: No
        /// Type: List of DimensionConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DimensionConfigurations")]
        public List<DimensionConfiguration> DimensionConfigurations { get; set; }

    }
}
