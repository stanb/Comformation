using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel InputLocation
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-inputlocation.html
    /// </summary>
    public class InputLocation
    {

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
        /// The password parameter that holds the password for accessing the downstream system. This applies
        /// only if the downstream system requires credentials.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PasswordParam")]
        public Union<string, IntrinsicFunction> PasswordParam { get; set; }

        /// <summary>
        /// Uri
        /// The URI should be a path to a file that is accessible to the Live system (for example, an http://
        /// URI) depending on the output type. For example, an RTMP destination should have a URI similar to
        /// rtmp://fmsserver/live.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Uri")]
        public Union<string, IntrinsicFunction> Uri { get; set; }

    }
}
