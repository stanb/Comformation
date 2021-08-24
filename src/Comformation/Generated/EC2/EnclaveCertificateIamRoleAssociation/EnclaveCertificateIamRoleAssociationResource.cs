using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.EnclaveCertificateIamRoleAssociation
{
    /// <summary>
    /// AWS::EC2::EnclaveCertificateIamRoleAssociation
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-enclavecertificateiamroleassociation.html
    /// </summary>
    public class EnclaveCertificateIamRoleAssociationResource : ResourceBase
    {
        public class EnclaveCertificateIamRoleAssociationProperties
        {
            /// <summary>
            /// CertificateArn
            /// 		
            /// The ARN of the ACM certificate with which to associate the IAM role.
            /// 	
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 1283
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> CertificateArn { get; set; }

            /// <summary>
            /// RoleArn
            /// 		
            /// The ARN of the IAM role to associate with the ACM certificate. You can associate up to 16 IAM roles
            /// with an ACM 			certificate.
            /// 	
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 1283
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> RoleArn { get; set; }

        }

        public string Type { get; } = "AWS::EC2::EnclaveCertificateIamRoleAssociation";

        public EnclaveCertificateIamRoleAssociationProperties Properties { get; } = new EnclaveCertificateIamRoleAssociationProperties();

    }

    public static class EnclaveCertificateIamRoleAssociationAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> CertificateS3BucketName = new ResourceAttribute<Union<string, IntrinsicFunction>>("CertificateS3BucketName");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> CertificateS3ObjectKey = new ResourceAttribute<Union<string, IntrinsicFunction>>("CertificateS3ObjectKey");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> EncryptionKmsKeyId = new ResourceAttribute<Union<string, IntrinsicFunction>>("EncryptionKmsKeyId");
    }
}
