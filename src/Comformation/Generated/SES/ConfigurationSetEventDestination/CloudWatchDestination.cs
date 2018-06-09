using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SES.ConfigurationSetEventDestination
{
    /// <summary>
    /// Amazon Simple Email Service ConfigurationSetEventDestination CloudWatchDestination
    /// The CloudWatchDestination property type specifies information associated with an CloudWatch event destination
    /// to which email sending events are published in Amazon SES.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-configurationseteventdestination-cloudwatchdestination.html
    /// </summary>
    public class CloudWatchDestination
    {

        /// <summary>
        /// DimensionConfigurations
        /// A list of dimensions upon which to categorize your emails when you publish email sending events to
        /// CloudWatch.
        /// Required: No
        /// Type: List of Amazon SES ConfigurationSetEventDestination DimensionConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DimensionConfigurations")]
        public Union<List<DimensionConfiguration>, IntrinsicFunction> DimensionConfigurations { get; set; }

    }
}
