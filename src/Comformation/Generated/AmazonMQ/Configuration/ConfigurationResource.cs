using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.AmazonMQ.Configuration
{
    /// <summary>
    /// AWS::AmazonMQ::Configuration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amazonmq-configuration.html
    /// </summary>
    public class ConfigurationResource : ResourceBase
    {
        public class ConfigurationProperties
        {
            /// <summary>
            /// EngineVersion
            /// The version of the broker engine. For a list of supported engine versions, see https://docs. aws.
            /// amazon. com/amazon-mq/latest/developer-guide/broker-engine. html
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> EngineVersion { get; set; }

            /// <summary>
            /// Description
            /// The description of the configuration.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// AuthenticationStrategy
            /// Optional. The authentication strategy associated with the configuration. The default is SIMPLE.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> AuthenticationStrategy { get; set; }

            /// <summary>
            /// EngineType
            /// The type of broker engine. Note: Currently, Amazon MQ only supports ACTIVEMQ for creating and
            /// editing broker configurations.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> EngineType { get; set; }

            /// <summary>
            /// Data
            /// The base64-encoded XML configuration.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Data { get; set; }

            /// <summary>
            /// Tags
            /// Create tags when creating the configuration.
            /// Required: No
            /// Type: List of TagsEntry
            /// Update requires: No interruption
            /// </summary>
            public List<TagsEntry> Tags { get; set; }

            /// <summary>
            /// Name
            /// The name of the configuration. This value can contain only alphanumeric characters, dashes, periods,
            /// underscores, and tildes (- . _ ~). This value must be 1-150 characters long.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

        }

        public string Type { get; } = "AWS::AmazonMQ::Configuration";

        public ConfigurationProperties Properties { get; } = new ConfigurationProperties();

    }

    public static class ConfigurationAttributes
    {
        public static readonly ResourceAttribute<Union<int, IntrinsicFunction>> Revision = new ResourceAttribute<Union<int, IntrinsicFunction>>("Revision");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Id = new ResourceAttribute<Union<string, IntrinsicFunction>>("Id");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
    }
}
