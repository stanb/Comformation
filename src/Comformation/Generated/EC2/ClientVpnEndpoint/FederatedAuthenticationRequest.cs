using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.ClientVpnEndpoint
{
    /// <summary>
    /// AWS::EC2::ClientVpnEndpoint FederatedAuthenticationRequest
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-clientvpnendpoint-federatedauthenticationrequest.html
    /// </summary>
    public class FederatedAuthenticationRequest
    {

        /// <summary>
        /// SelfServiceSAMLProviderArn
        /// The Amazon Resource Name (ARN) of the IAM SAML identity provider for the self-service portal.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SelfServiceSAMLProviderArn")]
        public Union<string, IntrinsicFunction> SelfServiceSAMLProviderArn { get; set; }

        /// <summary>
        /// SAMLProviderArn
        /// The Amazon Resource Name (ARN) of the IAM SAML identity provider.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SAMLProviderArn")]
        public Union<string, IntrinsicFunction> SAMLProviderArn { get; set; }

    }
}
