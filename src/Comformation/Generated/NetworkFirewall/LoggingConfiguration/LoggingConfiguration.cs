using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.NetworkFirewall.LoggingConfiguration
{
    /// <summary>
    /// AWS::NetworkFirewall::LoggingConfiguration LoggingConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-loggingconfiguration-loggingconfiguration.html
    /// </summary>
    public class LoggingConfiguration
    {

        /// <summary>
        /// LogDestinationConfigs
        /// Defines the logging destinations for the logs for a firewall. Network Firewall generates logs for
        /// stateful rule groups.
        /// Required: Yes
        /// Type: List of LogDestinationConfig
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LogDestinationConfigs")]
        public List<LogDestinationConfig> LogDestinationConfigs { get; set; }

    }
}
