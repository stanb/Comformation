using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Amplify.Branch
{
    /// <summary>
    /// AWS::Amplify::Branch BasicAuthConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplify-branch-basicauthconfig.html
    /// </summary>
    public class BasicAuthConfig
    {

        /// <summary>
        /// EnableBasicAuth
        /// Enables basic authorization for the branch.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EnableBasicAuth")]
        public Union<bool, IntrinsicFunction> EnableBasicAuth { get; set; }

        /// <summary>
        /// Username
        /// The user name for basic authorization.
        /// Length Constraints: Minimum length of 1. Maximum length of 255.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Username")]
        public Union<string, IntrinsicFunction> Username { get; set; }

        /// <summary>
        /// Password
        /// The password for basic authorization.
        /// Length Constraints: Minimum length of 1. Maximum length of 255.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Password")]
        public Union<string, IntrinsicFunction> Password { get; set; }

    }
}
