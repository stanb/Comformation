using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SSM.MaintenanceWindowTask
{
    /// <summary>
    /// AWS Systems Manager MaintenanceWindowTask Target
    /// The Target property type specifies targets (either instances or tags). You specify instances by using
    /// Key=instanceids,Values=instanceid1,instanceid2. You specify tags by using Key=tag name,Values=tag value for a
    /// Maintenance Window task in AWS Systems Manager.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-maintenancewindowtask-target.html
    /// </summary>
    public class Target
    {

        /// <summary>
        /// Values
        /// User-defined criteria that maps to Key. For example, if you specify tag:ServerRole, you can specify
        /// value:WebServer to execute a command on instances that include Amazon EC2 tags of
        /// ServerRole,WebServer. For more information about how to send commands that target instances using
        /// Key,Value parameters, see Sending Commands to a Fleet in the AWS Systems Manager User Guide.
        /// Required: No
        /// Type: List of String values
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Values")]
        public List<Union<string, IntrinsicFunction>> Values { get; set; }

        /// <summary>
        /// Key
        /// User-defined criteria for sending commands that target instances that meet the criteria. Key can be
        /// tag:Amazon EC2 tag or InstanceIds. For more information about how to send commands that target
        /// instances by using Key,Value parameters, see Sending Commands to a Fleet in the AWS Systems Manager
        /// User Guide.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Key")]
        public Union<string, IntrinsicFunction> Key { get; set; }

    }
}
