using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Config.ConfigurationAggregator
{
    /// <summary>
    /// AWS::Config::ConfigurationAggregator
    /// The AWS::Config::ConfigurationAggregator resource is an AWS Config resource type that collects AWS Config data
    /// from multiple accounts and regions. Use an aggregator to view the resource configuration and compliance data
    /// recorded in AWS Config for multiple accounts and regions.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-configurationaggregator.html
    /// </summary>
    public class ConfigurationAggregatorResource : ResourceBase
    {
        public class ConfigurationAggregatorProperties
        {
            /// <summary>
            /// AccountAggregationSources
            /// A collection of accounts and regions.
            /// Required: No
            /// Type: List of AWS Config ConfigurationAggregator AccountAggregationSource property types
            /// Update requires: No interruption
            /// </summary>
			public Union<List<AccountAggregationSource>, IntrinsicFunction> AccountAggregationSources { get; set; }

            /// <summary>
            /// ConfigurationAggregatorName
            /// The name of the configuration aggregator.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ConfigurationAggregatorName { get; set; }

            /// <summary>
            /// OrganizationAggregationSource
            /// A collection of regions and IAM role to retrieve AWS Organizations details.
            /// Required: No
            /// Type: AWS Config ConfigurationAggregator OrganizationAggregationSource
            /// Update requires: No interruption
            /// </summary>
			public Union<OrganizationAggregationSource, IntrinsicFunction> OrganizationAggregationSource { get; set; }

        }
    
        public string Type { get; } = "AWS::Config::ConfigurationAggregator";
        
        public ConfigurationAggregatorProperties Properties { get; } = new ConfigurationAggregatorProperties();
    }
}
