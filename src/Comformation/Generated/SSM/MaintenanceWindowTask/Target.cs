using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SSM.MaintenanceWindowTask
{
    /// <summary>
    /// AWS::SSM::MaintenanceWindowTask Target
    /// The Target property type specifies targets (either instances or window target IDs). You specify instances by
    /// using Key=InstanceIds,Values=&amp;lt;instanceid1&amp;gt;,&amp;lt;instanceid2&amp;gt;. You specify window target IDs using
    /// Key=WindowTargetIds,Values=&amp;lt;window-target-id-1&amp;gt;,&amp;lt;window-target-id-2&amp;gt; for a Maintenance Window task
    /// in AWS Systems Manager.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-maintenancewindowtask-target.html
    /// </summary>
    public class Target
    {

        /// <summary>
        /// Values
        /// User-defined criteria that maps to Key. For example, if you specify InstanceIds, you can specify
        /// i-1234567890abcdef0,i-9876543210abcdef0 to execute a command on two EC2 instances. For more
        /// information about how to target instances within a maintenance window task, see About
        /// &#39;register-task-with-maintenance-window&#39; Options and Values in the AWS Systems Manager User Guide.
        /// Required: No
        /// Type: List of String
        /// Maximum: 50
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Values")]
        public List<Union<string, IntrinsicFunction>> Values { get; set; }

        /// <summary>
        /// Key
        /// User-defined criteria for sending commands that target instances that meet the criteria. Key can be
        /// InstanceIds or WindowTargetIds. For more information about how to target instances within a
        /// maintenance window task, see About &#39;register-task-with-maintenance-window&#39; Options and Values in the
        /// AWS Systems Manager User Guide.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 128
        /// Pattern: ^[\p{L}\p{Z}\p{N}_. :/=\-@]*$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Key")]
        public Union<string, IntrinsicFunction> Key { get; set; }

    }
}
