using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.PinpointEmail.ConfigurationSetEventDestination
{
    /// <summary>
    /// AWS::PinpointEmail::ConfigurationSetEventDestination CloudWatchDestination
    /// An object that defines an Amazon CloudWatch destination for email events. You can use Amazon CloudWatch to
    /// monitor and gain insights on your email sending metrics.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpointemail-configurationseteventdestination-cloudwatchdestination.html
    /// </summary>
    public class CloudWatchDestination
    {

        /// <summary>
        /// DimensionConfigurations
        /// An array of objects that define the dimensions to use when you send email events to Amazon
        /// CloudWatch.
        /// Required: No
        /// Type: List of DimensionConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DimensionConfigurations")]
        public List<DimensionConfiguration> DimensionConfigurations { get; set; }

    }
}
