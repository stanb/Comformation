using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApplicationAutoScaling.ScalingPolicy
{
    /// <summary>
    /// AWS::ApplicationAutoScaling::ScalingPolicy
    /// The AWS::ApplicationAutoScaling::ScalingPolicy resource defines a scaling policy that Application Auto Scaling
    /// uses to adjust your application resources.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-applicationautoscaling-scalingpolicy.html
    /// </summary>
    public class ScalingPolicyResource : ResourceBase
    {
        public class ScalingPolicyProperties
        {
            /// <summary>
            /// PolicyName
            /// The name of the scaling policy.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 256
            /// Pattern: \p{Print}+
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> PolicyName { get; set; }

            /// <summary>
            /// PolicyType
            /// The Application Auto Scaling policy type.
            /// The following policy types are supported:
            /// StepScaling—Not supported for Amazon DynamoDB
            /// TargetTrackingScaling—Not supported for Amazon EMR or AppStream
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> PolicyType { get; set; }

            /// <summary>
            /// ResourceId
            /// The unique resource identifier for the scalable target that this scaling policy applies to. For
            /// valid values, see the ResourceId parameter for PutScalingPolicy in the Application Auto Scaling API
            /// Reference.
            /// You must specify either the ResourceId, ScalableDimension, and ServiceNamespace properties, or the
            /// ScalingTargetId property, but not both.
            /// Required: Conditional
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ResourceId { get; set; }

            /// <summary>
            /// ScalableDimension
            /// The scalable dimension of the scalable target that this scaling policy applies to. The scalable
            /// dimension contains the service namespace, resource type, and scaling property, such as
            /// ecs:service:DesiredCount for the desired task count of an Amazon ECS service. For valid values, see
            /// the ScalableDimension parameter for PutScalingPolicy in the Application Auto Scaling API Reference.
            /// You must specify either the ResourceId, ScalableDimension, and ServiceNamespace properties, or the
            /// ScalingTargetId property, but not both.
            /// Required: Conditional
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ScalableDimension { get; set; }

            /// <summary>
            /// ScalingTargetId
            /// The AWS CloudFormation-generated ID of an Application Auto Scaling scalable target. For more
            /// information about the ID, see the Return Value section of the
            /// AWS::ApplicationAutoScaling::ScalableTarget resource.
            /// You must specify either the ScalingTargetId property, or the ResourceId, ScalableDimension, and
            /// ServiceNamespace properties, but not both.
            /// Required: Conditional
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ScalingTargetId { get; set; }

            /// <summary>
            /// ServiceNamespace
            /// The namespace of the AWS service that provides the resource or custom-resource for a resource
            /// provided by your own application or service. For valid values, see the ServiceNamespace parameter
            /// for PutScalingPolicy in the Application Auto Scaling API Reference.
            /// You must specify either the ResourceId, ScalableDimension, and ServiceNamespace properties, or the
            /// ScalingTargetId property, but not both.
            /// Required: Conditional
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ServiceNamespace { get; set; }

            /// <summary>
            /// StepScalingPolicyConfiguration
            /// A step scaling policy.
            /// Required: No
            /// Type: StepScalingPolicyConfiguration
            /// Update requires: No interruption
            /// </summary>
			public StepScalingPolicyConfiguration StepScalingPolicyConfiguration { get; set; }

            /// <summary>
            /// TargetTrackingScalingPolicyConfiguration
            /// A target tracking scaling policy.
            /// Required: No
            /// Type: TargetTrackingScalingPolicyConfiguration
            /// Update requires: No interruption
            /// </summary>
			public TargetTrackingScalingPolicyConfiguration TargetTrackingScalingPolicyConfiguration { get; set; }

        }

        public string Type { get; } = "AWS::ApplicationAutoScaling::ScalingPolicy";

        public ScalingPolicyProperties Properties { get; } = new ScalingPolicyProperties();

    }
}
