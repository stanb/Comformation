using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudFront.PublicKey
{
    /// <summary>
    /// AWS::CloudFront::PublicKey
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudfront-publickey.html
    /// </summary>
    public class PublicKeyResource : ResourceBase
    {
        public class PublicKeyProperties
        {
            /// <summary>
            /// PublicKeyConfig
            /// 		
            /// Configuration information about a public key that you can use with signed URLs and signed cookies,
            /// or with field-level encryption.
            /// 	
            /// Required: Yes
            /// Type: PublicKeyConfig
            /// Update requires: No interruption
            /// </summary>
            public PublicKeyConfig PublicKeyConfig { get; set; }

        }

        public string Type { get; } = "AWS::CloudFront::PublicKey";

        public PublicKeyProperties Properties { get; } = new PublicKeyProperties();

    }

    public static class PublicKeyAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> CreatedTime = new ResourceAttribute<Union<string, IntrinsicFunction>>("CreatedTime");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Id = new ResourceAttribute<Union<string, IntrinsicFunction>>("Id");
    }
}
