using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.SSM.MaintenanceWindowTarget
{
    /// <summary>
    /// AWS::SSM::MaintenanceWindowTarget
    /// The AWS::SSM::MaintenanceWindowTarget resource registers a target with a maintenance window for AWS Systems
    /// Manager. For more information, see RegisterTargetWithMaintenanceWindow in the AWS Systems Manager API
    /// Reference.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-maintenancewindowtarget.html
    /// </summary>
    public class MaintenanceWindowTargetResource : ResourceBase
    {
        public class MaintenanceWindowTargetProperties
        {
            /// <summary>
            /// OwnerInformation
            /// A user-provided value that will be included in any CloudWatch events that are raised while running
            /// tasks for these targets in this maintenance window.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 128
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> OwnerInformation { get; set; }

            /// <summary>
            /// Description
            /// A description for the target.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 128
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// WindowId
            /// The ID of the maintenance window to register the target with.
            /// Required: Yes
            /// Type: String
            /// Minimum: 20
            /// Maximum: 20
            /// Pattern: ^mw-[0-9a-f]{17}$
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> WindowId { get; set; }

            /// <summary>
            /// ResourceType
            /// The type of target that is being registered with the maintenance window.
            /// Required: Yes
            /// Type: String
            /// Allowed Values: INSTANCE | RESOURCE_GROUP
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> ResourceType { get; set; }

            /// <summary>
            /// Targets
            /// The targets to register with the maintenance window. In other words, the instances to run commands
            /// on when the maintenance window runs.
            /// You must specify targets by using the WindowTargetIds parameter.
            /// Required: Yes
            /// Type: List of Targets
            /// Maximum: 5
            /// Update requires: No interruption
            /// </summary>
			public List<Targets> Targets { get; set; }

            /// <summary>
            /// Name
            /// The name for the maintenance window target.
            /// Required: No
            /// Type: String
            /// Minimum: 3
            /// Maximum: 128
            /// Pattern: ^[a-zA-Z0-9_\-. ]{3,128}$
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

        }

        public string Type { get; } = "AWS::SSM::MaintenanceWindowTarget";

        public MaintenanceWindowTargetProperties Properties { get; } = new MaintenanceWindowTargetProperties();

    }
}
