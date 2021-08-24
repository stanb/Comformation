using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.EC2Fleet
{
    /// <summary>
    /// AWS::EC2::EC2Fleet
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
            /// The fleet type. The default value is maintain.
            /// maintain - The EC2 Fleet places an asynchronous request for your desired capacity, and continues to
            /// maintain your desired Spot capacity by replenishing interrupted Spot Instances. request - The EC2
            /// Fleet places an asynchronous one-time request for your desired capacity, but does submit Spot
            /// requests in alternative capacity pools if Spot capacity is unavailable, and does not maintain Spot
            /// capacity if Spot Instances are interrupted. instant - The EC2 Fleet places a synchronous one-time
            /// request for your desired capacity, and returns errors for any instances that could not be launched.
            /// For more information, see EC2 Fleet request types in the Amazon EC2 User Guide.
            /// Required: No
            /// Type: String
            /// Allowed values: instant | maintain | request
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Type { get; set; }

            /// <summary>
            /// ExcessCapacityTerminationPolicy
            /// Indicates whether running instances should be terminated if the total target capacity of the EC2
            /// Fleet is decreased below the current size of the EC2 Fleet.
            /// Required: No
            /// Type: String
            /// Allowed values: no-termination | termination
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> ExcessCapacityTerminationPolicy { get; set; }

            /// <summary>
            /// TagSpecifications
            /// The key-value pair for tagging the EC2 Fleet request on creation. For more information, see Tagging
            /// your resources.
            /// If the fleet type is instant, specify a resource type of fleet to tag the fleet or instance to tag
            /// the instances at launch.
            /// If the fleet type is maintain or request, specify a resource type of fleet to tag the fleet. You
            /// cannot specify a resource type of instance. To tag instances at launch, specify the tags in a launch
            /// template.
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
            /// Indicates whether EC2 Fleet should replace unhealthy Spot Instances. Supported only for fleets of
            /// type maintain. For more information, see EC2 Fleet health checks in the Amazon EC2 User Guide.
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

            /// <summary>
            /// Context
            /// Reserved.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Context { get; set; }

        }

        public string Type { get; } = "AWS::EC2::EC2Fleet";

        public EC2FleetProperties Properties { get; } = new EC2FleetProperties();

    }

    public static class EC2FleetAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> FleetId = new ResourceAttribute<Union<string, IntrinsicFunction>>("FleetId");
    }
}
