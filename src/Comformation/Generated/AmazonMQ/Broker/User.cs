using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AmazonMQ.Broker
{
    /// <summary>
    /// AWS::AmazonMQ::Broker User
    /// The list of ActiveMQ users (persons or applications) who can access queues and topics. This value can contain
    /// only alphanumeric characters, dashes, periods, underscores, and tildes (- . _ ~). This value must be 2-100
    /// characters long.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amazonmq-broker-user.html
    /// </summary>
    public class User
    {

        /// <summary>
        /// Username
        /// The username of the ActiveMQ user. This value can contain only alphanumeric characters, dashes,
        /// periods, underscores, and tildes (- . _ ~). This value must be 2-100 characters long.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Username")]
        public Union<string, IntrinsicFunction> Username { get; set; }

        /// <summary>
        /// Groups
        /// The list of groups (20 maximum) to which the ActiveMQ user belongs. This value can contain only
        /// alphanumeric characters, dashes, periods, underscores, and tildes (- . _ ~). This value must be
        /// 2-100 characters long.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Groups")]
        public List<Union<string, IntrinsicFunction>> Groups { get; set; }

        /// <summary>
        /// ConsoleAccess
        /// Enables access to the the ActiveMQ Web Console for the ActiveMQ user.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ConsoleAccess")]
        public Union<bool, IntrinsicFunction> ConsoleAccess { get; set; }

        /// <summary>
        /// Password
        /// The password of the ActiveMQ user. This value must be at least 12 characters long, must contain at
        /// least 4 unique characters, and must not contain commas.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Password")]
        public Union<string, IntrinsicFunction> Password { get; set; }

    }
}
