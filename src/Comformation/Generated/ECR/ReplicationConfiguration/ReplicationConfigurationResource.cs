using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ECR.ReplicationConfiguration
{
    /// <summary>
    /// AWS::ECR::ReplicationConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecr-replicationconfiguration.html
    /// </summary>
    public class ReplicationConfigurationResource : ResourceBase
    {
        public class ReplicationConfigurationProperties
        {
            /// <summary>
            /// ReplicationConfiguration
            /// The replication configuration for a registry.
            /// Required: Yes
            /// Type: ReplicationConfiguration
            /// Update requires: No interruption
            /// </summary>
            public ReplicationConfiguration ReplicationConfiguration { get; set; }

        }

        public string Type { get; } = "AWS::ECR::ReplicationConfiguration";

        public ReplicationConfigurationProperties Properties { get; } = new ReplicationConfigurationProperties();

    }

    public static class ReplicationConfigurationAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> RegistryId = new ResourceAttribute<Union<string, IntrinsicFunction>>("RegistryId");
    }
}
