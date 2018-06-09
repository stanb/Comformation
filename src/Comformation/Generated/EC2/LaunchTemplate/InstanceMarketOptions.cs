using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.LaunchTemplate
{
    /// <summary>
    /// Amazon EC2 LaunchTemplate InstanceMarketOptions
    /// The InstanceMarketOptions property type specifies market (purchasing) option for instances in an Amazon EC2
    /// launch template.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-instancemarketoptions.html
    /// </summary>
    public class InstanceMarketOptions
    {

        /// <summary>
        /// SpotOptions
        /// The options for Spot Instances.
        /// Required: No
        /// Type: Amazon EC2 LaunchTemplate SpotOptions
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SpotOptions")]
        public Union<SpotOptions, IntrinsicFunction> SpotOptions { get; set; }

        /// <summary>
        /// MarketType
        /// The market type.
        /// Valid values include: spot
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MarketType")]
        public Union<string, IntrinsicFunction> MarketType { get; set; }

    }
}
