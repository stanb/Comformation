using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.AutoScaling.AutoScalingGroup
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-group.html
    /// </summary>
    public class AutoScalingGroupResource : ResourceBase
    {
        public class AutoScalingGroupProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-group.html#cfn-autoscaling-autoscalinggroup-autoscalinggroupname
            /// </summary>
			public Union<string, IntrinsicFunction> AutoScalingGroupName { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-group.html#cfn-as-group-availabilityzones
            /// </summary>
			public Union<List<string>, IntrinsicFunction> AvailabilityZones { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-group.html#cfn-as-group-cooldown
            /// </summary>
			public Union<string, IntrinsicFunction> Cooldown { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-group.html#cfn-as-group-desiredcapacity
            /// </summary>
			public Union<string, IntrinsicFunction> DesiredCapacity { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-group.html#cfn-as-group-healthcheckgraceperiod
            /// </summary>
			public Union<int?, IntrinsicFunction> HealthCheckGracePeriod { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-group.html#cfn-as-group-healthchecktype
            /// </summary>
			public Union<string, IntrinsicFunction> HealthCheckType { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-group.html#cfn-as-group-instanceid
            /// </summary>
			public Union<string, IntrinsicFunction> InstanceId { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-group.html#cfn-as-group-launchconfigurationname
            /// </summary>
			public Union<string, IntrinsicFunction> LaunchConfigurationName { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-group.html#cfn-autoscaling-autoscalinggroup-lifecyclehookspecificationlist
            /// </summary>
			public Union<List<LifecycleHookSpecification>, IntrinsicFunction> LifecycleHookSpecificationList { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-group.html#cfn-as-group-loadbalancernames
            /// </summary>
			public Union<List<string>, IntrinsicFunction> LoadBalancerNames { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-group.html#cfn-as-group-maxsize
            /// </summary>
			public Union<string, IntrinsicFunction> MaxSize { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-group.html#cfn-as-group-metricscollection
            /// </summary>
			public Union<List<MetricsCollection>, IntrinsicFunction> MetricsCollection { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-group.html#cfn-as-group-minsize
            /// </summary>
			public Union<string, IntrinsicFunction> MinSize { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-group.html#cfn-as-group-notificationconfigurations
            /// </summary>
			public Union<List<NotificationConfiguration>, IntrinsicFunction> NotificationConfigurations { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-group.html#cfn-as-group-placementgroup
            /// </summary>
			public Union<string, IntrinsicFunction> PlacementGroup { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-group.html#cfn-as-group-tags
            /// </summary>
			public Union<List<TagProperty>, IntrinsicFunction> Tags { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-group.html#cfn-as-group-targetgrouparns
            /// </summary>
			public Union<List<string>, IntrinsicFunction> TargetGroupARNs { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-group.html#cfn-as-group-termpolicy
            /// </summary>
			public Union<List<string>, IntrinsicFunction> TerminationPolicies { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-group.html#cfn-as-group-vpczoneidentifier
            /// </summary>
			public Union<List<string>, IntrinsicFunction> VPCZoneIdentifier { get; set; }

        }
    
        public string Type { get; } = "AWS::AutoScaling::AutoScalingGroup";
        
        public AutoScalingGroupProperties Properties { get; } = new AutoScalingGroupProperties();
    }
}
