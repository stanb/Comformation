using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.EC2Fleet
{
    /// <summary>
    /// AWS::EC2::EC2Fleet
    /// Specifies the configuration information to launch a fleet—or group—of instances. An EC2 Fleet can launch
    /// multiple instance types across multiple Availability Zones, using the On-Demand Instance, Reserved Instance,
    /// and Spot Instance purchasing models together. Using EC2 Fleet, you can define separate On-Demand and Spot
    /// capacity targets, specify the instance types that work best for your applications, and specify how Amazon EC2
    /// should distribute your fleet capacity within each purchasing model. For more information, see Launching an EC2
    /// Fleet in the Amazon EC2 User Guide for Linux Instances.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-ec2fleet.html
    /// </summary>
    public class EC2FleetResource : ResourceBase
    {
        public class EC2FleetProperties
        {
            /// <summary>
            /// TargetCapacitySpecification
            /// The number of units to request.
            /// Required: Yes
            /// Type: TargetCapacitySpecificationRequest
            /// Update requires: No interruption
            /// </summary>
			public TargetCapacitySpecificationRequest TargetCapacitySpecification { get; set; }

            /// <summary>
            /// OnDemandOptions
            /// Describes the configuration of On-Demand Instances in an EC2 Fleet.
            /// Required: No
            /// Type: OnDemandOptionsRequest
            /// Update requires: Replacement
            /// </summary>
			public OnDemandOptionsRequest OnDemandOptions { get; set; }

            /// <summary>
            /// Type
            /// The type of the request. By default, the EC2 Fleet places an asynchronous request for your desired
            /// capacity, and maintains it by replenishing interrupted Spot Instances (maintain). A value of instant
            /// places a synchronous one-time request, and returns errors for any instances that could not be
            /// launched. A value of request places an asynchronous one-time request without maintaining capacity or
            /// submitting requests in alternative capacity pools if capacity is unavailable. For more information,
            /// see EC2 Fleet Request Types in the Amazon Elastic Compute Cloud User Guide.
            /// Required: No
            /// Type: String
            /// Allowed Values: instant | maintain | request
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Type { get; set; }

            /// <summary>
            /// ExcessCapacityTerminationPolicy
            /// Indicates whether running instances should be terminated if the total target capacity of the EC2
            /// Fleet is decreased below the current size of the EC2 Fleet.
            /// Required: No
            /// Type: String
            /// Allowed Values: no-termination | termination
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> ExcessCapacityTerminationPolicy { get; set; }

            /// <summary>
            /// TagSpecifications
            /// The key-value pair for tagging the EC2 Fleet request on creation. The value for ResourceType must be
            /// fleet, otherwise the fleet request fails. To tag instances at launch, specify the tags in the launch
            /// template. For information about tagging after launch, see Tagging Your Resources.
            /// Required: No
            /// Type: List of TagSpecification
            /// Update requires: Replacement
            /// </summary>
			public List<TagSpecification> TagSpecifications { get; set; }

            /// <summary>
            /// SpotOptions
            /// Describes the configuration of Spot Instances in an EC2 Fleet.
            /// Required: No
            /// Type: SpotOptionsRequest
            /// Update requires: Replacement
            /// </summary>
			public SpotOptionsRequest SpotOptions { get; set; }

            /// <summary>
            /// ValidFrom
            /// The start date and time of the request, in UTC format (for example, YYYY-MM-DDTHH:MM:SSZ). The
            /// default is to start fulfilling the request immediately.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ValidFrom { get; set; }

            /// <summary>
            /// ReplaceUnhealthyInstances
            /// Indicates whether EC2 Fleet should replace unhealthy instances.
            /// Required: No
            /// Type: Boolean
            /// Update requires: Replacement
            /// </summary>
			public Union<bool, IntrinsicFunction> ReplaceUnhealthyInstances { get; set; }

            /// <summary>
            /// LaunchTemplateConfigs
            /// The configuration for the EC2 Fleet.
            /// Required: Yes
            /// Type: List of FleetLaunchTemplateConfigRequest
            /// Maximum: 50
            /// Update requires: Replacement
            /// </summary>
			public List<FleetLaunchTemplateConfigRequest> LaunchTemplateConfigs { get; set; }

            /// <summary>
            /// TerminateInstancesWithExpiration
            /// Indicates whether running instances should be terminated when the EC2 Fleet expires.
            /// Required: No
            /// Type: Boolean
            /// Update requires: Replacement
            /// </summary>
			public Union<bool, IntrinsicFunction> TerminateInstancesWithExpiration { get; set; }

            /// <summary>
            /// ValidUntil
            /// The end date and time of the request, in UTC format (for example, YYYY-MM-DDTHH:MM:SSZ). At this
            /// point, no new EC2 Fleet requests are placed or able to fulfill the request. If no value is
            /// specified, the request remains until you cancel it.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ValidUntil { get; set; }

        }

        public string Type { get; } = "AWS::EC2::EC2Fleet";

        public EC2FleetProperties Properties { get; } = new EC2FleetProperties();

    }
}
