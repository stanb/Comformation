using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApplicationAutoScaling.ScalableTarget
{
    /// <summary>
    /// AWS::ApplicationAutoScaling::ScalableTarget
    /// The AWS::ApplicationAutoScaling::ScalableTarget resource specifies a resource that Application Auto Scaling
    /// can scale up or down. For more information, see the RegisterScalableTarget action in the Application Auto
    /// Scaling API Reference.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-applicationautoscaling-scalabletarget.html
    /// </summary>
    public class ScalableTargetResource : ResourceBase
    {
        public class ScalableTargetProperties
        {
            /// <summary>
            /// MaxCapacity
            /// The maximum value that Application Auto Scaling can use to scale a target during a scaling activity.
            /// Required: Yes
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
			public Union<int, IntrinsicFunction> MaxCapacity { get; set; }

            /// <summary>
            /// MinCapacity
            /// The minimum value that Application Auto Scaling can use to scale a target during a scaling activity.
            /// Required: Yes
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
			public Union<int, IntrinsicFunction> MinCapacity { get; set; }

            /// <summary>
            /// ResourceId
            /// The resource identifier to associate with this scalable target. This string consists of the resource
            /// type and unique identifier. For more information, see the ResourceId parameter for the
            /// RegisterScalableTarget action in the Application Auto Scaling API Reference, or see the
            /// ScalableTarget examples.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ResourceId { get; set; }

            /// <summary>
            /// RoleARN
            /// The Amazon Resource Name (ARN) of an AWS Identity and Access Management (IAM) role that allows
            /// Application Auto Scaling to modify your scalable target.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> RoleARN { get; set; }

            /// <summary>
            /// ScalableDimension
            /// The scalable dimension that&#39;s associated with the scalable target. Specify the service namespace,
            /// resource type, and scaling property—for example, ecs:service:DesiredCount for the desired task count
            /// of an Amazon Elastic Container Service service. For valid values, see the ScalableDimension content
            /// for the ScalingPolicy data type in the Application Auto Scaling API Reference.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ScalableDimension { get; set; }

            /// <summary>
            /// ScheduledActions
            /// The scheduled actions for the scalable target. Duplicates aren&#39;t allowed.
            /// Required: No
            /// Type: List of Application Auto Scaling ScalableTarget ScheduledAction property types
            /// Update requires: No interruption
            /// </summary>
			public Union<List<ScheduledAction>, IntrinsicFunction> ScheduledActions { get; set; }

            /// <summary>
            /// ServiceNamespace
            /// The AWS service namespace of the scalable target. For a list of service namespaces, see AWS Service
            /// Namespaces in the AWS General Reference.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ServiceNamespace { get; set; }

        }
    
        public string Type { get; } = "AWS::ApplicationAutoScaling::ScalableTarget";
        
        public ScalableTargetProperties Properties { get; } = new ScalableTargetProperties();
    }
}
