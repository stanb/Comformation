using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.KMS.Alias
{
    /// <summary>
    /// AWS::KMS::Alias
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kms-alias.html
    /// </summary>
    public class AliasResource : ResourceBase
    {
        public class AliasProperties
        {
            /// <summary>
            /// AliasName
            /// Specifies the alias name. This value must begin with alias/ followed by a name, such as
            /// alias/ExampleAlias.
            /// Note If you change the value of a Replacement property, such as AliasName, the existing alias is
            /// deleted and a new alias is created for the specified CMK. This change can disrupt applications that
            /// use the alias. It can also allow or deny access to a CMK affected by attribute-based access control
            /// (ABAC).
            /// The alias must be string of 1-256 characters. It can contain only alphanumeric characters, forward
            /// slashes (/), underscores (_), and dashes (-). The alias name cannot begin with alias/aws/. The
            /// alias/aws/ prefix is reserved for AWS managed CMKs.
            /// Pattern: alias/^[a-zA-Z0-9/_-]+$
            /// Minimum: 1
            /// Maximum: 256
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> AliasName { get; set; }

            /// <summary>
            /// TargetKeyId
            /// Associates the alias with the specified customer managed CMK. The CMK must be in the same AWS
            /// account and Region.
            /// A valid CMK ID is required. If you supply a null or empty string value, this operation returns an
            /// error.
            /// For help finding the key ID and ARN, see Finding the key ID and ARN in the AWS Key Management
            /// Service Developer Guide.
            /// Specify the key ID or the key ARN of the CMK.
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
