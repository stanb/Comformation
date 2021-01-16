using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Lambda.Alias
{
    /// <summary>
    /// AWS::Lambda::Alias
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-alias.html
    /// </summary>
    public class AliasResource : ResourceBase
    {
        public class AliasProperties
        {
            /// <summary>
            /// Description
            /// A description of the alias.
            /// Required: No
            /// Type: String
            /// Minimum: 0
            /// Maximum: 256
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// FunctionName
            /// The name of the Lambda function.
            /// Name formats Function name - MyFunction. Function ARN -
            /// arn:aws:lambda:us-west-2:123456789012:function:MyFunction. Partial ARN -
            /// 123456789012:function:MyFunction.
            /// The length constraint applies only to the full ARN. If you specify only the function name, it is
            /// limited to 64 characters in length.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 140
            /// Pattern:
            /// (arn:(aws[a-zA-Z-]*)?:lambda:)?([a-z]{2}(-gov)?-[a-z]+-\d{1}:)?(\d{12}:)?(function:)?([a-zA-Z0-9-_]+)(:(\$LATEST|[a-zA-Z0-9-_]+))?
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> FunctionName { get; set; }

            /// <summary>
            /// FunctionVersion
            /// The function version that the alias invokes.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 1024
            /// Pattern: (\$LATEST|[0-9]+)
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> FunctionVersion { get; set; }

            /// <summary>
            /// Name
            /// The name of the alias.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 128
            /// Pattern: (?!^[0-9]+$)([a-zA-Z0-9-_]+)
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// ProvisionedConcurrencyConfig
            /// Specifies a provisioned concurrency configuration for a function&#39;s alias.
            /// Required: No
            /// Type: ProvisionedConcurrencyConfiguration
            /// Update requires: No interruption
            /// </summary>
            public ProvisionedConcurrencyConfiguration ProvisionedConcurrencyConfig { get; set; }

            /// <summary>
            /// RoutingConfig
            /// The routing configuration of the alias.
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
