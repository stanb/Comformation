using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.KMS.Alias
{
    /// <summary>
    /// AWS::KMS::Alias
    /// The AWS::KMS::Alias resource creates a display name for a customer master key (CMK) in AWS Key Management
    /// Service (AWS KMS). Using an alias to refer to a key can help you simplify key management. For example, when
    /// rotating keys, you can just update the alias mapping instead of tracking and changing key IDs. For more
    /// information, see Working with Aliases in the AWS Key Management Service Developer Guide.
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kms-alias.html
    /// </summary>
    public class AliasResource : ResourceBase
    {
        public class AliasProperties
        {
            /// <summary>
            /// AliasName
            /// The name of the alias. The name must start with alias followed by a forward slash, such as alias/.
            /// You can't specify aliases that begin with alias/AWS. These aliases are reserved.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kms-alias.html#cfn-kms-alias-aliasname
            /// </summary>
			public Union<string, IntrinsicFunction> AliasName { get; set; }

            /// <summary>
            /// TargetKeyId
            /// The ID of the key for which you are creating the alias. Specify the key's globally unique identifier
            /// or Amazon Resource Name (ARN). You can't specify another alias.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kms-alias.html#cfn-kms-alias-targetkeyid
            /// </summary>
			public Union<string, IntrinsicFunction> TargetKeyId { get; set; }

        }
    
        public string Type { get; } = "AWS::KMS::Alias";
        
        public AliasProperties Properties { get; } = new AliasProperties();
    }
}
