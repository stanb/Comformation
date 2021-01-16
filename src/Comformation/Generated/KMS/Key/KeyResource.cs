using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.KMS.Key
{
    /// <summary>
    /// AWS::KMS::Key
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
            /// Enabled
            /// Specifies whether the customer master key (CMK) is enabled. Disabled CMKs cannot be used in
            /// cryptographic operations.
            /// When Enabled is true, the key state of the CMK is Enabled. When Enabled is false, the key state of
            /// the CMK is Disabled. The default value is true.
            /// The actual key state of the CMK might be affected by actions taken outside of CloudFormation, such
            /// as running the EnableKey, DisableKey, or ScheduleKeyDeletion operations.
            /// For information about the key states of a CMK, see Key state: Effect on your CMK in the AWS Key
            /// Management Service Developer Guide.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> Enabled { get; set; }

            /// <summary>
            /// EnableKeyRotation
            /// Enables automatic rotation of the key material for the specified customer master key (CMK). By
            /// default, automation key rotation is not enabled.
            /// When you enable automatic rotation, AWS KMS automatically creates new key material for the CMK 365
            /// days after the enable (or reenable) date and every 365 days thereafter. AWS KMS retains all key
            /// material until you delete the CMK.
            /// For detailed information about automatic key rotation, see Rotating customer master keys in the AWS
            /// Key Management Service Developer Guide.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> EnableKeyRotation { get; set; }

            /// <summary>
            /// KeyPolicy
            /// The key policy that authorizes use of the CMK. The key policy must observe the following rules.
            /// The key policy must allow the caller to make a subsequent PutKeyPolicy request on the CMK. This
            /// reduces the risk that the CMK becomes unmanageable. For more information, refer to the scenario in
            /// the Default key policy section of the AWS Key Management Service Developer Guide . Each statement in
            /// the key policy must contain one or more principals. The principals in the key policy must exist and
            /// be visible to AWS KMS. When you create a new AWS principal (for example, an IAM user or role), you
            /// might need to enforce a delay before including the new principal in a key policy because the new
            /// principal might not be immediately visible to AWS KMS. For more information, see Changes that I make
            /// are not always immediately visible in the AWS Identity and Access Management User Guide. The key
            /// policy size limit is 32 kilobytes (32768 bytes).
            /// If you are unsure of which policy to use, consider the default key policy. This is the key policy
            /// that AWS KMS applies to CMKs that are created by using the CreateKey API with no specified key
            /// policy. It gives the AWS account that owns the key permission to perform all operations on the key.
            /// It also allows you write IAM policies to authorize access to the key. For details, see Default key
            /// policy in the AWS Key Management Service Developer Guide.
            /// Minimum: 1
            /// Maximum: 32768
            /// Required: Yes
            /// Type: Json
            /// Update requires: No interruption
            /// </summary>
            public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> KeyPolicy { get; set; }

            /// <summary>
            /// KeyUsage
            /// Determines the cryptographic operations for which you can use the CMK. The default value is
            /// ENCRYPT_DECRYPT. This property is required only for asymmetric CMKs. You can&#39;t change the KeyUsage
            /// value after the CMK is created.
            /// Important If you change the KeyUsage of an existing CMK, the existing CMK is scheduled for deletion
            /// and a new CMK is created with the specified KeyUsage value. While the scheduled deletion is pending,
            /// you can&#39;t use the existing CMK. Unless you cancel the scheduled deletion of the CMK outside of
            /// CloudFormation, all data encrypted under the existing CMK becomes unrecoverable when the CMK is
            /// deleted.
            /// Select only one valid value.
            /// For symmetric CMKs, omit the property or specify ENCRYPT_DECRYPT. For asymmetric CMKs with RSA key
            /// material, specify ENCRYPT_DECRYPT or SIGN_VERIFY. For asymmetric CMKs with ECC key material, specify
            /// SIGN_VERIFY.
            /// Required: No
            /// Type: String
            /// Allowed values: ENCRYPT_DECRYPT | SIGN_VERIFY
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> KeyUsage { get; set; }

            /// <summary>
            /// KeySpec
            /// Specifies the type of CMK to create. The default value, SYMMETRIC_DEFAULT, creates a CMK with a
            /// 256-bit symmetric key for encryption and decryption. For help choosing a key spec for your CMK, see
            /// How to Choose Your CMK Configuration in the AWS Key Management Service Developer Guide.
            /// The KeySpec property (CustomerMasterKeySpec type) determines whether the CMK contains a symmetric
            /// key or an asymmetric key pair. It also determines the encryption algorithms or signing algorithms
            /// that the CMK supports. You can&#39;t change the KeySpec after the CMK is created. To further restrict
            /// the algorithms that can be used with the CMK, use a condition key in its key policy or IAM policy.
            /// For more information, see kms:EncryptionAlgorithm or kms:Signing Algorithm in the AWS Key Management
            /// Service Developer Guide.
            /// Important If you change the KeySpec of an existing CMK, the existing CMK is scheduled for deletion
            /// and a new CMK is created with the specified KeySpec value. While the scheduled deletion is pending,
            /// you can&#39;t use the existing CMK. Unless you cancel the scheduled deletion of the CMK outside of
            /// CloudFormation, all data encrypted under the existing CMK becomes unrecoverable when the CMK is
            /// deleted.
            /// Note AWS services that are integrated with AWS KMS use symmetric CMKs to protect your data. These
            /// services do not support asymmetric CMKs. For help determining whether a CMK is symmetric or
            /// asymmetric, see Identifying Symmetric and Asymmetric CMKs in the AWS Key Management Service
            /// Developer Guide.
            /// AWS KMS supports the following key specs for CMKs:
            /// Symmetric key (default) SYMMETRIC_DEFAULT (AES-256-GCM) Asymmetric RSA key pairs RSA_2048 RSA_3072
            /// RSA_4096 Asymmetric NIST-recommended elliptic curve key pairs ECC_NIST_P256 (secp256r1)
            /// ECC_NIST_P384 (secp384r1) ECC_NIST_P521 (secp521r1) Other asymmetric elliptic curve key pairs
            /// ECC_SECG_P256K1 (secp256k1), commonly used for cryptocurrencies.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> KeySpec { get; set; }

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
            /// An array of key-value pairs to apply to this resource.
            /// Note Tagging or untagging a CMK can allow or deny permission to the CMK. For details, see Using ABAC
            /// in AWS KMS in the AWS Key Management Service Developer Guide.
            /// For information about tags in AWS KMS, see Tagging keys in the AWS Key Management Service Developer
            /// Guide. For information about tags in CloudFormation, see Tag.
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
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> KeyId = new ResourceAttribute<Union<string, IntrinsicFunction>>("KeyId");
    }
}
