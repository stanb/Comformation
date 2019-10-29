using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.ClientVpnEndpoint
{
    /// <summary>
    /// AWS::EC2::ClientVpnEndpoint CertificateAuthenticationRequest
    /// Information about the client certificate to be used for authentication.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-clientvpnendpoint-certificateauthenticationrequest.html
    /// </summary>
    public class CertificateAuthenticationRequest
    {

        /// <summary>
        /// ClientRootCertificateChainArn
        /// 		
        /// The ARN of the client certificate. The certificate must be signed by a certificate 			authority (CA)
        /// and it must be provisioned in AWS Certificate Manager (ACM).
        /// 	
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ClientRootCertificateChainArn")]
        public Union<string, IntrinsicFunction> ClientRootCertificateChainArn { get; set; }

    }
}
