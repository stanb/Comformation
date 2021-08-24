using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.SageMaker.App
{
    /// <summary>
    /// AWS::SageMaker::App
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-app.html
    /// </summary>
    public class AppResource : ResourceBase
    {
        public class AppProperties
        {
            /// <summary>
            /// AppName
            /// The name of the app.
            /// Required: Yes
            /// Type: String
            /// Maximum: 63
            /// Pattern: ^[a-zA-Z0-9](-*[a-zA-Z0-9]){0,62}
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> AppName { get; set; }

            /// <summary>
            /// AppType
            /// The type of app.
            /// Required: Yes
            /// Type: String
            /// Allowed values: JupyterServer | KernelGateway | TensorBoard
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> AppType { get; set; }

            /// <summary>
            /// DomainId
            /// The domain ID.
            /// Required: Yes
            /// Type: String
            /// Maximum: 63
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> DomainId { get; set; }

            /// <summary>
            /// ResourceSpec
            /// Specifies the ARN&#39;s of a SageMaker image and SageMaker image version, and the instance type that the
            /// version runs on.
            /// Required: No
            /// Type: ResourceSpec
            /// Update requires: No interruption
            /// </summary>
            public ResourceSpec ResourceSpec { get; set; }

            /// <summary>
            /// Tags
            /// An array of key-value pairs to apply to this resource.
            /// For more information, see Tag.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: Replacement
            /// </summary>
            public List<Tag> Tags { get; set; }

            /// <summary>
            /// UserProfileName
            /// The user profile name.
            /// Required: Yes
            /// Type: String
            /// Maximum: 63
            /// Pattern: ^[a-zA-Z0-9](-*[a-zA-Z0-9]){0,62}
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> UserProfileName { get; set; }

        }

        public string Type { get; } = "AWS::SageMaker::App";

        public AppProperties Properties { get; } = new AppProperties();

    }

    public static class AppAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> AppArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("AppArn");
    }
}
