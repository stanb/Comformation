using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.SSM.MaintenanceWindowTask
{
    /// <summary>
    /// AWS::SSM::MaintenanceWindowTask
    /// The AWS::SSM::MaintenanceWindowTask resource defines information about a task for an AWS Systems Manager
    /// maintenance window. For more information, see RegisterTaskWithMaintenanceWindow in the AWS Systems Manager API
    /// Reference.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-maintenancewindowtask.html
    /// </summary>
    public class MaintenanceWindowTaskResource : ResourceBase
    {
        public class MaintenanceWindowTaskProperties
        {
            /// <summary>
            /// MaxErrors
            /// The maximum number of errors allowed before this task stops being scheduled.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 7
            /// Pattern: ^([1-9][0-9]*|[0]|[1-9][0-9]%|[0-9]%|100%)$
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> MaxErrors { get; set; }

            /// <summary>
            /// Description
            /// A description of the task.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 128
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// ServiceRoleArn
            /// The ARN of the IAM service role to use to publish Amazon Simple Notification Service (Amazon SNS)
            /// notifications for maintenance window Run Command tasks.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> ServiceRoleArn { get; set; }

            /// <summary>
            /// Priority
            /// The priority of the task in the maintenance window. The lower the number, the higher the priority.
            /// Tasks that have the same priority are scheduled in parallel.
            /// Required: Yes
            /// Type: Integer
            /// Minimum: 0
            /// Update requires: No interruption
            /// </summary>
			public Union<int, IntrinsicFunction> Priority { get; set; }

            /// <summary>
            /// MaxConcurrency
            /// The maximum number of targets this task can be run for, in parallel.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 7
            /// Pattern: ^([1-9][0-9]*|[1-9][0-9]%|[1-9]%|100%)$
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> MaxConcurrency { get; set; }

            /// <summary>
            /// Targets
            /// The targets, either instances or window target IDs.
            /// Specify instances using Key=InstanceIds,Values=instanceid1,instanceid2 . Specify window target IDs
            /// using Key=WindowTargetIds,Values=window-target-id-1,window-target-id-2.
            /// Required: Yes
            /// Type: List of Target
            /// Maximum: 5
            /// Update requires: No interruption
            /// </summary>
			public List<Target> Targets { get; set; }

            /// <summary>
            /// Name
            /// The task name.
            /// Required: No
            /// Type: String
            /// Minimum: 3
            /// Maximum: 128
            /// Pattern: ^[a-zA-Z0-9_\-. ]{3,128}$
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// TaskArn
            /// The resource that the task uses during execution.
            /// For RUN_COMMAND and AUTOMATION task types, TaskArn is the SSM document name or Amazon Resource Name
            /// (ARN).
            /// For LAMBDA tasks, TaskArn is the function name or ARN.
            /// For STEP_FUNCTIONS tasks, TaskArn is the state machine ARN.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 1600
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> TaskArn { get; set; }

            /// <summary>
            /// TaskInvocationParameters
            /// The parameters to pass to the task when it runs. Populate only the fields that match the task type.
            /// All other fields should be empty.
            /// Required: No
            /// Type: TaskInvocationParameters
            /// Update requires: No interruption
            /// </summary>
			public TaskInvocationParameters TaskInvocationParameters { get; set; }

            /// <summary>
            /// WindowId
            /// The ID of the maintenance window where the task is registered.
            /// Required: Yes
            /// Type: String
            /// Minimum: 20
            /// Maximum: 20
            /// Pattern: ^mw-[0-9a-f]{17}$
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> WindowId { get; set; }

            /// <summary>
            /// TaskParameters
            /// The parameters to pass to the task when it runs.
            /// Note TaskParameters has been deprecated. To specify parameters to pass to a task when it runs,
            /// instead use the Parameters option in the TaskInvocationParameters structure. For information about
            /// how Systems Manager handles these options for the supported maintenance window task types, see
            /// MaintenanceWindowTaskInvocationParameters.
            /// Required: No
            /// Type: Json
            /// Update requires: No interruption
            /// </summary>
			public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> TaskParameters { get; set; }

            /// <summary>
            /// TaskType
            /// The type of task. Valid values: RUN_COMMAND, AUTOMATION, LAMBDA, STEP_FUNCTIONS.
            /// Required: Yes
            /// Type: String
            /// Allowed Values: AUTOMATION | LAMBDA | RUN_COMMAND | STEP_FUNCTIONS
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> TaskType { get; set; }

            /// <summary>
            /// LoggingInfo
            /// Information about an Amazon S3 bucket to write task-level logs to.
            /// Note LoggingInfo has been deprecated. To specify an S3 bucket to contain logs, instead use the
            /// OutputS3BucketName and OutputS3KeyPrefix options in the TaskInvocationParameters structure. For
            /// information about how Systems Manager handles these options for the supported maintenance window
            /// task types, see AWS Systems Manager MaintenanceWindowTask TaskInvocationParameters.
            /// Required: No
            /// Type: LoggingInfo
            /// Update requires: No interruption
            /// </summary>
			public LoggingInfo LoggingInfo { get; set; }

        }

        public string Type { get; } = "AWS::SSM::MaintenanceWindowTask";

        public MaintenanceWindowTaskProperties Properties { get; } = new MaintenanceWindowTaskProperties();

    }
}
