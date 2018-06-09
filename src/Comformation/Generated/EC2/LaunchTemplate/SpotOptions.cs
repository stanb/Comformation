using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.LaunchTemplate
{
    /// <summary>
    /// Amazon EC2 LaunchTemplate SpotOptions
    /// The SpotOptions property type specifies the options for Spot Instances in an Amazon EC2 launch template.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-spotoptions.html
    /// </summary>
    public class SpotOptions
    {

        /// <summary>
        /// SpotInstanceType
        /// The Spot Instance request type.
        /// Valid values include: one-time and persistent.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SpotInstanceType")]
        public Union<string, IntrinsicFunction> SpotInstanceType { get; set; }

        /// <summary>
        /// InstanceInterruptionBehavior
        /// The behavior when a Spot Instance is interrupted. The default is terminate.
        /// Valid values include: hibernate, stop, and terminate.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("InstanceInterruptionBehavior")]
        public Union<string, IntrinsicFunction> InstanceInterruptionBehavior { get; set; }

        /// <summary>
        /// MaxPrice
        /// The maximum hourly price you&#39;re willing to pay for the Spot Instances.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MaxPrice")]
        public Union<string, IntrinsicFunction> MaxPrice { get; set; }

    }
}
