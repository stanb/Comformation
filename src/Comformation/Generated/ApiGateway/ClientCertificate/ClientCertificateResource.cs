using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApiGateway.ClientCertificate
{
    /// <summary>
    /// AWS::ApiGateway::ClientCertificate
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

            /// <summary>
            /// Tags
            /// An array of arbitrary tags (key-value pairs) to associate with the client certificate.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::ApiGateway::ClientCertificate";

        public ClientCertificateProperties Properties { get; } = new ClientCertificateProperties();

    }

    public static class ClientCertificateAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ClientCertificateId = new ResourceAttribute<Union<string, IntrinsicFunction>>("ClientCertificateId");
    }
}
