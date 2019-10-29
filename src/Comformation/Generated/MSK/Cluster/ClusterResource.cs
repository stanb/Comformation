using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.MSK.Cluster
{
    /// <summary>
    /// AWS::MSK::Cluster
    /// The AWS::MSK::Cluster resource creates an Amazon MSK cluster. For more information, see What Is Amazon MSK? in
    /// the Amazon MSK Developer Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-msk-cluster.html
    /// </summary>
    public class ClusterResource : ResourceBase
    {
        public class ClusterProperties
        {
            /// <summary>
            /// BrokerNodeGroupInfo
            /// The setup to be used for brokers in the cluster.
            /// Required: Yes
            /// Type: BrokerNodeGroupInfo
            /// Update requires: Replacement
            /// </summary>
			public BrokerNodeGroupInfo BrokerNodeGroupInfo { get; set; }

            /// <summary>
            /// EnhancedMonitoring
            /// Specifies the level of monitoring for the MSK cluster. The possible values are DEFAULT, PER_BROKER,
            /// and PER_TOPIC_PER_BROKER.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> EnhancedMonitoring { get; set; }

            /// <summary>
            /// KafkaVersion
            /// The version of Apache Kafka.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> KafkaVersion { get; set; }

            /// <summary>
            /// NumberOfBrokerNodes
            /// The number of broker nodes you want in the Amazon MSK cluster. You can submit an update to increase
            /// the number of broker nodes in a cluster.
            /// Required: Yes
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
			public Union<int, IntrinsicFunction> NumberOfBrokerNodes { get; set; }

            /// <summary>
            /// EncryptionInfo
            /// Includes all encryption-related information.
            /// Required: No
            /// Type: EncryptionInfo
            /// Update requires: Replacement
            /// </summary>
			public EncryptionInfo EncryptionInfo { get; set; }

            /// <summary>
            /// ClusterName
            /// The name of the cluster.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ClusterName { get; set; }

            /// <summary>
            /// ClientAuthentication
            /// Includes information related to client authentication.
            /// Required: No
            /// Type: ClientAuthentication
            /// Update requires: Replacement
            /// </summary>
			public ClientAuthentication ClientAuthentication { get; set; }

            /// <summary>
            /// Tags
            /// A map of key:value pairs to apply to this resource. Both key and value are of type String.
            /// Required: No
            /// Type: Map
            /// Update requires: Replacement
            /// </summary>
			public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Tags { get; set; }

            /// <summary>
            /// ConfigurationInfo
            /// The Amazon MSK configuration to use for the cluster.
            /// Required: No
            /// Type: ConfigurationInfo
            /// Update requires: Replacement
            /// </summary>
			public ConfigurationInfo ConfigurationInfo { get; set; }

        }

        public string Type { get; } = "AWS::MSK::Cluster";

        public ClusterProperties Properties { get; } = new ClusterProperties();

    }
}
