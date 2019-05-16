using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AmazonMQ.Broker
{
    /// <summary>
    /// AWS::AmazonMQ::Broker LogList
    /// The list of information about logs to be enabled for the specified broker.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amazonmq-broker-loglist.html
    /// </summary>
    public class LogList
    {

        /// <summary>
        /// Audit
        /// Enables audit logging. Every user management action made using JMX or the ActiveMQ Web Console is
        /// logged.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Audit")]
        public Union<bool, IntrinsicFunction> Audit { get; set; }

        /// <summary>
        /// General
        /// Enables general logging.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("General")]
        public Union<bool, IntrinsicFunction> General { get; set; }

    }
}
