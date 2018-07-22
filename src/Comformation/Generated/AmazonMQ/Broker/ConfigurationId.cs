using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AmazonMQ.Broker
{
    /// <summary>
    /// Amazon MQ Broker ConfigurationId
    /// The ConfigurationId property type specifies the unique ID that Amazon MQ generates for the configuration.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amazonmq-broker-configurationid.html
    /// </summary>
    public class ConfigurationId
    {

        /// <summary>
        /// Revision
        /// The revision number of the configuration.
        /// Required: Yes
        /// Type: Integer
        /// Update requires: Some interruptions
        /// </summary>
        [JsonProperty("Revision")]
        public Union<int, IntrinsicFunction> Revision { get; set; }

        /// <summary>
        /// Id
        /// The unique ID that Amazon MQ generates for the configuration.
        /// Required: Yes
        /// Type: String
        /// Update requires: Some interruptions
        /// </summary>
        [JsonProperty("Id")]
        public Union<string, IntrinsicFunction> Id { get; set; }

    }
}