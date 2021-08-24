using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.SSM.MaintenanceWindow
{
    /// <summary>
    /// AWS::SSM::MaintenanceWindow
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-maintenancewindow.html
    /// </summary>
    public class MaintenanceWindowResource : ResourceBase
    {
        public class MaintenanceWindowProperties
        {
            /// <summary>
            /// StartDate
            /// The date and time, in ISO-8601 Extended format, for when the maintenance window is scheduled to
            /// become active. StartDate allows you to delay activation of the Maintenance Window until the
            /// specified future date.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> StartDate { get; set; }

            /// <summary>
            /// Description
            /// A description of the maintenance window.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 128
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// AllowUnassociatedTargets
            /// Enables a maintenance window task to run on managed instances, even if you have not registered those
            /// instances as targets. If enabled, then you must specify the unregistered instances (by instance ID)
            /// when you register a task with the maintenance window.
            /// Required: Yes
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> AllowUnassociatedTargets { get; set; }

            /// <summary>
            /// Cutoff
            /// The number of hours before the end of the maintenance window that AWS Systems Manager stops
            /// scheduling new tasks for execution.
            /// Required: Yes
            /// Type: Integer
            /// Minimum: 0
            /// Maximum: 23
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> Cutoff { get; set; }

            /// <summary>
            /// Schedule
            /// The schedule of the maintenance window in the form of a cron or rate expression.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 256
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Schedule { get; set; }

            /// <summary>
            /// Duration
            /// The duration of the maintenance window in hours.
            /// Required: Yes
            /// Type: Integer
            /// Minimum: 1
            /// Maximum: 24
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> Duration { get; set; }

            /// <summary>
            /// ScheduleOffset
            /// The number of days to wait to run a maintenance window after the scheduled cron expression date and
            /// time.
            /// Required: No
            /// Type: Integer
            /// Minimum: 1
            /// Maximum: 6
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> ScheduleOffset { get; set; }

            /// <summary>
            /// EndDate
            /// The date and time, in ISO-8601 Extended format, for when the maintenance window is scheduled to
            /// become inactive.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> EndDate { get; set; }

            /// <summary>
            /// Tags
            /// Optional metadata that you assign to a resource in the form of an arbitrary set of tags (key-value
            /// pairs). Tags enable you to categorize a resource in different ways, such as by purpose, owner, or
            /// environment. For example, you might want to tag a maintenance window to identify the type of tasks
            /// it will run, the types of targets, and the environment it will run in.
            /// Required: No
            /// Type: List of Tag
            /// Maximum: 1000
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

            /// <summary>
            /// Name
            /// The name of the maintenance window.
            /// Required: Yes
            /// Type: String
            /// Minimum: 3
            /// Maximum: 128
            /// Pattern: ^[a-zA-Z0-9_\-. ]{3,128}$
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// ScheduleTimezone
            /// The time zone that the scheduled maintenance window executions are based on, in Internet Assigned
            /// Numbers Authority (IANA) format.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> ScheduleTimezone { get; set; }

        }

        public string Type { get; } = "AWS::SSM::MaintenanceWindow";

        public MaintenanceWindowProperties Properties { get; } = new MaintenanceWindowProperties();

    }
}
