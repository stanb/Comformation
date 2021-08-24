using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.IAM.VirtualMFADevice
{
    /// <summary>
    /// AWS::IAM::VirtualMFADevice
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iam-virtualmfadevice.html
    /// </summary>
    public class VirtualMFADeviceResource : ResourceBase
    {
        public class VirtualMFADeviceProperties
        {
            /// <summary>
            /// VirtualMfaDeviceName
            /// The name of the virtual MFA device. Use with path to uniquely identify a virtual MFA device.
            /// This parameter allows (through its regex pattern) a string of characters consisting of upper and
            /// lowercase alphanumeric characters with no spaces. You can also include any of the following
            /// characters: _+=,. @-
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Pattern: [\w+=,. @-]+
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> VirtualMfaDeviceName { get; set; }

            /// <summary>
            /// Path
            /// The path for the virtual MFA device. For more information about paths, see IAM identifiers in the
            /// IAM User Guide.
            /// This parameter is optional. If it is not included, it defaults to a slash (/).
            /// This parameter allows (through its regex pattern) a string of characters consisting of either a
            /// forward slash (/) by itself or a string that must begin and end with forward slashes. In addition,
            /// it can contain any ASCII character from the ! (\u0021) through the DEL character (\u007F), including
            /// most punctuation characters, digits, and upper and lowercased letters.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 512
            /// Pattern: (\u002F)|(\u002F[\u0021-\u007F]+\u002F)
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Path { get; set; }

            /// <summary>
            /// Users
            /// The IAM user associated with this virtual MFA device.
            /// Required: Yes
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> Users { get; set; }

            /// <summary>
            /// Tags
            /// A list of tags that you want to attach to the new IAM virtual MFA device. Each tag consists of a key
            /// name and an associated value. For more information about tagging, see Tagging IAM resources in the
            /// IAM User Guide.
            /// Note If any one of the tags is invalid or if you exceed the allowed maximum number of tags, then the
            /// entire request fails and the resource is not created.
            /// Required: No
            /// Type: List of Tag
            /// Maximum: 50
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::IAM::VirtualMFADevice";

        public VirtualMFADeviceProperties Properties { get; } = new VirtualMFADeviceProperties();

    }

    public static class VirtualMFADeviceAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> SerialNumber = new ResourceAttribute<Union<string, IntrinsicFunction>>("SerialNumber");
    }
}
