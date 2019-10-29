using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApplicationAutoScaling.ScalableTarget
{
    /// <summary>
    /// AWS::ApplicationAutoScaling::ScalableTarget
    /// The AWS::ApplicationAutoScaling::ScalableTarget resource specifies a resource that Application Auto Scaling
    /// can scale.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-applicationautoscaling-scalabletarget.html
    /// </summary>
    public class ScalableTargetResource : ResourceBase
    {
        public class ScalableTargetProperties
        {
            /// <summary>
            /// MaxCapacity
            /// The maximum value to scale to in response to a scale-out event.
            /// Required: Yes
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
			public Union<int, IntrinsicFunction> MaxCapacity { get; set; }

            /// <summary>
            /// MinCapacity
            /// The minimum value to scale to in response to a scale-in event.
            /// Required: Yes
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
			public Union<int, IntrinsicFunction> MinCapacity { get; set; }

            /// <summary>
            /// ResourceId
            /// The resource identifier to associate with this scalable target. This string consists of the resource
            /// type and unique identifier. For valid values, see the ResourceId parameter for
            /// RegisterScalableTarget in the Application Auto Scaling API Reference.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ResourceId { get; set; }

            /// <summary>
            /// RoleARN
            /// The Amazon Resource Name (ARN) of an AWS Identity and Access Management (IAM) role that allows
            /// Application Auto Scaling to modify the scalable target on your behalf.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> RoleARN { get; set; }

            /// <summary>
            /// ScalableDimension
            /// The scalable dimension that is associated with the scalable target. Specify the service namespace,
            /// resource type, and scaling property, for example, ecs:service:DesiredCount for the desired task
            /// count of an Amazon ECS service. For valid values, see the ScalableDimension parameter for
            /// RegisterScalableTarget in the Application Auto Scaling API Reference.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ScalableDimension { get; set; }

            /// <summary>
            /// ScheduledActions
            /// The scheduled actions for the scalable target. Duplicates aren&#39;t allowed.
            /// Required: No
            /// Type: List of ScheduledAction
            /// Update requires: No interruption
            /// </summary>
			public List<ScheduledAction> ScheduledActions { get; set; }

            /// <summary>
            /// ServiceNamespace
            /// The namespace of the AWS service that provides the resource or custom-resource for a resource
            /// provided by your own application or service. For valid values, see the ServiceNamespace parameter
            /// for RegisterScalableTarget in the Application Auto Scaling API Reference.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ServiceNamespace { get; set; }

            /// <summary>
            /// SuspendedState
            /// An embedded object that contains attributes and attribute values that are used to suspend and resume
            /// automatic scaling. Setting the value of an attribute to true suspends the specified scaling
            /// activities. Setting it to false (default) resumes the specified scaling activities.
            /// Suspension Outcomes
            /// For DynamicScalingInSuspended, while a suspension is in effect, all scale-in activities that are
            /// triggered by a scaling policy are suspended. For DynamicScalingOutSuspended, while a suspension is
            /// in effect, all scale-out activities that are triggered by a scaling policy are suspended. For
            /// ScheduledScalingSuspended, while a suspension is in effect, all scaling activities that involve
            /// scheduled actions are suspended.
            /// For more information, see Suspend and Resume Application Auto Scaling in the Application Auto
            /// Scaling User Guide.
            /// Required: No
            /// Type: SuspendedState
            /// Update requires: No interruption
            /// </summary>
			public SuspendedState SuspendedState { get; set; }

        }

        public string Type { get; } = "AWS::ApplicationAutoScaling::ScalableTarget";

        public ScalableTargetProperties Properties { get; } = new ScalableTargetProperties();

    }
}
