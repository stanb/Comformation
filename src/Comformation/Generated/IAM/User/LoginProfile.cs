using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IAM.User
{
    /// <summary>
    /// IAM User LoginProfile
    /// LoginProfile is a property of the AWS::IAM::User resource that creates a login profile for users so that they
    /// can access the AWS Management Console.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iam-user-loginprofile.html
    /// </summary>
    public class LoginProfile
    {

        /// <summary>
        /// Password
        /// The password for the user.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Password")]
        public Union<string, IntrinsicFunction> Password { get; set; }

        /// <summary>
        /// PasswordResetRequired
        /// Specifies whether the user is required to set a new password the next time the user logs in to the
        /// AWS Management Console.
        /// Required: No
        /// Type: Boolean
        /// </summary>
        [JsonProperty("PasswordResetRequired")]
        public Union<bool, IntrinsicFunction> PasswordResetRequired { get; set; }

    }
}
