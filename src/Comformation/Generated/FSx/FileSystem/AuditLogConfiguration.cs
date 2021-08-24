using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.FSx.FileSystem
{
    /// <summary>
    /// AWS::FSx::FileSystem AuditLogConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filesystem-windowsconfiguration-auditlogconfiguration.html
    /// </summary>
    public class AuditLogConfiguration
    {

        /// <summary>
        /// FileAccessAuditLogLevel
        /// Sets which attempt type is logged by Amazon FSx for end-user accesses of files and folders.
        /// SUCCESS_ONLY - only successful attempts to access files or folders are logged. FAILURE_ONLY - only
        /// failed attempts to access files or folders are logged. SUCCESS_AND_FAILURE - both successful
        /// attempts and failed attempts to access files or folders are logged. DISABLED - access auditing of
        /// files and folders is turned off.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FileAccessAuditLogLevel")]
        public Union<string, IntrinsicFunction> FileAccessAuditLogLevel { get; set; }

        /// <summary>
        /// FileShareAccessAuditLogLevel
        /// Sets which attempt type is logged by Amazon FSx for end-user accesses of file shares.
        /// SUCCESS_ONLY - only successful attempts to access file shares are logged. FAILURE_ONLY - only failed
        /// attempts to access file shares are logged. SUCCESS_AND_FAILURE - both successful attempts and failed
        /// attempts to access file shares are logged. DISABLED - access auditing of file shares is turned off.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FileShareAccessAuditLogLevel")]
        public Union<string, IntrinsicFunction> FileShareAccessAuditLogLevel { get; set; }

        /// <summary>
        /// AuditLogDestination
        /// The Amazon Resource Name (ARN) that specifies the destination of the audit event logs.
        /// The destination can be any Amazon CloudWatch Logs log group ARN or Amazon Kinesis Data Firehose
        /// delivery stream ARN, with the following requirements:
        /// The destination ARN that you provide (either CloudWatch Logs log group or Kinesis Data Firehose
        /// delivery stream) must be in the same AWS partition, AWS Region, and AWS account as your Amazon FSx
        /// file system. The name of the CloudWatch Logs log group must begin with the /aws/fsx/ prefix. The
        /// name of the Kinesis Data Firehose delivery stream must begin with the aws-fsx- prefix. If you do not
        /// provide a destination in AuditLogDestination, Amazon FSx will create and use a log stream in the
        /// CloudWatch Logs /aws/fsx/windows log group. If AuditLogDestination is provided and the resource does
        /// not exist, the request will fail with a BadRequest error. If FileAccessAuditLogLevel and
        /// FileShareAccessAuditLogLevel are both set to DISABLED, you cannot specify a destination in
        /// AuditLogDestination.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AuditLogDestination")]
        public Union<string, IntrinsicFunction> AuditLogDestination { get; set; }

    }
}
