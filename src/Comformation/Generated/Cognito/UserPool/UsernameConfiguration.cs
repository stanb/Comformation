using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Cognito.UserPool
{
    /// <summary>
    /// AWS::Cognito::UserPool UsernameConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpool-usernameconfiguration.html
    /// </summary>
    public class UsernameConfiguration
    {

        /// <summary>
        /// CaseSensitive
        /// Specifies whether username case sensitivity will be applied for all users in the user pool through
        /// Cognito APIs.
        /// Valid values include:
        /// True : Enables case sensitivity for all username input. When this option is set to True, users must
        /// sign in using the exact capitalization of their given username. For example, “UserName”. This is the
        /// default value. False : Enables case insensitivity for all username input. For example, when this
        /// option is set to False, users will be able to sign in using either &quot;username&quot; or &quot;Username&quot;. This
        /// option also enables both preferred_username and email alias to be case insensitive, in addition to
        /// the username attribute.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CaseSensitive")]
        public Union<bool, IntrinsicFunction> CaseSensitive { get; set; }

    }
}
