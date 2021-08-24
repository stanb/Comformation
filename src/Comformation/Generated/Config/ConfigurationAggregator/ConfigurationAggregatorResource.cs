using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Config.ConfigurationAggregator
{
    /// <summary>
    /// AWS::Config::ConfigurationAggregator
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-configurationaggregator.html
    /// </summary>
    public class ConfigurationAggregatorResource : ResourceBase
    {
        public class ConfigurationAggregatorProperties
        {
            /// <summary>
            /// AccountAggregationSources
            /// 		
            /// Provides a list of source accounts and regions to be 			aggregated.
            /// 	
            /// Required: No
            /// Type: List of AccountAggregationSource
            /// Maximum: 1
            /// Update requires: No interruption
            /// </summary>
            public List<AccountAggregationSource> AccountAggregationSources { get; set; }

            /// <summary>
            /// ConfigurationAggregatorName
            /// 		
            /// The name of the aggregator.
            /// 	
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 256
            /// Pattern: [\w\-]+
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ConfigurationAggregatorName { get; set; }

            /// <summary>
            /// OrganizationAggregationSource
            /// 		
            /// Provides an organization and list of regions to be 			aggregated.
            /// 	
            /// Required: No
            /// Type: OrganizationAggregationSource
            /// Update requires: No interruption
            /// </summary>
            public OrganizationAggregationSource OrganizationAggregationSource { get; set; }

            /// <summary>
            /// Tags
            /// 		
            /// An array of tag object.
            /// 	
            /// Required: No
            /// Type: List of Tag
            /// Maximum: 50
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::Config::ConfigurationAggregator";

        public ConfigurationAggregatorProperties Properties { get; } = new ConfigurationAggregatorProperties();

    }

    public static class ConfigurationAggregatorAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ConfigurationAggregatorArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("ConfigurationAggregatorArn");
    }
}
