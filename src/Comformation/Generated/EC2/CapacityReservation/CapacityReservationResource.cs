using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.CapacityReservation
{
    /// <summary>
    /// AWS::EC2::CapacityReservation
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-capacityreservation.html
    /// </summary>
    public class CapacityReservationResource : ResourceBase
    {
        public class CapacityReservationProperties
        {
            /// <summary>
            /// Tenancy
            /// 		
            /// Indicates the tenancy of the Capacity Reservation. A Capacity Reservation can have one of the
            /// following tenancy settings:
            /// 		
            /// 			 			 		 default - The Capacity Reservation is created on hardware that is shared with other AWS
            /// accounts. dedicated - The Capacity Reservation is created on single-tenant hardware that is
            /// dedicated to a single AWS account.
            /// 	
            /// Required: No
            /// Type: String
            /// Allowed values: dedicated | default
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Tenancy { get; set; }

            /// <summary>
            /// EndDateType
            /// 		
            /// Indicates the way in which the Capacity Reservation ends. A Capacity Reservation can have one of the
            /// following end 			types:
            /// 		
            /// 			 			 		 unlimited - The Capacity Reservation remains active until you explicitly cancel it. Do
            /// not 					provide an EndDate if the EndDateType is 						unlimited. limited - The Capacity
            /// Reservation expires automatically at a specified date and time. You must 					provide an EndDate
            /// value if the EndDateType value is 						limited.
            /// 	
            /// Required: No
            /// Type: String
            /// Allowed values: limited | unlimited
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> EndDateType { get; set; }

            /// <summary>
            /// InstanceCount
            /// 		
            /// The number of instances for which to reserve capacity.
            /// 	 	
            /// Valid range: 1 - 1000
            /// 	
            /// Required: Yes
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> InstanceCount { get; set; }

            /// <summary>
            /// TagSpecifications
            /// 		
            /// The tags to apply to the Capacity Reservation during launch.
            /// 	
            /// Required: No
            /// Type: List of TagSpecification
            /// Update requires: Replacement
            /// </summary>
            public List<TagSpecification> TagSpecifications { get; set; }

            /// <summary>
            /// AvailabilityZone
            /// 		
            /// The Availability Zone in which to create the Capacity Reservation.
            /// 	
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> AvailabilityZone { get; set; }

            /// <summary>
            /// InstancePlatform
            /// 		
            /// The type of operating system for which to reserve capacity.
            /// 	
            /// Required: Yes
            /// Type: String
            /// Allowed values: Linux with SQL Server Enterprise | Linux with SQL Server Standard | Linux with SQL
            /// Server Web | Linux/UNIX | Red Hat Enterprise Linux | SUSE Linux | Windows | Windows with SQL Server
            /// | Windows with SQL Server Enterprise | Windows with SQL Server Standard | Windows with SQL Server
            /// Web
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> InstancePlatform { get; set; }

            /// <summary>
            /// InstanceType
            /// 		
            /// The instance type for which to reserve capacity. For more information, see Instance types in the
            /// Amazon EC2 User Guide.
            /// 	
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> InstanceType { get; set; }

            /// <summary>
            /// EphemeralStorage
            /// 		
            /// Indicates whether the Capacity Reservation supports instances with temporary, block-level
            /// 			storage.
            /// 	
            /// Required: No
            /// Type: Boolean
            /// Update requires: Replacement
            /// </summary>
            public Union<bool, IntrinsicFunction> EphemeralStorage { get; set; }

            /// <summary>
            /// InstanceMatchCriteria
            /// 		
            /// Indicates the type of instance launches that the Capacity Reservation accepts. The options
            /// 			include:
            /// 		
            /// 			 			 		 open - The Capacity Reservation automatically matches all instances that have matching
            /// attributes (instance type, platform, 				and Availability Zone). Instances that have matching
            /// attributes run in the Capacity Reservation automatically without specifying 				any additional
            /// parameters. targeted - The Capacity Reservation only accepts instances that have matching attributes
            /// 					(instance type, platform, and Availability Zone), and explicitly target the 					Capacity
            /// Reservation. This ensures that only permitted instances can use the reserved capacity.
            /// 		
            /// Default: open
            /// 	
            /// Required: No
            /// Type: String
            /// Allowed values: open | targeted
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> InstanceMatchCriteria { get; set; }

            /// <summary>
            /// EndDate
            /// 		
            /// The date and time at which the Capacity Reservation expires. When a Capacity Reservation expires,
            /// the reserved capacity 			is released and you can no longer launch instances into it. The Capacity
            /// Reservation&#39;s state changes to 				expired when it reaches its end date and time.
            /// 	 		
            /// You must provide an EndDate value if EndDateType is 				limited. Omit EndDate if EndDateType is
            /// 				unlimited.
            /// 		 		
            /// If the EndDateType is limited, the Capacity Reservation is cancelled within an hour from the
            /// specified time. For example, if you specify 			5/31/2019, 13:30:55, the Capacity Reservation is
            /// guaranteed to end between 13:30:55 and 14:30:55 on 5/31/2019.
            /// 	
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> EndDate { get; set; }

            /// <summary>
            /// EbsOptimized
            /// 		
            /// Indicates whether the Capacity Reservation supports EBS-optimized instances. This optimization
            /// provides 			dedicated throughput to Amazon EBS and an optimized configuration stack to provide
            /// 			optimal I/O performance. This optimization isn&#39;t available with all instance types. 			Additional
            /// usage charges apply when using an EBS- optimized instance.
            /// 	
            /// Required: No
            /// Type: Boolean
            /// Update requires: Replacement
            /// </summary>
            public Union<bool, IntrinsicFunction> EbsOptimized { get; set; }

        }

        public string Type { get; } = "AWS::EC2::CapacityReservation";

        public CapacityReservationProperties Properties { get; } = new CapacityReservationProperties();

    }

    public static class CapacityReservationAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Tenancy = new ResourceAttribute<Union<string, IntrinsicFunction>>("Tenancy");
        public static readonly ResourceAttribute<Union<int, IntrinsicFunction>> AvailableInstanceCount = new ResourceAttribute<Union<int, IntrinsicFunction>>("AvailableInstanceCount");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> AvailabilityZone = new ResourceAttribute<Union<string, IntrinsicFunction>>("AvailabilityZone");
        public static readonly ResourceAttribute<Union<int, IntrinsicFunction>> TotalInstanceCount = new ResourceAttribute<Union<int, IntrinsicFunction>>("TotalInstanceCount");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> InstanceType = new ResourceAttribute<Union<string, IntrinsicFunction>>("InstanceType");
    }
}
