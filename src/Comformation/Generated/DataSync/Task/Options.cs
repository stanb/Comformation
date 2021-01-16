using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DataSync.Task
{
    /// <summary>
    /// AWS::DataSync::Task Options
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-task-options.html
    /// </summary>
    public class Options
    {

        /// <summary>
        /// Atime
        /// A file metadata value that shows the last time a file was accessed (that is, when the file was read
        /// or written to). If you set Atime to BEST_EFFORT, DataSync attempts to preserve the original Atime
        /// attribute on all source files (that is, the version before the PREPARING phase). However, Atime&#39;s
        /// behavior is not fully standard across platforms, so AWS DataSync can only do this on a best-effort
        /// basis.
        /// Default value: BEST_EFFORT.
        /// BEST_EFFORT: Attempt to preserve the per-file Atime value (recommended).
        /// NONE: Ignore Atime.
        /// Note If Atime is set to BEST_EFFORT, Mtime must be set to PRESERVE. If Atime is set to NONE, Mtime
        /// must also be NONE.
        /// Required: No
        /// Type: String
        /// Allowed values: BEST_EFFORT | NONE
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Atime")]
        public Union<string, IntrinsicFunction> Atime { get; set; }

        /// <summary>
        /// BytesPerSecond
        /// A value that limits the bandwidth used by AWS DataSync. For example, if you want AWS DataSync to use
        /// a maximum of 1 MB, set this value to 1048576 (=1024*1024).
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BytesPerSecond")]
        public Union<int, IntrinsicFunction> BytesPerSecond { get; set; }

        /// <summary>
        /// Gid
        /// The group ID (GID) of the file&#39;s owners.
        /// Default value: INT_VALUE. This preserves the integer value of the ID.
        /// INT_VALUE: Preserve the integer value of UID and group ID (GID) (recommended).
        /// NAME: Currently not supported
        /// NONE: Ignore UID and GID.
        /// Required: No
        /// Type: String
        /// Allowed values: BOTH | INT_VALUE | NAME | NONE
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Gid")]
        public Union<string, IntrinsicFunction> Gid { get; set; }

        /// <summary>
        /// LogLevel
        /// A value that determines the type of logs that DataSync publishes to a log stream in the Amazon
        /// CloudWatch log group that you provide. For more information about providing a log group for
        /// DataSync, see CloudWatchLogGroupArn. If set to OFF, no logs are published. BASIC publishes logs on
        /// errors for individual files transferred, and TRANSFER publishes logs for every file or object that
        /// is transferred and integrity checked.
        /// Required: No
        /// Type: String
        /// Allowed values: BASIC | OFF | TRANSFER
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LogLevel")]
        public Union<string, IntrinsicFunction> LogLevel { get; set; }

        /// <summary>
        /// Mtime
        /// A value that indicates the last time that a file was modified (that is, a file was written to)
        /// before the PREPARING phase.
        /// Default value: PRESERVE.
        /// PRESERVE: Preserve original Mtime (recommended)
        /// NONE: Ignore Mtime.
        /// Note If Mtime is set to PRESERVE, Atime must be set to BEST_EFFORT. If Mtime is set to NONE, Atime
        /// must also be set to NONE.
        /// Required: No
        /// Type: String
        /// Allowed values: NONE | PRESERVE
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Mtime")]
        public Union<string, IntrinsicFunction> Mtime { get; set; }

        /// <summary>
        /// OverwriteMode
        /// A value that determines whether files at the destination should be overwritten or preserved when
        /// copying files. If set to NEVER a destination file will not be replaced by a source file, even if the
        /// destination file differs from the source file. If you modify files in the destination and you sync
        /// the files, you can use this value to protect against overwriting those changes.
        /// Some storage classes have specific behaviors that can affect your S3 storage cost. For detailed
        /// information, see using-storage-classes in the AWS DataSync User Guide.
        /// Required: No
        /// Type: String
        /// Allowed values: ALWAYS | NEVER
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("OverwriteMode")]
        public Union<string, IntrinsicFunction> OverwriteMode { get; set; }

        /// <summary>
        /// PosixPermissions
        /// A value that determines which users or groups can access a file for a specific purpose such as
        /// reading, writing, or execution of the file.
        /// Default value: PRESERVE.
        /// PRESERVE: Preserve POSIX-style permissions (recommended).
        /// NONE: Ignore permissions.
        /// Note AWS DataSync can preserve extant permissions of a source location.
        /// Required: No
        /// Type: String
        /// Allowed values: NONE | PRESERVE
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PosixPermissions")]
        public Union<string, IntrinsicFunction> PosixPermissions { get; set; }

        /// <summary>
        /// PreserveDeletedFiles
        /// A value that specifies whether files in the destination that don&#39;t exist in the source file system
        /// should be preserved. This option can affect your storage cost. If your task deletes objects, you
        /// might incur minimum storage duration charges for certain storage classes. For detailed information,
        /// see using-storage-classes in the AWS DataSync User Guide.
        /// Default value: PRESERVE.
        /// PRESERVE: Ignore such destination files (recommended).
        /// REMOVE: Delete destination files that aren’t present in the source.
        /// Required: No
        /// Type: String
        /// Allowed values: PRESERVE | REMOVE
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PreserveDeletedFiles")]
        public Union<string, IntrinsicFunction> PreserveDeletedFiles { get; set; }

        /// <summary>
        /// PreserveDevices
        /// A value that determines whether AWS DataSync should preserve the metadata of block and character
        /// devices in the source file system, and recreate the files with that device name and metadata on the
        /// destination.
        /// Note AWS DataSync can&#39;t sync the actual contents of such devices, because they are nonterminal and
        /// don&#39;t return an end-of-file (EOF) marker.
        /// Default value: NONE.
        /// NONE: Ignore special devices (recommended).
        /// PRESERVE: Preserve character and block device metadata. This option isn&#39;t currently supported for
        /// Amazon EFS.
        /// Required: No
        /// Type: String
        /// Allowed values: NONE | PRESERVE
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PreserveDevices")]
        public Union<string, IntrinsicFunction> PreserveDevices { get; set; }

        /// <summary>
        /// TaskQueueing
        /// A value that determines whether tasks should be queued before executing the tasks. If set to
        /// ENABLED, the tasks will be queued. The default is ENABLED.
        /// If you use the same agent to run multiple tasks, you can enable the tasks to run in series. For more
        /// information, see queue-task-execution.
        /// Required: No
        /// Type: String
        /// Allowed values: DISABLED | ENABLED
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TaskQueueing")]
        public Union<string, IntrinsicFunction> TaskQueueing { get; set; }

        /// <summary>
        /// TransferMode
        /// A value that determines whether DataSync transfers only the data and metadata that differ between
        /// the source and the destination location, or whether DataSync transfers all the content from the
        /// source, without comparing to the destination location.
        /// CHANGED: DataSync copies only data or metadata that is new or different content from the source
        /// location to the destination location.
        /// ALL: DataSync copies all source location content to the destination, without comparing to existing
        /// content on the destination.
        /// Required: No
        /// Type: String
        /// Allowed values: ALL | CHANGED
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TransferMode")]
        public Union<string, IntrinsicFunction> TransferMode { get; set; }

        /// <summary>
        /// Uid
        /// The user ID (UID) of the file&#39;s owner.
        /// Default value: INT_VALUE. This preserves the integer value of the ID.
        /// INT_VALUE: Preserve the integer value of UID and group ID (GID) (recommended).
        /// NAME: Currently not supported
        /// NONE: Ignore UID and GID.
        /// Required: No
        /// Type: String
        /// Allowed values: BOTH | INT_VALUE | NAME | NONE
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Uid")]
        public Union<string, IntrinsicFunction> Uid { get; set; }

        /// <summary>
        /// VerifyMode
        /// A value that determines whether a data integrity verification should be performed at the end of a
        /// task execution after all data and metadata have been transferred. For more information, see
        /// create-task
        /// Default value: POINT_IN_TIME_CONSISTENT.
        /// ONLY_FILES_TRANSFERRED (recommended): Perform verification only on files that were transferred.
        /// POINT_IN_TIME_CONSISTENT: Scan the entire source and entire destination at the end of the transfer
        /// to verify that source and destination are fully synchronized. This option isn&#39;t supported when
        /// transferring to S3 Glacier or S3 Glacier Deep Archive storage classes.
        /// NONE: No additional verification is done at the end of the transfer, but all data transmissions are
        /// integrity-checked with checksum verification during the transfer.
        /// Required: No
        /// Type: String
        /// Allowed values: NONE | ONLY_FILES_TRANSFERRED | POINT_IN_TIME_CONSISTENT
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("VerifyMode")]
        public Union<string, IntrinsicFunction> VerifyMode { get; set; }

    }
}
