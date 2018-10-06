using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApiGateway.ClientCertificate
{
    /// <summary>
    /// AWS::ApiGateway::ClientCertificate
    /// The AWS::ApiGateway::ClientCertificate resource creates a client certificate that Amazon API Gateway (API
    /// Gateway) uses to configure client-side SSL authentication for sending requests to the integration endpoint.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-clientcertificate.html
    /// </summary>
    public class ClientCertificateResource : ResourceBase
    {
        public class ClientCertificateProperties
        {
            /// <summary>
            /// Description
            /// A description of the client certificate.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

        }
    
        public string Type { get; } = "AWS::ApiGateway::ClientCertificate";
        
        public ClientCertificateProperties Properties { get; } = new ClientCertificateProperties();

    }
}
