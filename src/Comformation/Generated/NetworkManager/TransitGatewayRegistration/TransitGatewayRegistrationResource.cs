using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.NetworkManager.TransitGatewayRegistration
{
    /// <summary>
    /// AWS::NetworkManager::TransitGatewayRegistration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkmanager-transitgatewayregistration.html
    /// </summary>
    public class TransitGatewayRegistrationResource : ResourceBase
    {
        public class TransitGatewayRegistrationProperties
        {
            /// <summary>
            /// GlobalNetworkId
            /// The ID of the global network.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> GlobalNetworkId { get; set; }

            /// <summary>
            /// TransitGatewayArn
            /// The Amazon Resource Name (ARN) of the transit gateway.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> TransitGatewayArn { get; set; }

        }

        public string Type { get; } = "AWS::NetworkManager::TransitGatewayRegistration";

        public TransitGatewayRegistrationProperties Properties { get; } = new TransitGatewayRegistrationProperties();

    }
}
