using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppStream.Stack
{
    /// <summary>
    /// Amazon AppStream 2. 0 Stack UserSetting
    /// The UserSetting property type specifies an action and whether the action is enabled or disabled for users of
    /// an Amazon AppStream 2. 0 stack during their streaming sessions.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appstream-stack-usersetting.html
    /// </summary>
    public class UserSetting
    {

        /// <summary>
        /// Action
        /// The action that is enabled or disabled.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Action")]
        public Union<string, IntrinsicFunction> Action { get; set; }

        /// <summary>
        /// Permission
        /// Indicates whether the action is enabled or disabled.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Permission")]
        public Union<string, IntrinsicFunction> Permission { get; set; }

    }
}
