using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Config.ConfigurationAggregator
{
    /// <summary>
    /// AWS Config ConfigurationAggregator OrganizationAggregationSource
    /// The OrganizationAggregationSource property type specifies the regions of AWS Config data to aggregate into an
    /// AWS Config configuration aggregator and the IAM role to use to retrieve AWS Organizations details.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-configurationaggregator-organizationaggregationsource.html
    /// </summary>
    public class OrganizationAggregationSource
    {

        /// <summary>
        /// AllAwsRegions
        /// If true aggreagate existing AWS Config regions and future regions.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AllAwsRegions")]
        public Union<bool, IntrinsicFunction> AllAwsRegions { get; set; }

        /// <summary>
        /// AwsRegions
        /// The source regions being aggregated.
        /// Required: No
        /// Type: List of String values
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AwsRegions")]
        public List<Union<string, IntrinsicFunction>> AwsRegions { get; set; }

        /// <summary>
        /// RoleArn
        /// The Amazon Resource Name (ARN) of the IAM role used to retreive AWS Organizations details associated
        /// with the aggregator account.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RoleArn")]
        public Union<string, IntrinsicFunction> RoleArn { get; set; }

    }
}
