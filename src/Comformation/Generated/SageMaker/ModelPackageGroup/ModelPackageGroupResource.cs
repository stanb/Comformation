using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.SageMaker.ModelPackageGroup
{
    /// <summary>
    /// AWS::SageMaker::ModelPackageGroup
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-modelpackagegroup.html
    /// </summary>
    public class ModelPackageGroupResource : ResourceBase
    {
        public class ModelPackageGroupProperties
        {
            /// <summary>
            /// Tags
            /// An array of key-value pairs to apply to this resource.
            /// For more information, see Tag.
            /// Required: No
            /// Type: List of Tag
            /// Maximum: 50
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

            /// <summary>
            /// ModelPackageGroupName
            /// The name of the model group.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 63
            /// Pattern: ^[a-zA-Z0-9](-*[a-zA-Z0-9]){0,62}$
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ModelPackageGroupName { get; set; }

            /// <summary>
            /// ModelPackageGroupDescription
            /// The description for the model group.
            /// Required: No
            /// Type: String
            /// Maximum: 1024
            /// Pattern: [\p{L}\p{M}\p{Z}\p{S}\p{N}\p{P}]*
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ModelPackageGroupDescription { get; set; }

            /// <summary>
            /// ModelPackageGroupPolicy
            /// A resouce policy to control access to a model group. For information about resoure policies, see
            /// Identity-based policies and resource-based policies in the AWS Identity and Access Management User
            /// Guide. .
            /// Required: No
            /// Type: Json
            /// Update requires: No interruption
            /// </summary>
            public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> ModelPackageGroupPolicy { get; set; }

        }

        public string Type { get; } = "AWS::SageMaker::ModelPackageGroup";

        public ModelPackageGroupProperties Properties { get; } = new ModelPackageGroupProperties();

    }

    public static class ModelPackageGroupAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ModelPackageGroupArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("ModelPackageGroupArn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> CreationTime = new ResourceAttribute<Union<string, IntrinsicFunction>>("CreationTime");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ModelPackageGroupStatus = new ResourceAttribute<Union<string, IntrinsicFunction>>("ModelPackageGroupStatus");
    }
}
