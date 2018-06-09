using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Lambda.Alias
{
    /// <summary>
    /// AWS::Lambda::Alias
    /// The AWS::Lambda::Alias resource creates an alias that points to the version of an AWS Lambda (Lambda) function
    /// that you specify. Use aliases when you want to control which version of your function other services or
    /// applications invoke. Those services or applications can use your function&#39;s alias so that they don&#39;t need to
    /// be updated whenever you release a new version of your function. For more information, see Introduction to AWS
    /// Lambda Aliases in the AWS Lambda Developer Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-alias.html
    /// </summary>
    public class AliasResource : ResourceBase
    {
        public class AliasProperties
        {
            /// <summary>
            /// Description
            /// Information about the alias, such as its purpose or the Lambda function that is associated with it.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// FunctionName
            /// The Lambda function that you want to associate with this alias. You can specify the function&#39;s name
            /// or its Amazon Resource Name (ARN).
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> FunctionName { get; set; }

            /// <summary>
            /// FunctionVersion
            /// The version of the Lambda function that you want to associate with this alias.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> FunctionVersion { get; set; }

            /// <summary>
            /// Name
            /// A name for the alias.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// RoutingConfig
            /// Use this parameter to point your alias to two different function versions, allowing you to dictate
            /// what percentage of traffic will invoke each version. For more information, see Routing Traffic to
            /// Different Function Versions Using Aliases in the AWS Lambda Developer Guide.
            /// Required: No
            /// Type: AWS Lambda Alias AliasRoutingConfiguration
            /// Update requires: No interruption
            /// </summary>
			public Union<AliasRoutingConfiguration, IntrinsicFunction> RoutingConfig { get; set; }

        }
    
        public string Type { get; } = "AWS::Lambda::Alias";
        
        public AliasProperties Properties { get; } = new AliasProperties();
    }
}
