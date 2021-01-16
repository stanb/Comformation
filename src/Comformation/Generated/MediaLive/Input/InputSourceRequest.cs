using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Input
{
    /// <summary>
    /// AWS::MediaLive::Input InputSourceRequest
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-input-inputsourcerequest.html
    /// </summary>
    public class InputSourceRequest
    {

        /// <summary>
        /// Username
        /// The user name for accessing the upstream system. The user name applies only if the upstream system
        /// requires credentials.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Username")]
        public Union<string, IntrinsicFunction> Username { get; set; }

        /// <summary>
        /// PasswordParam
        /// The password parameter that holds the password for accessing the upstream system. The password
        /// parameter applies only if the upstream system requires credentials.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PasswordParam")]
        public Union<string, IntrinsicFunction> PasswordParam { get; set; }

        /// <summary>
        /// Url
        /// For a pull input, the URL where MediaLive pulls the source content from.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Url")]
        public Union<string, IntrinsicFunction> Url { get; set; }

    }
}
