using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.AmazonMQ.ConfigurationAssociation
{
    /// <summary>
    /// AWS::AmazonMQ::ConfigurationAssociation
    /// Use the AWS CloudFormation AWS::AmazonMQ::ConfigurationAssociation resource to associate a Configuration with
    /// a Broker, or return information about the specified configurationassociation. Only use one per broker, and
    /// don&#39;t use a configuration on the broker resource if you have associated a configuration with that broker.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amazonmq-configurationassociation.html
    /// </summary>
    public class ConfigurationAssociationResource : ResourceBase
    {
        public class ConfigurationAssociationProperties
        {
            /// <summary>
            /// Broker
            /// The broker to associate with a configuration.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Broker { get; set; }

            /// <summary>
            /// Configuration
            /// The configuration to associate with a broker.
            /// Required: Yes
            /// Type: ConfigurationId
            /// Update requires: No interruption
            /// </summary>
			public ConfigurationId Configuration { get; set; }

        }

        public string Type { get; } = "AWS::AmazonMQ::ConfigurationAssociation";

        public ConfigurationAssociationProperties Properties { get; } = new ConfigurationAssociationProperties();

    }
}
