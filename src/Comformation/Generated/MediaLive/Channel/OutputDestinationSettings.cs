using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel OutputDestinationSettings
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-outputdestinationsettings.html
    /// </summary>
    public class OutputDestinationSettings
    {

        /// <summary>
        /// StreamName
        /// The stream name for the content. This applies only to RTMP outputs.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("StreamName")]
        public Union<string, IntrinsicFunction> StreamName { get; set; }

        /// <summary>
        /// Username
        /// The user name to connect to the downstream system. This applies only if the downstream system
        /// requires credentials.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Username")]
        public Union<string, IntrinsicFunction> Username { get; set; }

        /// <summary>
        /// PasswordParam
        /// The password parameter that holds the password for accessing the downstream system. This password
        /// parameter applies only if the downstream system requires credentials.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PasswordParam")]
        public Union<string, IntrinsicFunction> PasswordParam { get; set; }

        /// <summary>
        /// Url
        /// The URL for the destination.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Url")]
        public Union<string, IntrinsicFunction> Url { get; set; }

    }
}
