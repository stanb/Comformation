using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Connect.QuickConnect
{
    /// <summary>
    /// AWS::Connect::QuickConnect QuickConnectConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-quickconnect-quickconnectconfig.html
    /// </summary>
    public class QuickConnectConfig
    {

        /// <summary>
        /// QuickConnectType
        /// The type of quick connect. In the Amazon Connect console, when you create a quick connect, you are
        /// prompted to assign one of the following types: Agent (USER), External (PHONE_NUMBER), or Queue
        /// (QUEUE).
        /// Required: Yes
        /// Type: String
        /// Allowed values: PHONE_NUMBER | QUEUE | USER
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("QuickConnectType")]
        public Union<string, IntrinsicFunction> QuickConnectType { get; set; }

        /// <summary>
        /// PhoneConfig
        /// The phone configuration. This is required only if QuickConnectType is PHONE_NUMBER.
        /// Required: No
        /// Type: PhoneNumberQuickConnectConfig
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PhoneConfig")]
        public PhoneNumberQuickConnectConfig PhoneConfig { get; set; }

        /// <summary>
        /// QueueConfig
        /// The queue configuration. This is required only if QuickConnectType is QUEUE.
        /// Required: No
        /// Type: QueueQuickConnectConfig
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("QueueConfig")]
        public QueueQuickConnectConfig QueueConfig { get; set; }

        /// <summary>
        /// UserConfig
        /// The user configuration. This is required only if QuickConnectType is USER.
        /// Required: No
        /// Type: UserQuickConnectConfig
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("UserConfig")]
        public UserQuickConnectConfig UserConfig { get; set; }

    }
}
