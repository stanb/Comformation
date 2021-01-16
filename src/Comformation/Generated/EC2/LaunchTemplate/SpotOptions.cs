using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.LaunchTemplate
{
    /// <summary>
    /// AWS::EC2::LaunchTemplate SpotOptions
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-launchtemplatedata-instancemarketoptions-spotoptions.html
    /// </summary>
    public class SpotOptions
    {

        /// <summary>
        /// SpotInstanceType
        /// The Spot Instance request type.
        /// 	
        /// If you are using Spot Instances with an Auto Scaling group, use one-time requests, as the Amazon EC2
        /// Auto Scaling 	 service handles requesting new Spot Instances whenever the group is below its desired
        /// capacity.
        /// Required: No
        /// Type: String
        /// Allowed values: one-time | persistent
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SpotInstanceType")]
        public Union<string, IntrinsicFunction> SpotInstanceType { get; set; }

        /// <summary>
        /// InstanceInterruptionBehavior
        /// The behavior when a Spot Instance is interrupted. The default is terminate.
        /// Required: No
        /// Type: String
        /// Allowed values: hibernate | stop | terminate
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

        /// <summary>
        /// BlockDurationMinutes
        /// The required duration for the Spot Instances (also known as Spot blocks), in minutes. This value
        /// must be a multiple of 60 (60, 120, 180, 240, 300, or 360).
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BlockDurationMinutes")]
        public Union<int, IntrinsicFunction> BlockDurationMinutes { get; set; }

        /// <summary>
        /// ValidUntil
        /// The end date of the request. For a one-time request, the request remains active until all instances
        /// launch, the request is canceled, or this date is reached. If the request is persistent, it remains
        /// active until it is canceled or this date and time is reached. The default end date is 7 days from
        /// the current date.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ValidUntil")]
        public Union<string, IntrinsicFunction> ValidUntil { get; set; }

    }
}
