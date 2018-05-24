using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoT.Certificate
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-certificate.html
    /// </summary>
    public class CertificateResource : ResourceBase
    {
        public class CertificateProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-certificate.html#cfn-iot-certificate-certificatesigningrequest
            /// </summary>
			public Union<string, IntrinsicFunction> CertificateSigningRequest { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-certificate.html#cfn-iot-certificate-status
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
