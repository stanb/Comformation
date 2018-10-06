using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApplicationAutoScaling.ScalingPolicy
{
    /// <summary>
    /// AWS::ApplicationAutoScaling::ScalingPolicy
    /// The AWS::ApplicationAutoScaling::ScalingPolicy resource defines an Application Auto Scaling scaling policy
    /// that Application Auto Scaling uses to adjust your application resources.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-applicationautoscaling-scalingpolicy.html
    /// </summary>
    public class ScalingPolicyResource : ResourceBase
    {
        public class ScalingPolicyProperties
        {
            /// <summary>
            /// PolicyName
            /// A name for the scaling policy.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> PolicyName { get; set; }

            /// <summary>
            /// PolicyType
            /// An Application Auto Scaling policy type.
            /// Note For DynamoDB, only TargetTrackingScaling is supported. For Amazon ECS, Spot Fleet, and Amazon
            /// RDS, both StepScaling and TargetTrackingScaling are supported. For any other service, only
            /// StepScaling is supported.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> PolicyType { get; set; }

            /// <summary>
            /// ResourceId
            /// The unique resource identifier for the scalable target that this scaling policy applies to. For more
            /// information, see the ResourceId parameter for the PutScalingPolicy action in the Application Auto
            /// Scaling API Reference.
            /// Required: Conditional. You must specify either the ScalingTargetId property or the ResourceId,
            /// ScalableDimension, and ServiceNamespace properties. If you specify the ResourceId,
            /// ScalableDimension, and ServiceNamespace properties, don&#39;t specify the ScalingTargetId property.
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ResourceId { get; set; }

            /// <summary>
            /// ScalableDimension
            /// The scalable dimension of the scalable target that this scaling policy applies to. The scalable
            /// dimension contains the service namespace, resource type, and scaling property, such as
            /// ecs:service:DesiredCount for the desired task count of an Amazon ECS service.
            /// Required: Conditional. You must specify either the ScalingTargetId property or the ResourceId,
            /// ScalableDimension, and ServiceNamespace properties. If you specify the ResourceId,
            /// ScalableDimension, and ServiceNamespace properties, don&#39;t specify the ScalingTargetId property.
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ScalableDimension { get; set; }

            /// <summary>
            /// ScalingTargetId
            /// The AWS CloudFormation-generated ID of an Application Auto Scaling scalable target. For more
            /// information about the ID, see the Return Value section of the
            /// AWS::ApplicationAutoScaling::ScalableTarget resource.
            /// Required: Conditional. You must specify either the ScalingTargetId property or the ResourceId,
            /// ScalableDimension, and ServiceNamespace properties. If you specify this property, don&#39;t specify the
            /// ResourceId, ScalableDimension, and ServiceNamespace properties.
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ScalingTargetId { get; set; }

            /// <summary>
            /// ServiceNamespace
            /// The AWS service namespace of the scalable target that this scaling policy applies to. For a list of
            /// service namespaces, see AWS Service Namespaces in the AWS General Reference.
            /// Required: Conditional. You must specify either the ScalingTargetId property or the ResourceId,
            /// ScalableDimension, and ServiceNamespace properties. If you specify the ResourceId,
            /// ScalableDimension, and ServiceNamespace properties, don&#39;t specify the ScalingTargetId property.
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ServiceNamespace { get; set; }

            /// <summary>
            /// StepScalingPolicyConfiguration
            /// A step policy that configures when Application Auto Scaling scales resources up or down, and by how
            /// much.
            /// Required: No
            /// Type: Application Auto Scaling ScalingPolicy StepScalingPolicyConfiguration
            /// Update requires: No interruption
            /// </summary>
			public StepScalingPolicyConfiguration StepScalingPolicyConfiguration { get; set; }

            /// <summary>
            /// TargetTrackingScalingPolicyConfiguration
            /// Configures a target tracking scaling policy.
            /// This parameter is required if you are creating a new policy and the policy type is
            /// TargetTrackingScaling.
            /// Required: No
            /// Type: Application Auto Scaling ScalingPolicy TargetTrackingScalingPolicyConfiguration
            /// Update requires: No interruption
            /// </summary>
			public TargetTrackingScalingPolicyConfiguration TargetTrackingScalingPolicyConfiguration { get; set; }

        }
    
        public string Type { get; } = "AWS::ApplicationAutoScaling::ScalingPolicy";
        
        public ScalingPolicyProperties Properties { get; } = new ScalingPolicyProperties();

    }
}
