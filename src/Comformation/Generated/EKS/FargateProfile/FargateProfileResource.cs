using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EKS.FargateProfile
{
    /// <summary>
    /// AWS::EKS::FargateProfile
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eks-fargateprofile.html
    /// </summary>
    public class FargateProfileResource : ResourceBase
    {
        public class FargateProfileProperties
        {
            /// <summary>
            /// ClusterName
            /// The name of the Amazon EKS cluster to apply the Fargate profile to.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ClusterName { get; set; }

            /// <summary>
            /// FargateProfileName
            /// The name of the Fargate profile.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> FargateProfileName { get; set; }

            /// <summary>
            /// PodExecutionRoleArn
            /// The Amazon Resource Name (ARN) of the pod execution role to use for pods that match the selectors in
            /// the Fargate profile. The pod execution role allows Fargate infrastructure to register with your
            /// cluster as a node, and it provides read access to Amazon ECR image repositories. For more
            /// information, see Pod Execution Role in the Amazon EKS User Guide.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> PodExecutionRoleArn { get; set; }

            /// <summary>
            /// Subnets
            /// The IDs of subnets to launch your pods into. At this time, pods running on Fargate are not assigned
            /// public IP addresses, so only private subnets (with no direct route to an Internet Gateway) are
            /// accepted for this parameter.
            /// Required: No
            /// Type: List of String
            /// Update requires: Replacement
            /// </summary>
            public List<Union<string, IntrinsicFunction>> Subnets { get; set; }

            /// <summary>
            /// Selectors
            /// The selectors to match for pods to use this Fargate profile. Each selector must have an associated
            /// namespace. Optionally, you can also specify labels for a namespace. You may specify up to five
            /// selectors in a Fargate profile.
            /// Required: Yes
            /// Type: List of Selector
            /// Update requires: Replacement
            /// </summary>
            public List<Selector> Selectors { get; set; }

            /// <summary>
            /// Tags
            /// The metadata to apply to the Fargate profile to assist with categorization and organization. Each
            /// tag consists of a key and an optional value, both of which you define. Fargate profile tags do not
            /// propagate to any other resources associated with the Fargate profile, such as the pods that are
            /// scheduled with it.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::EKS::FargateProfile";

        public FargateProfileProperties Properties { get; } = new FargateProfileProperties();

    }

    public static class FargateProfileAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
    }
}
