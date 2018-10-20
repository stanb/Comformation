using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AmazonMQ.Broker
{
    /// <summary>
    /// Amazon MQ Broker LogsConfiguration
    /// The LogsConfiguration property type enables general or audit logging for an Amazon MQ broker.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amazonmq-broker-logsconfiguration.html
    /// </summary>
    public class LogList
    {

        /// <summary>
        /// Audit
        /// Enables audit logging. Every user management action made using JMS or the ActiveMQ Web Console is
        /// logged.
        /// Required: No
        /// Type: Boolean
        /// Update requires: Some interruptions
        /// </summary>
        [JsonProperty("Audit")]
        public Union<bool, IntrinsicFunction> Audit { get; set; }

        /// <summary>
        /// General
        /// Enables general logging.
        /// Required: No
        /// Type: Boolean
        /// Update requires: Some interruptions
        /// </summary>
        [JsonProperty("General")]
        public Union<bool, IntrinsicFunction> General { get; set; }

    }
}
