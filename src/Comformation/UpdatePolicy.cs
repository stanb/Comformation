using Comformation.IntrinsicFunctions;
using System.Collections.Generic;

namespace Comformation
{
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
    public class UpdatePolicy
    {
        /// <summary>
        /// To specify how AWS CloudFormation handles replacement updates for an Auto Scaling group, use the AutoScalingReplacingUpdate policy. 
        /// This policy enables you to specify whether AWS CloudFormation replaces an Auto Scaling group with a new one or replaces only the 
        /// instances in the Auto Scaling group.
        /// </summary>
        public AutoScalingReplacingUpdate AutoScalingReplacingUpdate { get; set; }

        /// <summary>
        /// To specify how AWS CloudFormation handles rolling updates for an Auto Scaling group, use the AutoScalingRollingUpdate policy. Rolling updates enable 
        /// you to specify whether AWS CloudFormation updates instances that are in an Auto Scaling group in batches or all at once.
        /// </summary>
        public AutoScalingRollingUpdate AutoScalingRollingUpdate { get; set; }

        /// <summary>
        /// To specify how AWS CloudFormation handles updates for the MinSize, MaxSize, and DesiredCapacity properties when the 
        /// AWS::AutoScaling::AutoScalingGroup resource has an associated scheduled action, use the AutoScalingScheduledAction policy.
        /// With scheduled actions, the group size properties of an Auto Scaling group can change at any time.When you update a stack with an Auto Scaling 
        /// group and scheduled action, AWS CloudFormation always sets the group size property values of your Auto Scaling group to the values that are 
        /// defined in the AWS::AutoScaling::AutoScalingGroup resource of your template, even if a scheduled action is in effect.
        /// If you do not want AWS CloudFormation to change any of the group size property values when you have a scheduled action in effect, use the 
        /// AutoScalingScheduledAction update policy to prevent AWS CloudFormation from changing the MinSize, MaxSize, or DesiredCapacity properties unless 
        /// you have modified these values in your template.
        /// </summary>
        public AutoScalingScheduledAction AutoScalingScheduledAction { get; set; }
    }

    public class AutoScalingReplacingUpdate
    {
        /// <summary>
        /// Specifies whether an Auto Scaling group and the instances it contains are replaced during an update. During replacement, AWS CloudFormation 
        /// retains the old group until it finishes creating the new one. If the update fails, AWS CloudFormation can roll back to the old Auto Scaling 
        /// group and delete the new Auto Scaling group.
        /// While AWS CloudFormation creates the new group, it doesn't detach or attach any instances. After successfully creating the new Auto Scaling 
        /// group, AWS CloudFormation deletes the old Auto Scaling group during the cleanup process.
        /// When you set the WillReplace parameter, remember to specify a matching CreationPolicy.If the minimum number of instances(specified by the 
        /// MinSuccessfulInstancesPercent property) don't signal success within the Timeout period (specified in the CreationPolicy policy), the 
        /// replacement update fails and AWS CloudFormation rolls back to the old Auto Scaling group.
        /// Required: No
        /// </summary>
        public Union<bool, IntrinsicFunction> WillReplace { get; set; }
    }

    public class AutoScalingRollingUpdate
    {
        /// <summary>
        /// Specifies the maximum number of instances that AWS CloudFormation updates.
        /// Default: 1
        /// Required: No
        /// </summary>
        public Union<int, IntrinsicFunction> MaxBatchSize { get; set; }

        /// <summary>
        /// Specifies the minimum number of instances that must be in service within the Auto Scaling group while AWS CloudFormation updates old instances.
        /// Default: 0
        /// Required: No
        /// </summary>
        public Union<int, IntrinsicFunction> MinInstancesInService { get; set; }

        /// <summary>
        /// Specifies the percentage of instances in an Auto Scaling rolling update that must signal success for an update to succeed. You can specify a 
        /// value from 0 to 100. AWS CloudFormation rounds to the nearest tenth of a percent. For example, if you update five instances with a minimum 
        /// successful percentage of 50, three instances must signal success.
        /// If an instance doesn't send a signal within the time specified in the PauseTime property, AWS CloudFormation assumes that the instance wasn't 
        /// updated.
        /// If you specify this property, you must also enable the WaitOnResourceSignals and PauseTime properties.
        /// Default: 100
        /// Required: No
        /// </summary>
        public Union<int, IntrinsicFunction> MinSuccessfulInstancesPercent { get; set; }

        /// <summary>
        /// The amount of time that AWS CloudFormation pauses after making a change to a batch of instances to give those instances time to start software 
        /// applications. For example, you might need to specify PauseTime when scaling up the number of instances in an Auto Scaling group.
        /// If you enable the WaitOnResourceSignals property, PauseTime is the amount of time that AWS CloudFormation should wait for the Auto Scaling group 
        /// to receive the required number of valid signals from added or replaced instances.If the PauseTime is exceeded before the Auto Scaling group 
        /// receives the required number of signals, the update fails.For best results, specify a time period that gives your applications sufficient time 
        /// to get started.If the update needs to be rolled back, a short PauseTime can cause the rollback to fail.
        /// Specify PauseTime in the ISO8601 duration format (in the format PT#H#M#S, where each # is the number of hours, minutes, and seconds, respectively). 
        /// The maximum PauseTime is one hour (PT1H).
        /// Default: PT0S (zero seconds). If the WaitOnResourceSignals property is set to true, the default is PT5M.
        /// Required: No
        /// </summary>
        public Union<string, IntrinsicFunction> PauseTime { get; set; }

        /// <summary>
        /// Specifies the Auto Scaling processes to suspend during a stack update. Suspending processes prevents Auto Scaling from interfering with a stack 
        /// update. For example, you can suspend alarming so that Amazon EC2 Auto Scaling doesn't execute scaling policies associated with an alarm. For valid 
        /// values, see the ScalingProcesses.member.N parameter for the SuspendProcesses action in the Amazon EC2 Auto Scaling API Reference.
        /// </summary>
        public List<ScallingProcesses> SuspendProcesses { get; set; }

        /// <summary>
        /// Specifies whether the Auto Scaling group waits on signals from new instances during an update. Use this property to ensure that instances have 
        /// completed installing and configuring applications before the Auto Scaling group update proceeds. AWS CloudFormation suspends the update of an 
        /// Auto Scaling group after new EC2 instances are launched into the group. AWS CloudFormation must receive a signal from each new instance within 
        /// the specified PauseTime before continuing the update. To signal the Auto Scaling group, use the cfn-signal helper script or SignalResource API.
        /// To have instances wait for an Elastic Load Balancing health check before they signal success, add a health-check verification by using the 
        /// cfn-init helper script.For an example, see the verify_instance_health command in the Auto Scaling rolling updates sample template.
        /// Default: false
        /// Required: Conditional. If you specify the MinSuccessfulInstancesPercent property, you must also enable the WaitOnResourceSignals and PauseTime properties.
        /// </summary>
        public Union<bool, IntrinsicFunction> WaitOnResourceSignals { get; set; }
    }

    /// <summary>
    /// To specify how AWS CloudFormation handles updates for the MinSize, MaxSize, and DesiredCapacity properties when the AWS::AutoScaling::AutoScalingGroup 
    /// resource has an associated scheduled action, use the AutoScalingScheduledAction policy.
    /// With scheduled actions, the group size properties of an Auto Scaling group can change at any time.When you update a stack with an Auto Scaling group 
    /// and scheduled action, AWS CloudFormation always sets the group size property values of your Auto Scaling group to the values that are defined in the 
    /// AWS::AutoScaling::AutoScalingGroup resource of your template, even if a scheduled action is in effect.
    /// If you do not want AWS CloudFormation to change any of the group size property values when you have a scheduled action in effect, use the 
    /// AutoScalingScheduledAction update policy to prevent AWS CloudFormation from changing the MinSize, MaxSize, or DesiredCapacity properties unless you 
    /// have modified these values in your template.
    /// </summary>
    public class AutoScalingScheduledAction
    {
        /// <summary>
        /// Specifies whether AWS CloudFormation ignores differences in group size properties between your current Auto Scaling group and the Auto Scaling 
        /// group described in the AWS::AutoScaling::AutoScalingGroup resource of your template during a stack update. If you modify any of the group size 
        /// property values in your template, AWS CloudFormation uses the modified values and updates your Auto Scaling group.
        /// Default: false
        /// </summary>
        public Union<bool, IntrinsicFunction> IgnoreUnmodifiedGroupSizeProperties { get; set; }
    }

    public enum ScallingProcesses
    {
        Launch, 
        Terminate,
        HealthCheck,
        ReplaceUnhealthy,
        AZRebalance,
        AlarmNotification,
        ScheduledActions,
        AddToLoadBalancer
    }
}
