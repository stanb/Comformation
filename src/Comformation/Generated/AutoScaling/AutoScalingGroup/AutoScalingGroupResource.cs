using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.AutoScaling.AutoScalingGroup
{
    /// <summary>
    /// AWS::AutoScaling::AutoScalingGroup
    /// Creates an Auto Scaling group.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-group.html
    /// </summary>
    public class AutoScalingGroupResource : ResourceBase
    {
        public class AutoScalingGroupProperties
        {
            /// <summary>
            /// AutoScalingGroupName
            /// The name of the Auto Scaling group.
            /// Minimum length of 1. Maximum length of 255. Must follow the following pattern:
            /// [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> AutoScalingGroupName { get; set; }

            /// <summary>
            /// AvailabilityZones
            /// Contains a list of availability zones for the group.
            /// Required: Conditional. If you don&#39;t specify the VPCZoneIdentifier property, you must specify this
            /// property.
            /// Type: List of String values
            /// Update requires: No interruption
            /// </summary>
			public List<Union<string, IntrinsicFunction>> AvailabilityZones { get; set; }

            /// <summary>
            /// Cooldown
            /// The number of seconds after a scaling activity is completed before any further scaling activities
            /// can start.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Cooldown { get; set; }

            /// <summary>
            /// DesiredCapacity
            /// Specifies the desired capacity for the Auto Scaling group.
            /// If SpotPrice is not set in the AWS::AutoScaling::LaunchConfiguration for this Auto Scaling group,
            /// then Auto Scaling will begin to bring instances online based on DesiredCapacity. CloudFormation will
            /// not mark the Auto Scaling group as successful (by setting its status to CREATE_COMPLETE) until the
            /// desired capacity is reached.
            /// If SpotPrice is set, then DesiredCapacity will not be used as a criteria for success, since
            /// instances will only be started when the spot price has been matched. After the spot price has been
            /// matched, however, Auto Scaling uses DesiredCapacity as the target capacity for the group.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> DesiredCapacity { get; set; }

            /// <summary>
            /// HealthCheckGracePeriod
            /// The length of time in seconds after a new EC2 instance comes into service that Auto Scaling starts
            /// checking its health.
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
			public Union<int, IntrinsicFunction> HealthCheckGracePeriod { get; set; }

            /// <summary>
            /// HealthCheckType
            /// The service you want the health status from, Amazon EC2 or Elastic Load Balancer. Valid values are
            /// EC2 or ELB.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> HealthCheckType { get; set; }

            /// <summary>
            /// InstanceId
            /// The ID of the Amazon EC2 instance you want to use to create the Auto Scaling group. Use this
            /// property if you want to create an Auto Scaling group that uses an existing Amazon EC2 instance
            /// instead of a launch configuration.
            /// When you use an Amazon EC2 instance to create an Auto Scaling group, a new launch configuration is
            /// first created and then associated with the Auto Scaling group. The new launch configuration derives
            /// all its properties from the instance, with the exception of BlockDeviceMapping and
            /// AssociatePublicIpAddress.
            /// Required: Conditional. You must specify one of the following: InstanceId, LaunchConfigurationName,
            /// or LaunchTemplate.
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> InstanceId { get; set; }

            /// <summary>
            /// LaunchConfigurationName
            /// Specifies the name of the associated AWS::AutoScaling::LaunchConfiguration resource.
            /// Note If this resource has a public IP address and is also in a VPC that is defined in the same
            /// template, you must use the DependsOn attribute to declare a dependency on the VPC-gateway
            /// attachment. For more information, see DependsOn Attribute.
            /// Required: Conditional. You must specify one of the following: InstanceId, LaunchConfigurationName or
            /// LaunchTemplate.
            /// Type: String
            /// Update requires: No interruption
            /// Important When you update the LaunchConfigurationName, existing Amazon EC2 instances continue to run
            /// with the configuration that they were originally launched with. To update existing instances,
            /// specify an update policy attribute for this Auto Scaling group. For more information, see
            /// UpdatePolicy.
            /// </summary>
			public Union<string, IntrinsicFunction> LaunchConfigurationName { get; set; }

            /// <summary>
            /// LaunchTemplate
            /// The launch template to use to launch instances.
            /// Required: Conditional. You must specify one of the following: InstanceId, LaunchConfigurationName,
            /// or LaunchTemplate.
            /// Type: Amazon EC2 Auto Scaling AutoScalingGroup LaunchTemplateSpecification
            /// Update requires: No interruption
            /// Important When you update the LaunchTemplate, existing Amazon EC2 instances continue to run with the
            /// configuration that they were originally launched with. To update existing instances, specify an
            /// update policy attribute for this Auto Scaling group. For more information, see UpdatePolicy.
            /// </summary>
			public LaunchTemplateSpecification LaunchTemplate { get; set; }

            /// <summary>
            /// LifecycleHookSpecificationList
            /// The lifecycle hooks for the group, which specify actions to perform when Auto Scaling launches or
            /// terminates instances. For more information, see Amazon EC2 Auto Scaling Lifecycle Hooks in the
            /// Amazon EC2 Auto Scaling User Guide.
            /// Required: No
            /// Type: List of Amazon EC2 Auto Scaling AutoScalingGroup LifecycleHookSpecification
            /// Update requires: No interruption
            /// </summary>
			public List<LifecycleHookSpecification> LifecycleHookSpecificationList { get; set; }

            /// <summary>
            /// LoadBalancerNames
            /// A list of Classic load balancers associated with this Auto Scaling group. To specify Application
            /// load balancers, use TargetGroupARNs.
            /// Required: No
            /// Type: List of String values
            /// Update requires: No interruption
            /// </summary>
			public List<Union<string, IntrinsicFunction>> LoadBalancerNames { get; set; }

            /// <summary>
            /// MaxSize
            /// The maximum size of the Auto Scaling group.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> MaxSize { get; set; }

            /// <summary>
            /// MetricsCollection
            /// Enables the monitoring of group metrics of an Auto Scaling group.
            /// Required: No
            /// Type: A list of Amazon EC2 Auto Scaling AutoScalingGroup MetricsCollection
            /// Update requires: No interruption
            /// </summary>
			public List<MetricsCollection> MetricsCollection { get; set; }

            /// <summary>
            /// MinSize
            /// The minimum size of the Auto Scaling group.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> MinSize { get; set; }

            /// <summary>
            /// NotificationConfigurations
            /// An embedded property that configures an Auto Scaling group to send notifications when specified
            /// events take place.
            /// Required: No
            /// Type: List of Amazon EC2 Auto Scaling AutoScalingGroup NotificationConfiguration
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
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> PlacementGroup { get; set; }

            /// <summary>
            /// ServiceLinkedRoleARN
            /// The Amazon Resource Name (ARN) of the service-linked role that the Auto Scaling group uses to call
            /// other AWS services on your behalf. By default, Auto Scaling uses a service-linked role named
            /// AWSServiceRoleForAutoScaling, which it creates if it does not exist.
            /// Length Constraints: Minimum length of 1. Maximum length of 1600.
            /// Pattern: [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> ServiceLinkedRoleARN { get; set; }

            /// <summary>
            /// Tags
            /// The Auto Scaling tags to attach to this resource. For more information about Auto Scaling tags, see
            /// Tagging Auto Scaling Groups and Instances in the Amazon EC2 Auto Scaling User Guide.
            /// Required: No
            /// Type: List of Amazon EC2 Auto Scaling AutoScalingGroup TagProperty
            /// Update requires: No interruption
            /// </summary>
			public List<TagProperty> Tags { get; set; }

            /// <summary>
            /// TargetGroupARNs
            /// A list of Amazon Resource Names (ARN) of target groups to associate with the Auto Scaling group.
            /// Required: No
            /// Type: List of String values
            /// Update requires: No interruption
            /// </summary>
			public List<Union<string, IntrinsicFunction>> TargetGroupARNs { get; set; }

            /// <summary>
            /// TerminationPolicies
            /// A policy or a list of policies that are used to select the instances to terminate. The policies are
            /// executed in the order that you list them.
            /// For more information on configuring a termination policy for your Auto Scaling group, see
            /// Controlling Which Auto Scaling Instances Terminate During Scale In in the Amazon EC2 Auto Scaling
            /// User Guide.
            /// Required: No
            /// Type: List of String values
            /// Update requires: No interruption
            /// </summary>
			public List<Union<string, IntrinsicFunction>> TerminationPolicies { get; set; }

            /// <summary>
            /// VPCZoneIdentifier
            /// A list of subnet identifiers of Amazon Virtual Private Cloud (Amazon VPCs).
            /// If you specify the AvailabilityZones property, the subnets that you specify for this property must
            /// reside in those Availability Zones.
            /// For more information, see Launching Auto Scaling Instances in a VPC in the Amazon EC2 Auto Scaling
            /// User Guide.
            /// Required: Conditional. If you don&#39;t specify the AvailabilityZones property, you must specify this
            /// property.
            /// Type: List of String values
            /// Update requires: Some interruptions
            /// Note When you update VPCZoneIdentifier, the instances are replaced, but not the Auto Scaling group.
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
