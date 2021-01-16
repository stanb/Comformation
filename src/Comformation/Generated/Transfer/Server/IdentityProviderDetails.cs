using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Transfer.Server
{
    /// <summary>
    /// AWS::Transfer::Server IdentityProviderDetails
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-server-identityproviderdetails.html
    /// </summary>
    public class IdentityProviderDetails
    {

        /// <summary>
        /// InvocationRole
        /// Provides the type of InvocationRole used to authenticate the user account.
        /// Required: Yes
        /// Type: String
        /// Minimum: 20
        /// Maximum: 2048
        /// Pattern: arn:. *role/. *
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("InvocationRole")]
        public Union<string, IntrinsicFunction> InvocationRole { get; set; }

        /// <summary>
        /// Url
        /// Provides the location of the service endpoint used to authenticate users.
        /// Required: Yes
        /// Type: String
        /// Maximum: 255
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Url")]
        public Union<string, IntrinsicFunction> Url { get; set; }

    }
}
