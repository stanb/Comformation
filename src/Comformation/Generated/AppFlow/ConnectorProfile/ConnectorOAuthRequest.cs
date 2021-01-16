using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppFlow.ConnectorProfile
{
    /// <summary>
    /// AWS::AppFlow::ConnectorProfile ConnectorOAuthRequest
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-connectoroauthrequest.html
    /// </summary>
    public class ConnectorOAuthRequest
    {

        /// <summary>
        /// AuthCode
        /// The code provided by the connector when it has been authenticated via the connected app.
        /// Required: No
        /// Type: String
        /// Maximum: 512
        /// Pattern: \S+
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AuthCode")]
        public Union<string, IntrinsicFunction> AuthCode { get; set; }

        /// <summary>
        /// RedirectUri
        /// The URL to which the authentication server redirects the browser after authorization has been
        /// granted.
        /// Required: No
        /// Type: String
        /// Maximum: 512
        /// Pattern: \S+
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RedirectUri")]
        public Union<string, IntrinsicFunction> RedirectUri { get; set; }

    }
}
