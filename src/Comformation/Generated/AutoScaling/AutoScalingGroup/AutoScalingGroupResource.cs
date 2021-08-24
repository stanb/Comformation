using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.AutoScaling.AutoScalingGroup
{
    /// <summary>
    /// AWS::AutoScaling::AutoScalingGroup
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
            /// A list of Availability Zones where instances in the Auto Scaling group can be created. You must
            /// specify one of the following properties: VPCZoneIdentifier or AvailabilityZones. If your account
            /// supports EC2-Classic and VPC, this property is required to create an Auto Scaling group that
            /// launches instances into EC2-Classic.
            /// Required: Conditional
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> AvailabilityZones { get; set; }

            /// <summary>
            /// CapacityRebalance
            /// Indicates whether Capacity Rebalancing is enabled. For more information, see Amazon EC2 Auto Scaling
            /// Capacity Rebalancing in the Amazon EC2 Auto Scaling User Guide.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> CapacityRebalance { get; set; }

            /// <summary>
            /// Context
            /// Reserved.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Context { get; set; }

            /// <summary>
            /// Cooldown
            /// The amount of time, in seconds, after a scaling activity completes before another scaling activity
            /// can start. The default value is 300. This setting applies when using simple scaling policies, but
            /// not when using other scaling policies or scheduled scaling. For more information, see Scaling
            /// cooldowns for Amazon EC2 Auto Scaling in the Amazon EC2 Auto Scaling User Guide.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Cooldown { get; set; }

            /// <summary>
            /// DesiredCapacity
            /// The desired capacity is the initial capacity of the Auto Scaling group at the time of its creation
            /// and the capacity it attempts to maintain. It can scale beyond this capacity if you configure
            /// automatic scaling.
            /// The number must be greater than or equal to the minimum size of the group and less than or equal to
            /// the maximum size of the group. If you do not specify a desired capacity when creating the stack, the
            /// default is the minimum size of the group.
            /// CloudFormation marks the Auto Scaling group as successful (by setting its status to CREATE_COMPLETE)
            /// when the desired capacity is reached. However, if a maximum Spot price is set in the launch template
            /// or launch configuration that you specified, then desired capacity is not used as a criteria for
            /// success. Whether your request is fulfilled depends on Spot Instance capacity and your maximum price.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> DesiredCapacity { get; set; }

            /// <summary>
            /// HealthCheckGracePeriod
            /// The amount of time, in seconds, that Amazon EC2 Auto Scaling waits before checking the health status
            /// of an EC2 instance that has come into service. The default value is 0. For more information, see
            /// Health checks for Auto Scaling instances in the Amazon EC2 Auto Scaling User Guide.
            /// If you are adding an ELB health check, you must specify this property.
            /// Required: Conditional
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> HealthCheckGracePeriod { get; set; }

            /// <summary>
            /// HealthCheckType
            /// The service to use for the health checks. The valid values are EC2 (default) and ELB. If you
            /// configure an Auto Scaling group to use load balancer (ELB) health checks, it considers the instance
            /// unhealthy if it fails either the EC2 status checks or the load balancer health checks. For more
            /// information, see Health checks for Auto Scaling instances in the Amazon EC2 Auto Scaling User Guide.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> HealthCheckType { get; set; }

            /// <summary>
            /// InstanceId
            /// The ID of the instance used to base the launch configuration on. If specified, Amazon EC2 Auto
            /// Scaling uses the configuration values from the specified instance to create a new launch
            /// configuration. For more information, see Creating an Auto Scaling group using an EC2 instance in the
            /// Amazon EC2 Auto Scaling User Guide.
            /// To get the instance ID, use the EC2 DescribeInstances API operation.
            /// If you specify LaunchTemplate, MixedInstancesPolicy, or LaunchConfigurationName, don&#39;t specify
            /// InstanceId.
            /// Required: Conditional
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> InstanceId { get; set; }

            /// <summary>
            /// LaunchConfigurationName
            /// The name of the launch configuration to use to launch instances.
            /// If you specify LaunchTemplate, MixedInstancesPolicy, or InstanceId, don&#39;t specify
            /// LaunchConfigurationName.
            /// Required: Conditional
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> LaunchConfigurationName { get; set; }

            /// <summary>
            /// LaunchTemplate
            /// Properties used to specify the launch template and version to use to launch instances. You can
            /// alternatively associate a launch template to the Auto Scaling group by specifying a
            /// MixedInstancesPolicy.
            /// If you omit this property, you must specify MixedInstancesPolicy, LaunchConfigurationName, or
            /// InstanceId.
            /// Required: Conditional
            /// Type: LaunchTemplateSpecification
            /// Update requires: No interruption
            /// </summary>
            public LaunchTemplateSpecification LaunchTemplate { get; set; }

            /// <summary>
            /// LifecycleHookSpecificationList
            /// One or more lifecycle hooks for the group, which specify actions to perform when Amazon EC2 Auto
            /// Scaling launches or terminates instances.
            /// Required: No
            /// Type: List of LifecycleHookSpecification
            /// Update requires: No interruption
            /// </summary>
            public List<LifecycleHookSpecification> LifecycleHookSpecificationList { get; set; }

            /// <summary>
            /// LoadBalancerNames
            /// A list of Classic Load Balancers associated with this Auto Scaling group. For Application Load
            /// Balancers, Network Load Balancers, and Gateway Load Balancers, specify the TargetGroupARNs property
            /// instead.
            /// Required: No
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> LoadBalancerNames { get; set; }

            /// <summary>
            /// MaxInstanceLifetime
            /// The maximum amount of time, in seconds, that an instance can be in service. The default is null. If
            /// specified, the value must be either 0 or a number equal to or greater than 86,400 seconds (1 day).
            /// For more information, see Replacing Auto Scaling instances based on maximum instance lifetime in the
            /// Amazon EC2 Auto Scaling User Guide.
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> MaxInstanceLifetime { get; set; }

            /// <summary>
            /// MaxSize
            /// The maximum size of the group.
            /// Note With a mixed instances policy that uses instance weighting, Amazon EC2 Auto Scaling may need to
            /// go above MaxSize to meet your capacity requirements. In this event, Amazon EC2 Auto Scaling will
            /// never go above MaxSize by more than your largest instance weight (weights that define how many units
            /// each instance contributes to the desired capacity of the group).
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
            /// The minimum size of the group.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> MinSize { get; set; }

            /// <summary>
            /// MixedInstancesPolicy
            /// An embedded object that specifies a mixed instances policy.
            /// The policy includes properties that not only define the distribution of On-Demand Instances and Spot
            /// Instances, the maximum price to pay for Spot Instances (optional), and how the Auto Scaling group
            /// allocates instance types to fulfill On-Demand and Spot capacities, but also the properties that
            /// specify the instance configuration information—the launch template and instance types. The policy
            /// can also include a weight for each instance type and different launch templates for individual
            /// instance types.
            /// For more information, see Auto Scaling groups with multiple instance types and purchase options in
            /// the Amazon EC2 Auto Scaling User Guide.
            /// If you specify LaunchTemplate, InstanceId, or LaunchConfigurationName, don&#39;t specify
            /// MixedInstancesPolicy.
            /// Required: Conditional
            /// Type: MixedInstancesPolicy
            /// Update requires: No interruption
            /// </summary>
            public MixedInstancesPolicy MixedInstancesPolicy { get; set; }

            /// <summary>
            /// NewInstancesProtectedFromScaleIn
            /// Indicates whether newly launched instances are protected from termination by Amazon EC2 Auto Scaling
            /// when scaling in. For more information about preventing instances from terminating on scale in, see
            /// Instance Protection in the Amazon EC2 Auto Scaling User Guide.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> NewInstancesProtectedFromScaleIn { get; set; }

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
            /// The name of the placement group into which you want to launch your instances. A placement group is a
            /// logical grouping of instances within a single Availability Zone. For more information, see Placement
            /// Groups in the Amazon EC2 User Guide for Linux Instances.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> PlacementGroup { get; set; }

            /// <summary>
            /// ServiceLinkedRoleARN
            /// The Amazon Resource Name (ARN) of the service-linked role that the Auto Scaling group uses to call
            /// other AWS services on your behalf. By default, Amazon EC2 Auto Scaling uses a service-linked role
            /// named AWSServiceRoleForAutoScaling, which it creates if it does not exist. For more information, see
            /// Service-linked roles for Amazon EC2 Auto Scaling in the Amazon EC2 Auto Scaling User Guide.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> ServiceLinkedRoleARN { get; set; }

            /// <summary>
            /// Tags
            /// One or more tags. You can tag your Auto Scaling group and propagate the tags to the Amazon EC2
            /// instances it launches. For more information, see Tagging Auto Scaling groups and instances in the
            /// Amazon EC2 Auto Scaling User Guide.
            /// Required: No
            /// Type: List of TagProperty
            /// Update requires: No interruption
            /// </summary>
            public List<TagProperty> Tags { get; set; }

            /// <summary>
            /// TargetGroupARNs
            /// One or more Amazon Resource Names (ARN) of load balancer target groups to associate with the Auto
            /// Scaling group. Instances are registered as targets in a target group, and traffic is routed to the
            /// target group. For more information, see Elastic Load Balancing and Amazon EC2 Auto Scaling in the
            /// Amazon EC2 Auto Scaling User Guide.
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
            /// Default, OldestLaunchTemplate, and AllocationStrategy. For more information, see Controlling which
            /// Auto Scaling instances terminate during scale in in the Amazon EC2 Auto Scaling User Guide.
            /// Required: No
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> TerminationPolicies { get; set; }

            /// <summary>
            /// VPCZoneIdentifier
            /// A list of subnet IDs for a virtual private cloud (VPC) where instances in the Auto Scaling group can
            /// be created. If you specify VPCZoneIdentifier with AvailabilityZones, the subnets that you specify
            /// for this property must reside in those Availability Zones.
            /// If this resource specifies public subnets and is also in a VPC that is defined in the same stack
            /// template, you must use the DependsOn attribute to declare a dependency on the VPC-gateway
            /// attachment.
            /// Note When you update VPCZoneIdentifier, this retains the same Auto Scaling group and replaces old
            /// instances with new ones, according to the specified subnets. You can optionally specify how
            /// CloudFormation handles these updates by using an UpdatePolicy attribute.
            /// Required: Conditional
            /// Type: List of String
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

    public static class AutoScalingGroupAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> LaunchConfigurationName = new ResourceAttribute<Union<string, IntrinsicFunction>>("LaunchConfigurationName");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> LaunchTemplateSpecification = new ResourceAttribute<Union<string, IntrinsicFunction>>("LaunchTemplateSpecification");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> MixedInstancesPolicy = new ResourceAttribute<Union<string, IntrinsicFunction>>("MixedInstancesPolicy");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> PlacementGroup = new ResourceAttribute<Union<string, IntrinsicFunction>>("PlacementGroup");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> VPCZoneIdentifier = new ResourceAttribute<Union<string, IntrinsicFunction>>("VPCZoneIdentifier");
    }
}
