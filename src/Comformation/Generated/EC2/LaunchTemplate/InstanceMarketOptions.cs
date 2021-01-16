using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.LaunchTemplate
{
    /// <summary>
    /// AWS::EC2::LaunchTemplate InstanceMarketOptions
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-launchtemplatedata-instancemarketoptions.html
    /// </summary>
    public class InstanceMarketOptions
    {

        /// <summary>
        /// SpotOptions
        /// The options for Spot Instances.
        /// Required: No
        /// Type: SpotOptions
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SpotOptions")]
        public SpotOptions SpotOptions { get; set; }

        /// <summary>
        /// MarketType
        /// The market type.
        /// Required: Conditional
        /// Type: String
        /// Allowed values: spot
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MarketType")]
        public Union<string, IntrinsicFunction> MarketType { get; set; }

    }
}
