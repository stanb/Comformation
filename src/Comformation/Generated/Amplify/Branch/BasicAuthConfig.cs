using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Amplify.Branch
{
    /// <summary>
    /// AWS::Amplify::Branch BasicAuthConfig
    /// Use the BasicAuthConfig property type to set password protection for a specific branch.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplify-branch-basicauthconfig.html
    /// </summary>
    public class BasicAuthConfig
    {

        /// <summary>
        /// Username
        /// The user name for basic authorization.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Username")]
        public Union<string, IntrinsicFunction> Username { get; set; }

        /// <summary>
        /// EnableBasicAuth
        /// Enables Basic Auth for the branch.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EnableBasicAuth")]
        public Union<bool, IntrinsicFunction> EnableBasicAuth { get; set; }

        /// <summary>
        /// Password
        /// The password for basic authorization.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Password")]
        public Union<string, IntrinsicFunction> Password { get; set; }

    }
}
