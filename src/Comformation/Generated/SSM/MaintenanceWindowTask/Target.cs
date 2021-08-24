using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SSM.MaintenanceWindowTask
{
    /// <summary>
    /// AWS::SSM::MaintenanceWindowTask Target
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-maintenancewindowtask-target.html
    /// </summary>
    public class Target
    {

        /// <summary>
        /// Values
        /// User-defined criteria that maps to Key. For example, if you specify InstanceIds, you can specify
        /// i-1234567890abcdef0,i-9876543210abcdef0 to run a command on two EC2 instances. For more information
        /// about how to target instances within a maintenance window task, see About
        /// &#39;register-task-with-maintenance-window&#39; Options and Values in the AWS Systems Manager User Guide.
        /// Required: Yes
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
        /// Maximum: 163
        /// Pattern: ^[\p{L}\p{Z}\p{N}_. :/=\-@]*$|resource-groups:ResourceTypeFilters|resource-groups:Name
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Key")]
        public Union<string, IntrinsicFunction> Key { get; set; }

    }
}
