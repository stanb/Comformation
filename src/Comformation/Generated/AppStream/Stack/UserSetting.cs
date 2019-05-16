using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppStream.Stack
{
    /// <summary>
    /// AWS::AppStream::Stack UserSetting
    /// Specifies an action and whether the action is enabled or disabled for users during their streaming sessions.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appstream-stack-usersetting.html
    /// </summary>
    public class UserSetting
    {

        /// <summary>
        /// Action
        /// The action that is enabled or disabled.
        /// Required: Yes
        /// Type: String
        /// Allowed Values: CLIPBOARD_COPY_FROM_LOCAL_DEVICE | CLIPBOARD_COPY_TO_LOCAL_DEVICE | FILE_DOWNLOAD |
        /// FILE_UPLOAD | PRINTING_TO_LOCAL_DEVICE
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Action")]
        public Union<string, IntrinsicFunction> Action { get; set; }

        /// <summary>
        /// Permission
        /// Indicates whether the action is enabled or disabled.
        /// Required: Yes
        /// Type: String
        /// Allowed Values: DISABLED | ENABLED
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Permission")]
        public Union<string, IntrinsicFunction> Permission { get; set; }

    }
}
