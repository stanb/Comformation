using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IAM.User
{
    /// <summary>
    /// AWS::IAM::User LoginProfile
    /// Contains the user name and password create date for a user.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iam-user-loginprofile.html
    /// </summary>
    public class LoginProfile
    {

        /// <summary>
        /// Password
        /// The user&#39;s password.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Password")]
        public Union<string, IntrinsicFunction> Password { get; set; }

        /// <summary>
        /// PasswordResetRequired
        /// Specifies whether the user is required to set a new password on next sign-in.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PasswordResetRequired")]
        public Union<bool, IntrinsicFunction> PasswordResetRequired { get; set; }

    }
}
