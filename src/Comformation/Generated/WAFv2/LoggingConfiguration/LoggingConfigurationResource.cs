using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.WAFv2.LoggingConfiguration
{
    /// <summary>
    /// AWS::WAFv2::LoggingConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafv2-loggingconfiguration.html
    /// </summary>
    public class LoggingConfigurationResource : ResourceBase
    {
        public class LoggingConfigurationProperties
        {
            /// <summary>
            /// ResourceArn
            /// The Amazon Resource Name (ARN) of the web ACL that you want to associate with LogDestinationConfigs.
            /// Required: Yes
            /// Type: String
            /// Minimum: 20
            /// Maximum: 2048
            /// Pattern: . *\S. *
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ResourceArn { get; set; }

            /// <summary>
            /// LogDestinationConfigs
            /// The Amazon Kinesis Data Firehose Amazon Resource Name (ARNs) that you want to associate with the web
            /// ACL.
            /// Required: Yes
            /// Type: List of String
            /// Maximum: 100
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> LogDestinationConfigs { get; set; }

            /// <summary>
            /// RedactedFields
            /// The parts of the request that you want to keep out of the logs. For example, if you redact the
            /// SingleHeader field, the HEADER field in the firehose will be xxx.
            /// Note You can specify only the following fields for redaction: UriPath, QueryString, SingleHeader,
            /// Method, and JsonBody.
            /// Required: No
            /// Type: List of FieldToMatch
            /// Maximum: 100
            /// Update requires: No interruption
            /// </summary>
            public List<FieldToMatch> RedactedFields { get; set; }

            /// <summary>
            /// LoggingFilter
            /// Filtering that specifies which web requests are kept in the logs and which are dropped. You can
            /// filter on the rule action and on the web request labels that were applied by matching rules during
            /// web ACL evaluation.
            /// Required: No
            /// Type: Json
            /// Update requires: No interruption
            /// </summary>
            public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> LoggingFilter { get; set; }

        }

        public string Type { get; } = "AWS::WAFv2::LoggingConfiguration";

        public LoggingConfigurationProperties Properties { get; } = new LoggingConfigurationProperties();

    }

    public static class LoggingConfigurationAttributes
    {
        public static readonly ResourceAttribute<Union<bool, IntrinsicFunction>> ManagedByFirewallManager = new ResourceAttribute<Union<bool, IntrinsicFunction>>("ManagedByFirewallManager");
    }
}
