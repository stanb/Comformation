using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.SSM.MaintenanceWindow
{
    /// <summary>
    /// AWS::SSM::MaintenanceWindow
    /// The AWS::SSM::MaintenanceWindow resource represents general information about a Maintenance Window for AWS
    /// Systems Manager. Maintenance Windows let you define a schedule for when to perform potentially disruptive
    /// actions on your instances—such as patching an operating system (OS), updating drivers, or installing software.
    /// Each Maintenance Window has a schedule, a duration, a set of registered targets, and a set of registered
    /// tasks. For more information, see Systems Manager Maintenance Windows in the AWS Systems Manager User Guide and
    /// CreateMaintenanceWindow in the AWS Systems Manager API Reference.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-maintenancewindow.html
    /// </summary>
    public class MaintenanceWindowResource : ResourceBase
    {
        public class MaintenanceWindowProperties
        {
            /// <summary>
            /// StartDate
            /// The date and time, in ISO-8601 Extended format, for when you want the Maintenance Window to become
            /// active. StartDate allows you to delay activation of the Maintenance Window until the specified
            /// future date.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> StartDate { get; set; }

            /// <summary>
            /// Description
            /// A description of the Maintenance Window.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// AllowUnassociatedTargets
            /// Enables a Maintenance Window task to execute on managed instances, even if you haven&#39;t registered
            /// those instances as targets. If this is enabled, then you must specify the unregistered instances (by
            /// instance ID) when you register a task with the Maintenance Window.
            /// Required: Yes
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
			public Union<bool, IntrinsicFunction> AllowUnassociatedTargets { get; set; }

            /// <summary>
            /// Cutoff
            /// The number of hours before the end of the Maintenance Window that Systems Manager stops scheduling
            /// new tasks for execution.
            /// Required: Yes
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
			public Union<int, IntrinsicFunction> Cutoff { get; set; }

            /// <summary>
            /// Schedule
            /// The schedule of the Maintenance Window in the form of a cron or rate expression.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Schedule { get; set; }

            /// <summary>
            /// Duration
            /// The duration of the Maintenance Window in hours.
            /// Required: Yes
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
			public Union<int, IntrinsicFunction> Duration { get; set; }

            /// <summary>
            /// EndDate
            /// The date and time, in ISO-8601 Extended format, for when you want the Maintenance Window to become
            /// inactive. EndDate allows you to set a date and time in the future when the Maintenance Window will
            /// no longer run.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> EndDate { get; set; }

            /// <summary>
            /// Name
            /// The name of the Maintenance Window.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// ScheduleTimezone
            /// The time zone that the scheduled Maintenance Window executions are based on, in Internet Assigned
            /// Numbers Authority (IANA) format. For example: &quot;America/Los_Angeles&quot;, &quot;etc/UTC&quot;, or &quot;Asia/Seoul&quot;. For
            /// more information, see the Time Zone Database on the IANA website.
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
