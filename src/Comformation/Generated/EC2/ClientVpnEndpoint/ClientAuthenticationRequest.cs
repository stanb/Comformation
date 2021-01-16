using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.ClientVpnEndpoint
{
    /// <summary>
    /// AWS::EC2::ClientVpnEndpoint ClientAuthenticationRequest
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-clientvpnendpoint-clientauthenticationrequest.html
    /// </summary>
    public class ClientAuthenticationRequest
    {

        /// <summary>
        /// MutualAuthentication
        /// 		
        /// Information about the authentication certificates to be used, if applicable. You must provide this
        /// information if Type is certificate-authentication.
        /// 	
        /// Required: No
        /// Type: CertificateAuthenticationRequest
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MutualAuthentication")]
        public CertificateAuthenticationRequest MutualAuthentication { get; set; }

        /// <summary>
        /// Type
        /// 		
        /// The type of client authentication to be used.
        /// 	
        /// Required: Yes
        /// Type: String
        /// Allowed values: certificate-authentication | directory-service-authentication |
        /// federated-authentication
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

        /// <summary>
        /// FederatedAuthentication
        /// Information about the IAM SAML identity provider, if applicable.
        /// Required: No
        /// Type: FederatedAuthenticationRequest
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FederatedAuthentication")]
        public FederatedAuthenticationRequest FederatedAuthentication { get; set; }

        /// <summary>
        /// ActiveDirectory
        /// 		
        /// Information about the Active Directory to be used, if applicable. You must provide this information
        /// if Type is directory-service-authentication.
        /// 	
        /// Required: No
        /// Type: DirectoryServiceAuthenticationRequest
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ActiveDirectory")]
        public DirectoryServiceAuthenticationRequest ActiveDirectory { get; set; }

    }
}
