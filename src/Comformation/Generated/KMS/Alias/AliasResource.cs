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
            /// Identifies the CMK to which the alias refers. Specify the key ID or the Amazon Resource Name (ARN)
            /// of the CMK. You cannot specify another alias. For help finding the key ID and ARN, see Finding the
            /// Key ID and ARN in the AWS Key Management Service Developer Guide.
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
