using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.FSx.FileSystem
{
    /// <summary>
    /// AWS::FSx::FileSystem WindowsConfiguration
    /// The Microsoft Windows configuration for the file system being created. This value is required if
    /// FileSystemType is set to WINDOWS.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filesystem-windowsconfiguration.html
    /// </summary>
    public class WindowsConfiguration
    {

        /// <summary>
        /// SelfManagedActiveDirectoryConfiguration
        /// The configuration that Amazon FSx uses to join the Windows File Server instance to your self-managed
        /// (including on-premises) Microsoft Active Directory (AD) directory.
        /// Required: No
        /// Type: SelfManagedActiveDirectoryConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SelfManagedActiveDirectoryConfiguration")]
        public SelfManagedActiveDirectoryConfiguration SelfManagedActiveDirectoryConfiguration { get; set; }

        /// <summary>
        /// WeeklyMaintenanceStartTime
        /// The preferred start time to perform weekly maintenance, formatted d:HH:MM in the UTC time zone.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("WeeklyMaintenanceStartTime")]
        public Union<string, IntrinsicFunction> WeeklyMaintenanceStartTime { get; set; }

        /// <summary>
        /// ActiveDirectoryId
        /// The ID for an existing AWS Managed Microsoft Active Directory (AD) instance that the file system
        /// should join when it&#39;s created.
        /// Required: No
        /// Type: String
        /// Minimum: 12
        /// Maximum: 12
        /// Pattern: ^d-[0-9a-f]{10}$
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("ActiveDirectoryId")]
        public Union<string, IntrinsicFunction> ActiveDirectoryId { get; set; }

        /// <summary>
        /// ThroughputCapacity
        /// The throughput of an Amazon FSx file system, measured in megabytes per second, in 2 to the nth
        /// increments, between 2^3 (8) and 2^11 (2048).
        /// Required: No
        /// Type: Integer
        /// Minimum: 8
        /// Maximum: 2048
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("ThroughputCapacity")]
        public Union<int, IntrinsicFunction> ThroughputCapacity { get; set; }

        /// <summary>
        /// CopyTagsToBackups
        /// A boolean flag indicating whether tags for the file system should be copied to backups. This value
        /// defaults to false. If it&#39;s set to true, all tags for the file system are copied to all automatic and
        /// user-initiated backups where the user doesn&#39;t specify tags. If this value is true, and you specify
        /// one or more tags, only the specified tags are copied to backups.
        /// Required: No
        /// Type: Boolean
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("CopyTagsToBackups")]
        public Union<bool, IntrinsicFunction> CopyTagsToBackups { get; set; }

        /// <summary>
        /// DailyAutomaticBackupStartTime
        /// The preferred time to take daily automatic backups, formatted HH:MM in the UTC time zone.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DailyAutomaticBackupStartTime")]
        public Union<string, IntrinsicFunction> DailyAutomaticBackupStartTime { get; set; }

        /// <summary>
        /// AutomaticBackupRetentionDays
        /// The number of days to retain automatic backups. The default is to retain backups for 7 days. Setting
        /// this value to 0 disables the creation of automatic backups. The maximum retention period for backups
        /// is 35 days.
        /// Required: No
        /// Type: Integer
        /// Minimum: 0
        /// Maximum: 35
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AutomaticBackupRetentionDays")]
        public Union<int, IntrinsicFunction> AutomaticBackupRetentionDays { get; set; }

    }
}
