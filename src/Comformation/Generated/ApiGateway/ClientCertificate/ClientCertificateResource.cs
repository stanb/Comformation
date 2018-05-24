using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApiGateway.ClientCertificate
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-clientcertificate.html
    /// </summary>
    public class ClientCertificateResource : ResourceBase
    {
        public class ClientCertificateProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-clientcertificate.html#cfn-apigateway-clientcertificate-description
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

        }
    
        public string Type { get; } = "AWS::ApiGateway::ClientCertificate";
        
        public ClientCertificateProperties Properties { get; } = new ClientCertificateProperties();
    }
}
