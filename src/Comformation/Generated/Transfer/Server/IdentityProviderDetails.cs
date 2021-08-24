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
        /// DirectoryId
        /// The identifier of the AWSDirectory Service directory that you want to stop sharing.
        /// Required: No
        /// Type: String
        /// Minimum: 12
        /// Maximum: 12
        /// Pattern: ^d-[0-9a-f]{10}$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DirectoryId")]
        public Union<string, IntrinsicFunction> DirectoryId { get; set; }

        /// <summary>
        /// InvocationRole
        /// Provides the type of InvocationRole used to authenticate the user account.
        /// Required: No
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
        /// Required: No
        /// Type: String
        /// Maximum: 255
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Url")]
        public Union<string, IntrinsicFunction> Url { get; set; }

    }
}
