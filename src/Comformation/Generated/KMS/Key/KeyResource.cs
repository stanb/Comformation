using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.KMS.Key
{
    /// <summary>
    /// AWS::KMS::Key
    /// The AWS::KMS::Key resource specifies a customer master key (CMK) in AWS Key Management Service (AWS KMS).
    /// Authorized users can use the CMK to encrypt and decrypt small amounts of data (up to 4096 bytes), but they are
    /// more commonly used to generate data keys. You can also use CMKs to encrypt data stored in AWS services that
    /// are integrated with AWS KMS or within their applications. For more information, see What is the AWS Key
    /// Management Service? in the AWS Key Management Service Developer Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kms-key.html
    /// </summary>
    public class KeyResource : ResourceBase
    {
        public class KeyProperties
        {
            /// <summary>
            /// Description
            /// A description of the CMK. Use a description that helps you to distinguish this CMK from others in
            /// the account, such as its intended use.
            /// Required: No
            /// Type: String
            /// Minimum: 0
            /// Maximum: 8192
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// EnableKeyRotation
            /// Enables automatic rotation of the key material for the specified customer master key (CMK). By
            /// default, automation key rotation is not enabled.
            /// When you enable automatic rotation, AWS KMS automatically creates new key material for the CMK 365
            /// days after the enable (or reenable) date and every 365 days thereafter. AWS KMS retains all key
            /// material until you delete the CMK.
            /// For detailed information about automatic key rotation, see Rotating Customer Master Keys in the AWS
            /// Key Management Service Developer Guide.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
			public Union<bool, IntrinsicFunction> EnableKeyRotation { get; set; }

            /// <summary>
            /// Enabled
            /// Specifies whether the customer master key (CMK) is enabled. Disabled CMKs cannot be used in
            /// cryptographic operations.
            /// When Enabled is true, the key state of the CMK is Enabled. When Enabled is false, the key state of
            /// the CMK is Disabled. The default value is true.
            /// The actual key state of the CMK might be affected by actions taken outside of CloudFormation, such
            /// as running the EnableKey, DisableKey, or ScheduleKeyDeletion operations.
            /// For information about the key states of a CMK, see How Key State Affects Use of a Customer Master
            /// Key in the AWS Key Management Service Developer Guide.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
			public Union<bool, IntrinsicFunction> Enabled { get; set; }

            /// <summary>
            /// KeyPolicy
            /// The key policy that authorizes use of the CMK. The key policy must observe the following rules.
            /// The key policy must allow the caller to make a subsequent PutKeyPolicy request on the CMK. This
            /// reduces the risk that the CMK becomes unmanageable. For more information, refer to the scenario in
            /// the Default Key Policy section of the AWS Key Management Service Developer Guide . Each statement in
            /// the key policy must contain one or more principals. The principals in the key policy must exist and
            /// be visible to AWS KMS. When you create a new AWS principal (for example, an IAM user or role), you
            /// might need to enforce a delay before including the new principal in a key policy because the new
            /// principal might not be immediately visible to AWS KMS. For more information, see Changes that I make
            /// are not always immediately visible in the AWS Identity and Access Management User Guide. The key
            /// policy size limit is 32 kilobytes (32768 bytes).
            /// If you are unsure of which policy to use, consider the default key policy. This is the key policy
            /// that AWS KMS applies to CMKs that are created by using the CreateKey API with no specified key
            /// policy. It gives the AWS account that owns the key permission to perform all operations on the key.
            /// It also allows you write IAM policies to authorize access to the key. For details, see Default Key
            /// Policy in the AWS Key Management Service Developer Guide.
            /// Required: Yes
            /// Type: Json
            /// Minimum: 1
            /// Maximum: 131072
            /// Pattern: [\u0009\u000A\u000D\u0020-\u00FF]+
            /// Update requires: No interruption
            /// </summary>
			public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> KeyPolicy { get; set; }

            /// <summary>
            /// KeyUsage
            /// The cryptographic operations for which you can use the CMK. The only valid value is ENCRYPT_DECRYPT,
            /// which means you can use the CMK to encrypt and decrypt data.
            /// Required: No
            /// Type: String
            /// Allowed Values: ENCRYPT_DECRYPT
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> KeyUsage { get; set; }

            /// <summary>
            /// PendingWindowInDays
            /// Specifies the number of days in the waiting period before AWS KMS deletes a CMK that has been
            /// removed from a CloudFormation stack. Enter a value between 7 and 30 days. The default value is 30
            /// days.
            /// When you remove a customer master key (CMK) from a CloudFormation stack, AWS KMS schedules the CMK
            /// for deletion and starts the mandatory waiting period. The PendingWindowInDays property determines
            /// the length of waiting period. During the waiting period, the key state of CMK is Pending Deletion,
            /// which prevents the CMK from being used in cryptographic operations. When the waiting period expires,
            /// AWS KMS permanently deletes the CMK.
            /// You cannot use a CloudFormation template to cancel deletion of the CMK after you remove it from the
            /// stack, regardless of the waiting period. If you specify a CMK in your template, even one with the
            /// same name, CloudFormation creates a new CMK. To cancel deletion of a CMK, use the AWS KMS console or
            /// the CancelKeyDeletion operation.
            /// For information about the PendingDeletion key state, see How Key State Affects Use of a Customer
            /// Master Key in the AWS Key Management Service Developer Guide. For more information about deleting
            /// CMKs, see the ScheduleKeyDeletion operation in the AWS Key Management Service API Reference and
            /// Deleting Customer Master Keys in the AWS Key Management Service Developer Guide.
            /// Required: No
            /// Type: Integer
            /// Minimum: 1
            /// Maximum: 365
            /// Update requires: No interruption
            /// </summary>
			public Union<int, IntrinsicFunction> PendingWindowInDays { get; set; }

            /// <summary>
            /// Tags
            /// An array of key-value pairs to apply to this resource.
            /// For more information, see Tag.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
			public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::KMS::Key";

        public KeyProperties Properties { get; } = new KeyProperties();

    }

	public static class KeyAttributes
	{
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
	}
}
