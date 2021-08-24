using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.RAM.ResourceShare
{
    /// <summary>
    /// AWS::RAM::ResourceShare
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ram-resourceshare.html
    /// </summary>
    public class ResourceShareResource : ResourceBase
    {
        public class ResourceShareProperties
        {
            /// <summary>
            /// PermissionArns
            /// The Amazon Resource Names (ARNs) of the permissions to associate with the resource share. If you do
            /// not specify an ARN 			for the permission, AWS RAM automatically attaches the default version of the
            /// permission 			for each resource type. Only one permission can be associated with each resource type
            /// in a resource share.
            /// Required: No
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> PermissionArns { get; set; }

            /// <summary>
            /// Principals
            /// The principals to associate with the resource share. The possible values are:
            /// An AWS account ID An Amazon Resource Name (ARN) of an organization in AWS Organizations An ARN of an
            /// organizational unit (OU) in AWS Organizations An ARN of an IAM role An ARN of an IAM user
            /// Note Not all resource types can be shared with IAM roles and IAM users. For more information, see
            /// Sharing with IAM roles and IAM users in the AWS Resource Access Manager User Guide.
            /// Required: No
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> Principals { get; set; }

            /// <summary>
            /// AllowExternalPrincipals
            /// Indicates whether principals outside your organization in AWS Organizations can be associated with a
            /// resource share.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> AllowExternalPrincipals { get; set; }

            /// <summary>
            /// ResourceArns
            /// The Amazon Resource Names (ARNs) of the resources to associate with the resource share.
            /// Required: No
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> ResourceArns { get; set; }

            /// <summary>
            /// Tags
            /// One or more tags.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

            /// <summary>
            /// Name
            /// The name of the resource share.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

        }

        public string Type { get; } = "AWS::RAM::ResourceShare";

        public ResourceShareProperties Properties { get; } = new ResourceShareProperties();

    }

    public static class ResourceShareAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
    }
}
