using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EKS.Addon
{
    /// <summary>
    /// AWS::EKS::Addon
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eks-addon.html
    /// </summary>
    public class AddonResource : ResourceBase
    {
        public class AddonProperties
        {
            /// <summary>
            /// ClusterName
            /// The name of the cluster.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 100
            /// Pattern: ^[0-9A-Za-z][A-Za-z0-9\-_]*
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ClusterName { get; set; }

            /// <summary>
            /// AddonName
            /// The name of the add-on.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> AddonName { get; set; }

            /// <summary>
            /// AddonVersion
            /// The version of the add-on.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> AddonVersion { get; set; }

            /// <summary>
            /// ResolveConflicts
            /// How to resolve parameter value conflicts when migrating an existing add-on to an Amazon EKS add-on.
            /// Required: No
            /// Type: String
            /// Allowed values: NONE | OVERWRITE
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> ResolveConflicts { get; set; }

            /// <summary>
            /// ServiceAccountRoleArn
            /// The Amazon Resource Name (ARN) of an existing IAM role to bind to the add-on&#39;s service account. The
            /// role must be assigned the IAM permissions required by the add-on. If you don&#39;t specify an existing
            /// IAM role, then the add-on uses the permissions assigned to the node IAM role. For more information,
            /// see Amazon EKS node IAM role in the Amazon EKS User Guide.
            /// Note To specify an existing IAM role, you must have an IAM OpenID Connect (OIDC) provider created
            /// for your cluster. For more information, see Enabling IAM roles for service accounts on your cluster
            /// in the Amazon EKS User Guide.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 255
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> ServiceAccountRoleArn { get; set; }

            /// <summary>
            /// Tags
            /// The metadata that you apply to the add-on to assist with categorization and organization. Each tag
            /// consists of a key and an optional value, both of which you define. Add-on tags do not propagate to
            /// any other resources associated with the cluster.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::EKS::Addon";

        public AddonProperties Properties { get; } = new AddonProperties();

    }

    public static class AddonAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
    }
}
