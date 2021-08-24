using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.KMS.ReplicaKey
{
    /// <summary>
    /// AWS::KMS::ReplicaKey
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kms-replicakey.html
    /// </summary>
    public class ReplicaKeyResource : ResourceBase
    {
        public class ReplicaKeyProperties
        {
            /// <summary>
            /// PrimaryKeyArn
            /// Specifies the multi-Region primary key to replicate. The primary key must be in a different AWS
            /// Region of the same AWSpartition. You can create only one replica of a given primary key in each AWS
            /// Region .
            /// Important If you change the PrimaryKeyArn value of a replica key, the existing replica key is
            /// scheduled for deletion and a new replica key is created based on the specified primary key. While it
            /// is scheduled for deletion, the existing replica key becomes unusable. You can cancel the scheduled
            /// deletion of the key outside of CloudFormation. However, if you inadvertently delete a replica key,
            /// you can decrypt ciphertext encrypted by that replica key by using any related multi-Region key. If
            /// necessary, you can recreate the replica in the same Region after the previous one is completely
            /// deleted. For details, see Deleting multi-Region keys in the AWS Key Management Service Developer
            /// Guide
            /// Specify the key ARN of an existing multi-Region primary key. For example,
            /// arn:aws:kms:us-east-2:111122223333:key/mrk-1234abcd12ab34cd56ef1234567890ab.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 2048
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> PrimaryKeyArn { get; set; }

            /// <summary>
            /// Description
            /// A description of the CMK.
            /// The default value is an empty string (no description).
            /// The description is not a shared property of multi-Region keys. You can specify the same description
            /// or a different description for each key in a set of related multi-Region keys. AWS Key Management
            /// Service does not synchronize this property.
            /// Required: No
            /// Type: String
            /// Minimum: 0
            /// Maximum: 8192
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// Enabled
            /// Specifies whether the replica key is enabled. Disabled CMKs cannot be used in cryptographic
            /// operations.
            /// When Enabled is true, the key state of the CMK is Enabled. When Enabled is false, the key state of
            /// the CMK is Disabled. The default value is true.
            /// The actual key state of the replica might be affected by actions taken outside of CloudFormation,
            /// such as running the EnableKey, DisableKey, or ScheduleKeyDeletion operations. Also, while the
            /// replica key is being created, its key state is Creating. When the process is complete, the key state
            /// of the replica key changes to Enabled.
            /// For information about the key states of a CMK, see Key state: Effect on your CMK in the AWS Key
            /// Management Service Developer Guide.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> Enabled { get; set; }

            /// <summary>
            /// KeyPolicy
            /// The key policy that authorizes use of the replica key.
            /// The key policy is not a shared property of multi-Region keys. You can specify the same key policy or
            /// a different key policy for each key in a set of related multi-Region keys. AWS Key Management
            /// Service does not synchronize this property.
            /// The key policy must conform to the following rules.
            /// The key policy must give the caller PutKeyPolicy permission on the CMK. This reduces the risk that
            /// the CMK becomes unmanageable. For more information, refer to the scenario in the Default key policy
            /// section of the AWS Key Management Service Developer Guide . Each statement in the key policy must
            /// contain one or more principals. The principals in the key policy must exist and be visible to AWS
            /// KMS. When you create a new AWSprincipal (for example, an IAM user or role), you might need to
            /// enforce a delay before including the new principal in a key policy because the new principal might
            /// not be immediately visible to AWS KMS. For more information, see Changes that I make are not always
            /// immediately visible in the AWS Identity and Access Management User Guide. The key policy size limit
            /// is 32 kilobytes (32768 bytes).
            /// Minimum: 1
            /// Maximum: 32768
            /// Required: Yes
            /// Type: Json
            /// Update requires: No interruption
            /// </summary>
            public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> KeyPolicy { get; set; }

            /// <summary>
            /// PendingWindowInDays
            /// Specifies the number of days in the waiting period before AWS KMS deletes a replica key that has
            /// been removed from a CloudFormation stack. Enter a value between 7 and 30 days. The default value is
            /// 30 days.
            /// When you remove a replica key from a CloudFormation stack, AWS KMS schedules the replica key for
            /// deletion and starts the mandatory waiting period. The PendingWindowInDays property determines the
            /// length of waiting period. During the waiting period, the key state of replica key is Pending
            /// Deletion, which prevents it from being used in cryptographic operations. When the waiting period
            /// expires, AWS KMS permanently deletes the replica key.
            /// You cannot use a CloudFormation template to cancel deletion of the replica after you remove it from
            /// the stack, regardless of the waiting period. However, if you specify a replica key in your template
            /// that is based on the same primary key as the original replica key, CloudFormation creates a new
            /// replica key with the same key ID, key material, and other shared properties of the original replica
            /// key. This new replica key can decrypt ciphertext that was encrypted under the original replica key,
            /// or any related multi-Region key.
            /// For detailed information about deleting multi-Region keys, see Deleting multi-Region keys in the AWS
            /// Key Management Service Developer Guide.
            /// For information about the PendingDeletion key state, see Key state: Effect on your CMK in the AWS
            /// Key Management Service Developer Guide. For more information about deleting CMKs, see the
            /// ScheduleKeyDeletion operation in the AWS Key Management Service API Reference and Deleting customer
            /// master keys in the AWS Key Management Service Developer Guide.
            /// Minimum: 7
            /// Maximum: 30
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> PendingWindowInDays { get; set; }

            /// <summary>
            /// Tags
            /// Assigns one or more tags to the replica key.
            /// Note Tagging or untagging a CMK can allow or deny permission to the CMK. For details, see Using ABAC
            /// in AWS KMS in the AWS Key Management Service Developer Guide.
            /// Tags are not a shared property of multi-Region keys. You can specify the same tags or different tags
            /// for each key in a set of related multi-Region keys. AWS Key Management Service does not synchronize
            /// this property.
            /// Each tag consists of a tag key and a tag value. Both the tag key and the tag value are required, but
            /// the tag value can be an empty (null) string. You cannot have more than one tag on a CMK with the
            /// same tag key. If you specify an existing tag key with a different tag value, AWS KMS replaces the
            /// current tag value with the specified one.
            /// When you assign tags to an AWSresource, AWSgenerates a cost allocation report with usage and costs
            /// aggregated by tags. Tags can also be used to control access to a CMK. For details, see Tagging keys.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::KMS::ReplicaKey";

        public ReplicaKeyProperties Properties { get; } = new ReplicaKeyProperties();

    }

    public static class ReplicaKeyAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> KeyId = new ResourceAttribute<Union<string, IntrinsicFunction>>("KeyId");
    }
}
