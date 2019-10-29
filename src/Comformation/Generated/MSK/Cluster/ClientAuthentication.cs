using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MSK.Cluster
{
    /// <summary>
    /// AWS::MSK::Cluster ClientAuthentication
    /// Includes information related to client authentication.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-cluster-clientauthentication.html
    /// </summary>
    public class ClientAuthentication
    {

        /// <summary>
        /// Tls
        /// Details for client authentication using TLS.
        /// Required: No
        /// Type: Tls
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Tls")]
        public Tls Tls { get; set; }

    }
}
