using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.KMS.Key
{
    /// <summary>
    /// AWS::KMS::Key
    /// The AWS::KMS::Key resource creates a customer master key (CMK) in AWS Key Management Service (AWS KMS). Users
    /// (customers) can use the master key to encrypt their data stored in AWS services that are integrated with AWS
    /// KMS or within their applications. For more information, see What is the AWS Key Management Service? in the AWS
    /// Key Management Service Developer Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kms-key.html
    /// </summary>
    public class KeyResource : ResourceBase
    {
        public class KeyProperties
        {
            /// <summary>
            /// Description
            /// A description of the key. Use a description that helps your users decide whether the key is
            /// appropriate for a particular task.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// EnableKeyRotation
            /// Indicates whether AWS KMS rotates the key. AWS CloudFormation sets this value to false by default.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
			public Union<bool, IntrinsicFunction> EnableKeyRotation { get; set; }

            /// <summary>
            /// Enabled
            /// Indicates whether the key is available for use. AWS CloudFormation sets this value to true by
            /// default.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
			public Union<bool, IntrinsicFunction> Enabled { get; set; }

            /// <summary>
            /// KeyPolicy
            /// An AWS KMS key policy to attach to the key. Use a policy to specify who has permission to use the
            /// key and which actions they can perform. For more information, see Key Policies in the AWS Key
            /// Management Service Developer Guide.
            /// Required: Yes
            /// Type: JSON object
            /// Update requires: No interruption
            /// </summary>
			public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> KeyPolicy { get; set; }

            /// <summary>
            /// KeyUsage
            /// The intended use of the key. You can use CMKs only for symmetric encryption and decryption.
            /// Valid values: ENCRYPT_DECRYPT
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> KeyUsage { get; set; }

            /// <summary>
            /// PendingWindowInDays
            /// The waiting period, specified in number of days. After the waiting period ends, AWS KMS deletes the
            /// customer master key (CMK).
            /// Valid Range: Minimum value of 7. Maximum value of 30.
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
			public Union<int, IntrinsicFunction> PendingWindowInDays { get; set; }

            /// <summary>
            /// Tags
            /// Specifies an arbitrary set of tags (key–value pairs) to associate with this key. Use tags to manage
            /// your resources.
            /// Required: No
            /// Type: Resource Tag
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
