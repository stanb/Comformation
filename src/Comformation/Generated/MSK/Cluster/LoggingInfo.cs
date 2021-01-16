using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MSK.Cluster
{
    /// <summary>
    /// AWS::MSK::Cluster LoggingInfo
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-cluster-logginginfo.html
    /// </summary>
    public class LoggingInfo
    {

        /// <summary>
        /// BrokerLogs
        /// You can configure your MSK cluster to send broker logs to different destination types. This
        /// configuration specifies the details of these destinations.
        /// Required: Yes
        /// Type: BrokerLogs
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BrokerLogs")]
        public BrokerLogs BrokerLogs { get; set; }

    }
}
