using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.ClientVpnEndpoint
{
    /// <summary>
    /// AWS::EC2::ClientVpnEndpoint DirectoryServiceAuthenticationRequest
    /// Describes the Active Directory to be used for client authentication.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-clientvpnendpoint-directoryserviceauthenticationrequest.html
    /// </summary>
    public class DirectoryServiceAuthenticationRequest
    {

        /// <summary>
        /// DirectoryId
        /// 		
        /// The ID of the Active Directory to be used for authentication.
        /// 	
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DirectoryId")]
        public Union<string, IntrinsicFunction> DirectoryId { get; set; }

    }
}
