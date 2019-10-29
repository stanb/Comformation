using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Transfer.Server
{
    /// <summary>
    /// AWS::Transfer::Server IdentityProviderDetails
    /// This parameter is required when the IdentityProviderType is set to API_GATEWAY. Accepts an array containing
    /// all of the information required to call a customer-supplied authentication API, including the API Gateway URL.
    /// This property is not required when the IdentityProviderType is set to SERVICE_MANAGED.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-server-identityproviderdetails.html
    /// </summary>
    public class IdentityProviderDetails
    {

        /// <summary>
        /// InvocationRole
        /// The InvocationRole parameter provides the type of InvocationRole used to authenticate the user
        /// account.
        /// Required: Yes
        /// Type: String
        /// Pattern: arn:. *role/. *
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("InvocationRole")]
        public Union<string, IntrinsicFunction> InvocationRole { get; set; }

        /// <summary>
        /// Url
        /// The Url parameter provides contains the location of the service endpoint used to authenticate users.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Url")]
        public Union<string, IntrinsicFunction> Url { get; set; }

    }
}
