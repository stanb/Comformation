using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Amplify.App
{
    /// <summary>
    /// AWS::Amplify::App BasicAuthConfig
    /// Use the BasicAuthConfig property type to set password protection at an app level to all your branches.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplify-app-basicauthconfig.html
    /// </summary>
    public class BasicAuthConfig
    {

        /// <summary>
        /// Username
        /// The user name for basic authorization.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Username")]
        public Union<string, IntrinsicFunction> Username { get; set; }

        /// <summary>
        /// EnableBasicAuth
        /// Enables Basic Authorization for branches for the Amplify App.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EnableBasicAuth")]
        public Union<bool, IntrinsicFunction> EnableBasicAuth { get; set; }

        /// <summary>
        /// Password
        /// The password for basic authorization.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Password")]
        public Union<string, IntrinsicFunction> Password { get; set; }

    }
}
