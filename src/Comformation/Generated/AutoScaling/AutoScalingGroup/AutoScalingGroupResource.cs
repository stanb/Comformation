using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.AutoScaling.AutoScalingGroup
{
    /// <summary>
    /// AWS::AutoScaling::AutoScalingGroup
    /// Defines an Amazon EC2 Auto Scaling group with the specified name and attributes.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-group.html
    /// </summary>
    public class AutoScalingGroupResource : ResourceBase
    {
        public class AutoScalingGroupProperties
        {
            /// <summary>
            /// AutoScalingGroupName
            /// The name of the Auto Scaling group. This name must be unique per Region per account.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 255
            /// Pattern: [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> AutoScalingGroupName { get; set; }

            /// <summary>
            /// AvailabilityZones
            /// A list of Availability Zones for the group. You must specify one of the following properties:
            /// VPCZoneIdentifier or AvailabilityZones.
            /// If your account supports EC2-Classic and VPC, this property is required to create an Auto Scaling
            /// group that launches instances into EC2-Classic.
            /// Required: Conditional
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
			public List<Union<string, IntrinsicFunction>> AvailabilityZones { get; set; }

            /// <summary>
            /// Cooldown
            /// The amount of time, in seconds, after a scaling activity completes before another scaling activity
            /// can start. The default value is 300.
            /// Used only when a scaling-specific cooldown is not specified and not supported for target tracking
            /// scaling policies, step scaling policies, or scheduled scaling. For more information, see Scaling
            /// Cooldowns in the Amazon EC2 Auto Scaling User Guide.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Cooldown { get; set; }

            /// <summary>
            /// DesiredCapacity
            /// The number of Amazon EC2 instances that the Auto Scaling group attempts to maintain. The number must
            /// be greater than or equal to the minimum size of the group and less than or equal to the maximum size
            /// of the group. If you do not specify a desired capacity, the default is the minimum size of the
            /// group.
            /// CloudFormation marks the Auto Scaling group as successful (by setting its status to CREATE_COMPLETE)
            /// when the desired capacity is reached. However, if SpotPrice is set in the launch configuration, then
            /// desired capacity is not used as a criteria for success, because whether your request is fulfilled
            /// depends on Spot Instance capacity and your maximum price. If the current Spot price is less than
            /// your specified maximum price, Amazon EC2 Auto Scaling uses DesiredCapacity as the target capacity
            /// for the group.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> DesiredCapacity { get; set; }

            /// <summary>
            /// HealthCheckGracePeriod
            /// The amount of time, in seconds, that Amazon EC2 Auto Scaling waits before checking the health status
            /// of an EC2 instance that has come into service. The default value is 0.
            /// For more information, see Health Checks for Auto Scaling Instances in the Amazon EC2 Auto Scaling
            /// User Guide.
            /// If you are adding an ELB health check, you must specify this property.
            /// Required: Conditional
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
			public Union<int, IntrinsicFunction> HealthCheckGracePeriod { get; set; }

            /// <summary>
            /// HealthCheckType
            /// The service to use for the health checks. The valid values are EC2 (default) and ELB. If you
            /// configure an Auto Scaling group to use ELB health checks, it considers the instance unhealthy if it
            /// fails either the EC2 status checks or the load balancer health checks.
            /// For more information, see Health Checks for Auto Scaling Instances in the Amazon EC2 Auto Scaling
            /// User Guide.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 32
            /// Pattern: [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> HealthCheckType { get; set; }

            /// <summary>
            /// InstanceId
            /// The ID of the instance used to create a launch configuration for the group.
            /// When you specify an ID of an instance, Amazon EC2 Auto Scaling creates a new launch configuration
            /// and associates it with the Auto Scaling group. The new launch configuration derives all its
            /// properties from the instance, with the exception of BlockDeviceMapping and AssociatePublicIpAddress.
            /// For more information, see Create an Auto Scaling Group Using an EC2 Instance in the Amazon EC2 Auto
            /// Scaling User Guide.
            /// You must specify one of the following properties: LaunchConfigurationName, LaunchTemplate,
            /// InstanceId, or MixedInstancesPolicy.
            /// Required: Conditional
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> InstanceId { get; set; }

            /// <summary>
            /// LaunchConfigurationName
            /// The name of the LaunchConfiguration to use to launch instances.
            /// You must specify one of the following properties: LaunchConfigurationName, LaunchTemplate,
            /// InstanceId, or MixedInstancesPolicy.
            /// Note When you update LaunchConfigurationName, existing Amazon EC2 instances continue to run with the
            /// configuration that they were originally launched with. To update existing instances, specify an
            /// UpdatePolicy attribute for the Auto Scaling group.
            /// Required: Conditional
            /// Type: String
            /// Minimum: 1
            /// Maximum: 255
            /// Pattern: [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> LaunchConfigurationName { get; set; }

            /// <summary>
            /// LaunchTemplate
            /// The LaunchTemplate to use to launch instances.
            /// You must specify one of the following properties: LaunchConfigurationName, LaunchTemplate,
            /// InstanceId, or MixedInstancesPolicy.
            /// Note When you update LaunchTemplate, existing Amazon EC2 instances continue to run with the
            /// configuration that they were originally launched with. To update existing instances, specify an
            /// UpdatePolicy attribute for the Auto Scaling group.
            /// Required: Conditional
            /// Type: LaunchTemplateSpecification
            /// Update requires: No interruption
            /// </summary>
			public LaunchTemplateSpecification LaunchTemplate { get; set; }

            /// <summary>
            /// LifecycleHookSpecificationList
            /// The lifecycle hooks for the group, which specify actions to perform when Amazon EC2 Auto Scaling
            /// launches or terminates instances.
            /// Required: No
            /// Type: List of LifecycleHookSpecification
            /// Update requires: No interruption
            /// </summary>
			public List<LifecycleHookSpecification> LifecycleHookSpecificationList { get; set; }

            /// <summary>
            /// LoadBalancerNames
            /// A list of Classic Load Balancers associated with this Auto Scaling group. For Application Load
            /// Balancers and Network Load Balancers, specify a list of target groups using the TargetGroupARNs
            /// property instead.
            /// For more information, see Using a Load Balancer with an Auto Scaling Group in the Amazon EC2 Auto
            /// Scaling User Guide.
            /// Required: No
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
			public List<Union<string, IntrinsicFunction>> LoadBalancerNames { get; set; }

            /// <summary>
            /// MaxSize
            /// The maximum number of Amazon EC2 instances in the Auto Scaling group.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> MaxSize { get; set; }

            /// <summary>
            /// MetricsCollection
            /// Enables the monitoring of group metrics of an Auto Scaling group. By default, these metrics are
            /// disabled.
            /// Required: No
            /// Type: List of MetricsCollection
            /// Update requires: No interruption
            /// </summary>
			public List<MetricsCollection> MetricsCollection { get; set; }

            /// <summary>
            /// MinSize
            /// The minimum number of Amazon EC2 instances in the Auto Scaling group.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> MinSize { get; set; }

            /// <summary>
            /// MixedInstancesPolicy
            /// An embedded object that specifies a mixed instances policy.
            /// The policy includes properties that not only define the distribution of On-Demand Instances and Spot
            /// Instances, the maximum price to pay for Spot Instances, and how the Auto Scaling group allocates
            /// instance types to fulfill On-Demand and Spot capacity, but also the properties that specify the
            /// instance configuration information—the launch template and instance types.
            /// For more information, see Auto Scaling Groups with Multiple Instance Types and Purchase Options in
            /// the Amazon EC2 Auto Scaling User Guide.
            /// You must specify one of the following properties: LaunchConfigurationName, LaunchTemplate,
            /// InstanceId, or MixedInstancesPolicy.
            /// Required: Conditional
            /// Type: MixedInstancesPolicy
            /// Update requires: No interruption
            /// </summary>
			public MixedInstancesPolicy MixedInstancesPolicy { get; set; }

            /// <summary>
            /// NotificationConfigurations
            /// Configures an Auto Scaling group to send notifications when specified events take place.
            /// Required: No
            /// Type: List of NotificationConfiguration
            /// Update requires: No interruption
            /// </summary>
			public List<NotificationConfiguration> NotificationConfigurations { get; set; }

            /// <summary>
            /// PlacementGroup
            /// The name of an existing cluster placement group into which you want to launch your instances. A
            /// placement group is a logical grouping of instances within a single Availability Zone. You cannot
            /// specify multiple Availability Zones and a placement group.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 255
            /// Pattern: [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> PlacementGroup { get; set; }

            /// <summary>
            /// ServiceLinkedRoleARN
            /// The Amazon Resource Name (ARN) of the service-linked role that the Auto Scaling group uses to call
            /// other AWS services on your behalf. By default, Amazon EC2 Auto Scaling uses a service-linked role
            /// named AWSServiceRoleForAutoScaling, which it creates if it does not exist.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 1600
            /// Pattern: [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> ServiceLinkedRoleARN { get; set; }

            /// <summary>
            /// Tags
            /// The tags for the group.
            /// Required: No
            /// Type: List of TagProperty
            /// Update requires: No interruption
            /// </summary>
			public List<TagProperty> Tags { get; set; }

            /// <summary>
            /// TargetGroupARNs
            /// A list of Amazon Resource Names (ARN) of target groups to associate with the Auto Scaling group.
            /// Instances are registered as targets in a target group, and traffic is routed to the target group.
            /// For more information, see Using a Load Balancer with an Auto Scaling Group in the Amazon EC2 Auto
            /// Scaling User Guide.
            /// Required: No
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
			public List<Union<string, IntrinsicFunction>> TargetGroupARNs { get; set; }

            /// <summary>
            /// TerminationPolicies
            /// A policy or a list of policies that are used to select the instances to terminate. The policies are
            /// executed in the order that you list them. The termination policies supported by Amazon EC2 Auto
            /// Scaling: OldestInstance, OldestLaunchConfiguration, NewestInstance, ClosestToNextInstanceHour,
            /// Default, OldestLaunchTemplate, and AllocationStrategy.
            /// For more information, see Controlling Which Auto Scaling Instances Terminate During Scale In in the
            /// Amazon EC2 Auto Scaling User Guide.
            /// Required: No
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
			public List<Union<string, IntrinsicFunction>> TerminationPolicies { get; set; }

            /// <summary>
            /// VPCZoneIdentifier
            /// A list of subnet IDs for a virtual private cloud (VPC). If you specify VPCZoneIdentifier with
            /// AvailabilityZones, the subnets that you specify for this property must reside in those Availability
            /// Zones.
            /// If your account supports EC2-Classic and VPC, this property is required to create an Auto Scaling
            /// group that launches instances into a VPC.
            /// If this resource has a public IP address and is also in a VPC that is defined in the same stack
            /// template, you must use the DependsOn attribute to declare a dependency on the VPC-gateway
            /// attachment.
            /// Note When you update VPCZoneIdentifier, this retains the same Auto Scaling group and replaces old
            /// instances with new ones, according to the specified subnets. You can specify how AWS CloudFormation
            /// handles these updates by using an UpdatePolicy attribute.
            /// Required: Conditional
            /// Type: List of String
            /// Minimum: 1
            /// Maximum: 2047
            /// Pattern: [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*
            /// Update requires: Some interruptions
            /// </summary>
			public List<Union<string, IntrinsicFunction>> VPCZoneIdentifier { get; set; }

        }

        public string Type { get; } = "AWS::AutoScaling::AutoScalingGroup";

        public AutoScalingGroupProperties Properties { get; } = new AutoScalingGroupProperties();

        /// <summary>
        /// Associate the CreationPolicy attribute with a resource to prevent its status from reaching create complete until AWS CloudFormation receives
        /// a specified number of success signals or the timeout period is exceeded. To signal a resource, you can use the cfn-signal helper script or 
        /// SignalResource API. AWS CloudFormation publishes valid signals to the stack events so that you track the number of signals sent.
        /// The creation policy is invoked only when AWS CloudFormation creates the associated resource.Currently, the only AWS CloudFormation resources 
        /// that support creation policies are AWS::AutoScaling::AutoScalingGroup, AWS::EC2::Instance, and AWS::CloudFormation::WaitCondition.
        /// Use the CreationPolicy attribute when you want to wait on resource configuration actions before stack creation proceeds. For example, if you 
        /// install and configure software applications on an EC2 instance, you might want those applications to be running before proceeding. In such 
        /// cases, you can add a CreationPolicy attribute to the instance, and then send a success signal to the instance after the applications are 
        /// installed and configured.
        /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-attribute-creationpolicy.html
        /// </summary>
        public CreationPolicy CreationPolicy { get; set; }

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
