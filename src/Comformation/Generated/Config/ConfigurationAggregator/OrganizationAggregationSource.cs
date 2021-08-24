using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Config.ConfigurationAggregator
{
    /// <summary>
    /// AWS::Config::ConfigurationAggregator OrganizationAggregationSource
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-configurationaggregator-organizationaggregationsource.html
    /// </summary>
    public class OrganizationAggregationSource
    {

        /// <summary>
        /// AllAwsRegions
        /// 		
        /// If true, aggregate existing AWS Config regions and future 			regions.
        /// 	
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AllAwsRegions")]
        public Union<bool, IntrinsicFunction> AllAwsRegions { get; set; }

        /// <summary>
        /// AwsRegions
        /// 		
        /// The source regions being aggregated.
        /// 	
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AwsRegions")]
        public List<Union<string, IntrinsicFunction>> AwsRegions { get; set; }

        /// <summary>
        /// RoleArn
        /// ARN of the IAM role used to retrieve AWS Organizations details 			associated with the aggregator
        /// account.
        /// 	
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RoleArn")]
        public Union<string, IntrinsicFunction> RoleArn { get; set; }

    }
}
