using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ImageBuilder.DistributionConfiguration
{
    /// <summary>
    /// AWS::ImageBuilder::DistributionConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-imagebuilder-distributionconfiguration.html
    /// </summary>
    public class DistributionConfigurationResource : ResourceBase
    {
        public class DistributionConfigurationProperties
        {
            /// <summary>
            /// Name
            /// The name of this distribution configuration.
            /// Required: Yes
            /// Type: String
            /// Pattern: ^[-_A-Za-z-0-9][-_A-Za-z0-9 ]{1,126}[-_A-Za-z-0-9]$
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// Description
            /// The description of this distribution configuration.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 1024
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// Distributions
            /// The distributions of this distribution configuration formatted as an array of Distribution objects.
            /// Required: Yes
            /// Type: List of Distribution
            /// Update requires: No interruption
            /// </summary>
            public List<Distribution> Distributions { get; set; }

            /// <summary>
            /// Tags
            /// The tags of this distribution configuration.
            /// Required: No
            /// Type: Map of String
            /// Update requires: No interruption
            /// </summary>
            public Dictionary<string, Union<string, IntrinsicFunction>> Tags { get; set; }

        }

        public string Type { get; } = "AWS::ImageBuilder::DistributionConfiguration";

        public DistributionConfigurationProperties Properties { get; } = new DistributionConfigurationProperties();

    }

    public static class DistributionConfigurationAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
    }
}
