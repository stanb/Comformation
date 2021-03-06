using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Config.ConfigurationAggregator
{
    /// <summary>
    /// AWS::Config::ConfigurationAggregator AccountAggregationSource
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-configurationaggregator-accountaggregationsource.html
    /// </summary>
    public class AccountAggregationSource
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
        /// AccountIds
        /// 		
        /// The 12-digit account ID of the account being aggregated. 		
        /// 	
        /// Required: Yes
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AccountIds")]
        public List<Union<string, IntrinsicFunction>> AccountIds { get; set; }

    }
}
