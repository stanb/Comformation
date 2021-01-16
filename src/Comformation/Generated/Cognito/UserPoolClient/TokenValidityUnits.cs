using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Cognito.UserPoolClient
{
    /// <summary>
    /// AWS::Cognito::UserPoolClient TokenValidityUnits
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpoolclient-tokenvalidityunits.html
    /// </summary>
    public class TokenValidityUnits
    {

        /// <summary>
        /// IdToken
        /// A time unit in “seconds”, “minutes”, “hours” or “days” for the value in IdTokenValidity, defaults to
        /// hours.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IdToken")]
        public Union<string, IntrinsicFunction> IdToken { get; set; }

        /// <summary>
        /// RefreshToken
        /// A time unit in “seconds”, “minutes”, “hours” or “days” for the value in RefreshTokenValidity,
        /// defaults to days.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RefreshToken")]
        public Union<string, IntrinsicFunction> RefreshToken { get; set; }

        /// <summary>
        /// AccessToken
        /// A time unit in “seconds”, “minutes”, “hours” or “days” for the value in AccessTokenValidity,
        /// defaults to hours.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AccessToken")]
        public Union<string, IntrinsicFunction> AccessToken { get; set; }

    }
}
