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
            /// Type: AliasRoutingConfiguration
            /// Update requires: No interruption
            /// </summary>
			public AliasRoutingConfiguration RoutingConfig { get; set; }

        }

        public string Type { get; } = "AWS::Lambda::Alias";

        public AliasProperties Properties { get; } = new AliasProperties();

		/// <summary>
		/// Use the UpdatePolicy attribute to specify how AWS CloudFormation handles updates to the AWS::AutoScaling::AutoScalingGroup or AWS::Lambda::Alias 
		/// resource.
		/// For AWS::AutoScaling::AutoScalingGroup resources, AWS CloudFormation invokes one of three update policies depending on the type of change you make 
		/// or whether a scheduled action is associated with the Auto Scaling group.
		/// The AutoScalingReplacingUpdate and AutoScalingRollingUpdate policies apply only when you do one or more of the following:
		///   Change the Auto Scaling group's AWS::AutoScaling::LaunchConfiguration.
		///   Change the Auto Scaling group's VPCZoneIdentifier property
		///   Change the Auto Scaling group's LaunchTemplate property
		///   Update an Auto Scaling group that contains instances that don't match the current LaunchConfiguration.
		/// If both the AutoScalingReplacingUpdate and AutoScalingRollingUpdate policies are specified, setting the WillReplace property to true gives 
		/// AutoScalingReplacingUpdate precedence.
		/// The AutoScalingScheduledAction policy applies when you update a stack that includes an Auto Scaling group with an associated scheduled action.
		/// For AWS::Lambda::Alias resources, AWS CloudFormation performs an AWS CodeDeploy deployment when the version changes on the alias.
		/// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-attribute-updatepolicy.html
		/// </summary>
        public UpdatePolicy UpdatePolicy { get; set; }

    }
}
