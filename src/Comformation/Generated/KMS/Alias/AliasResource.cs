using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.KMS.Alias
{
    /// <summary>
    /// AWS::KMS::Alias
    /// The AWS::KMS::Alias resource specifies a display name for a customer master key (CMK) in AWS Key Management
    /// Service (AWS KMS). You can use an alias to identify a CMK in cryptographic operations.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kms-alias.html
    /// </summary>
    public class AliasResource : ResourceBase
    {
        public class AliasProperties
        {
            /// <summary>
            /// AliasName
            /// Specifies the alias name. This value must begin with alias/ followed by a name, such as
            /// alias/ExampleAlias. The alias name cannot begin with alias/aws/. The alias/aws/ prefix is reserved
            /// for AWS managed CMKs.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 256
            /// Pattern: ^[a-zA-Z0-9:/_-]+$
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> AliasName { get; set; }

            /// <summary>
            /// TargetKeyId
            /// Identifies the CMK to which the alias refers.
            /// Specify the key ID or the Amazon Resource Name (ARN) of the CMK.
            /// For example:
            /// Key ID: 1234abcd-12ab-34cd-56ef-1234567890ab Key ARN:
            /// arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab
            /// To get the key ID and key ARN for a CMK, use ListKeys or DescribeKey.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 2048
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> TargetKeyId { get; set; }

        }

        public string Type { get; } = "AWS::KMS::Alias";

        public AliasProperties Properties { get; } = new AliasProperties();

    }
}
