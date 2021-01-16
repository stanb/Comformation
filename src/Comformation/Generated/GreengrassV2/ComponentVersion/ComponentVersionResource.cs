using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.GreengrassV2.ComponentVersion
{
    /// <summary>
    /// AWS::GreengrassV2::ComponentVersion
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-greengrassv2-componentversion.html
    /// </summary>
    public class ComponentVersionResource : ResourceBase
    {
        public class ComponentVersionProperties
        {
            /// <summary>
            /// InlineRecipe
            /// The recipe to use to create the component. The recipe defines the component&#39;s metadata, parameters,
            /// dependencies, lifecycle, artifacts, and platform compatibility.
            /// You must specify either InlineRecipe or LambdaFunction.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> InlineRecipe { get; set; }

            /// <summary>
            /// LambdaFunction
            /// The parameters to create a component from a Lambda function.
            /// You must specify either InlineRecipe or LambdaFunction.
            /// Required: No
            /// Type: LambdaFunctionRecipeSource
            /// Update requires: Replacement
            /// </summary>
            public LambdaFunctionRecipeSource LambdaFunction { get; set; }

            /// <summary>
            /// Tags
            /// Application-specific metadata to attach to the component version. You can use tags in IAM policies
            /// to control access to AWS IoT Greengrass resources. You can also use tags to categorize your
            /// resources. For more information, see Tag your AWS IoT Greengrass Version 2 resources in the AWS IoT
            /// Greengrass V2 Developer Guide.
            /// This Json property type is processed as a map of key-value pairs. It uses the following format,
            /// which is different from most Tags implementations in AWS CloudFormation templates.
            /// &quot;Tags&quot;: { &quot;KeyName0&quot;: &quot;value&quot;, &quot;KeyName1&quot;: &quot;value&quot;, &quot;KeyName2&quot;: &quot;value&quot; }
            /// Required: No
            /// Type: Map of String
            /// Update requires: No interruption
            /// </summary>
            public Dictionary<string, Union<string, IntrinsicFunction>> Tags { get; set; }

        }

        public string Type { get; } = "AWS::GreengrassV2::ComponentVersion";

        public ComponentVersionProperties Properties { get; } = new ComponentVersionProperties();

    }

    public static class ComponentVersionAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ComponentName = new ResourceAttribute<Union<string, IntrinsicFunction>>("ComponentName");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ComponentVersion = new ResourceAttribute<Union<string, IntrinsicFunction>>("ComponentVersion");
    }
}
