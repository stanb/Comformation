using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoT.Certificate
{
    /// <summary>
    /// AWS::IoT::Certificate
    /// Use the AWS::IoT::Certificate resource to declare an X. 509 certificate.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-certificate.html
    /// </summary>
    public class CertificateResource : ResourceBase
    {
        public class CertificateProperties
        {
            /// <summary>
            /// CertificateSigningRequest
            /// The certificate signing request (CSR).
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> CertificateSigningRequest { get; set; }

            /// <summary>
            /// Status
            /// The status of the certificate.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Status { get; set; }

        }
    
        public string Type { get; } = "AWS::IoT::Certificate";
        
        public CertificateProperties Properties { get; } = new CertificateProperties();
    }

	public static class CertificateAttributes
	{
        public static readonly ResourceAttribute<string> Arn = new ResourceAttribute<string>("Arn");
	}
}
