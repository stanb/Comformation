using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ASK.Skill
{
    /// <summary>
    /// Alexa::ASK::Skill AuthenticationConfiguration
    /// The AuthenticationConfiguration property type specifies the Login with Amazon (LWA) configuration used to
    /// authenticate with the Alexa service. Only Login with Amazon security profiles created through the Build Skills
    /// with the Alexa Skills Kit developer documentation are supported for authentication. A client ID, client
    /// secret, and refresh token are required. You can generate a client ID and client secret by creating a new
    /// security profile on the Amazon Developer Portal or you can retrieve them from an existing profile. You can
    /// then retrieve the refresh token using the Alexa Skills Kit CLI. For instructions, see util-command in the ASK
    /// CLI Command Reference.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ask-skill-authenticationconfiguration.html
    /// </summary>
    public class AuthenticationConfiguration
    {

        /// <summary>
        /// RefreshToken
        /// Refresh token from Login with Amazon (LWA).
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RefreshToken")]
        public Union<string, IntrinsicFunction> RefreshToken { get; set; }

        /// <summary>
        /// ClientSecret
        /// Client secret from Login with Amazon (LWA).
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ClientSecret")]
        public Union<string, IntrinsicFunction> ClientSecret { get; set; }

        /// <summary>
        /// ClientId
        /// Client ID from Login with Amazon (LWA).
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ClientId")]
        public Union<string, IntrinsicFunction> ClientId { get; set; }

    }
}
