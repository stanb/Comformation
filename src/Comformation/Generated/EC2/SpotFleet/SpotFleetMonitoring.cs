using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.SpotFleet
{
    /// <summary>
    /// Amazon EC2 SpotFleet Monitoring
    /// Monitoring is a property of the Amazon Elastic Compute Cloud SpotFleet LaunchSpecifications property that
    /// enables instance monitoring.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetrequestconfigdata-launchspecifications-monitoring.html
    /// </summary>
    public class SpotFleetMonitoring
    {

        /// <summary>
        /// Enabled
        /// Indicates whether monitoring is enabled for the instances.
        /// Required: No
        /// Type: Boolean
        /// </summary>
        [JsonProperty("Enabled")]
        public Union<bool, IntrinsicFunction> Enabled { get; set; }

    }
}
