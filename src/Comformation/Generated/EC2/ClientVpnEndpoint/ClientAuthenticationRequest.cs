using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.ClientVpnEndpoint
{
    /// <summary>
    /// AWS::EC2::ClientVpnEndpoint ClientAuthenticationRequest
    /// Describes the authentication method to be used by a Client VPN endpoint. Client VPN supports 			Active
    /// Directory and mutual authentication. For more information, see Authentication 			in the AWS Client VPN
    /// Administrator Guide.
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
        /// The type of client authentication to be used. Specify certificate-authentication to use
        /// certificate-based authentication, or 			directory-service-authentication to use Active Directory
        /// authentication.
        /// 	
        /// Required: Yes
        /// Type: String
        /// Allowed Values: certificate-authentication | directory-service-authentication
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

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
