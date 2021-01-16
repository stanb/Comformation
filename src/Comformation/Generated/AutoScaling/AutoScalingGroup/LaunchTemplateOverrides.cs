using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AutoScaling.AutoScalingGroup
{
    /// <summary>
    /// AWS::AutoScaling::AutoScalingGroup LaunchTemplateOverrides
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-launchtemplateoverrides.html
    /// </summary>
    public class LaunchTemplateOverrides
    {

        /// <summary>
        /// InstanceType
        /// The instance type, such as m3. xlarge. You must use an instance type that is supported in your
        /// requested Region and Availability Zones. For more information, see Available instance types in the
        /// Amazon EC2 User Guide for Linux Instances.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("InstanceType")]
        public Union<string, IntrinsicFunction> InstanceType { get; set; }

        /// <summary>
        /// LaunchTemplateSpecification
        /// Provides the launch template to be used when launching the instance type. For example, some instance
        /// types might require a launch template with a different AMI. If not provided, Amazon EC2 Auto Scaling
        /// uses the launch template that&#39;s defined for your mixed instances policy. For more information, see
        /// Specifying a different launch template for an instance type in the Amazon EC2 Auto Scaling User
        /// Guide.
        /// Required: No
        /// Type: LaunchTemplateSpecification
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LaunchTemplateSpecification")]
        public LaunchTemplateSpecification LaunchTemplateSpecification { get; set; }

        /// <summary>
        /// WeightedCapacity
        /// The number of capacity units provided by the specified instance type in terms of virtual CPUs,
        /// memory, storage, throughput, or other relative performance characteristic. When a Spot or On-Demand
        /// Instance is provisioned, the capacity units count toward the desired capacity. Amazon EC2 Auto
        /// Scaling provisions instances until the desired capacity is totally fulfilled, even if this results
        /// in an overage. For example, if there are 2 units remaining to fulfill capacity, and Amazon EC2 Auto
        /// Scaling can only provision an instance with a WeightedCapacity of 5 units, the instance is
        /// provisioned, and the desired capacity is exceeded by 3 units. For more information, see Instance
        /// weighting for Amazon EC2 Auto Scaling in the Amazon EC2 Auto Scaling User Guide. Value must be in
        /// the range of 1 to 999.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("WeightedCapacity")]
        public Union<string, IntrinsicFunction> WeightedCapacity { get; set; }

    }
}
