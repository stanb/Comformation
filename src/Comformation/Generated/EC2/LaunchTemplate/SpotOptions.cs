using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.LaunchTemplate
{
    /// <summary>
    /// AWS::EC2::LaunchTemplate SpotOptions
    /// Specifies options for Spot instances.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-launchtemplatedata-instancemarketoptions-spotoptions.html
    /// </summary>
    public class SpotOptions
    {

        /// <summary>
        /// SpotInstanceType
        /// The Spot Instance request type.
        /// Required: No
        /// Type: String
        /// Allowed Values: one-time | persistent
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SpotInstanceType")]
        public Union<string, IntrinsicFunction> SpotInstanceType { get; set; }

        /// <summary>
        /// InstanceInterruptionBehavior
        /// The behavior when a Spot Instance is interrupted. The default is terminate.
        /// Required: No
        /// Type: String
        /// Allowed Values: hibernate | stop | terminate
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
