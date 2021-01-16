using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.NetworkFirewall.LoggingConfiguration
{
    /// <summary>
    /// AWS::NetworkFirewall::LoggingConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkfirewall-loggingconfiguration.html
    /// </summary>
    public class LoggingConfigurationResource : ResourceBase
    {
        public class LoggingConfigurationProperties
        {
            /// <summary>
            /// FirewallName
            /// The name of the firewall that the logging configuration is associated with. You can&#39;t change the
            /// firewall specification after you create the logging configuration.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> FirewallName { get; set; }

            /// <summary>
            /// FirewallArn
            /// The Amazon Resource Name (ARN) of the AWS::NetworkFirewall::Firewall that the logging configuration
            /// is associated with. You can&#39;t change the firewall specification after you create the logging
            /// configuration.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> FirewallArn { get; set; }

            /// <summary>
            /// LoggingConfiguration
            /// Defines how AWS Network Firewall performs logging for a AWS::NetworkFirewall::Firewall.
            /// Required: Yes
            /// Type: LoggingConfiguration
            /// Update requires: No interruption
            /// </summary>
            public LoggingConfiguration LoggingConfiguration { get; set; }

        }

        public string Type { get; } = "AWS::NetworkFirewall::LoggingConfiguration";

        public LoggingConfigurationProperties Properties { get; } = new LoggingConfigurationProperties();

    }
}
