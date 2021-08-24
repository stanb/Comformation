using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SSM.MaintenanceWindowTarget
{
    /// <summary>
    /// AWS::SSM::MaintenanceWindowTarget Targets
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-maintenancewindowtarget-targets.html
    /// </summary>
    public class Targets
    {

        /// <summary>
        /// Values
        /// User-defined criteria that maps to Key. For example, if you specified tag:ServerRole, you could
        /// specify value:WebServer to run a command on instances that include EC2 tags of ServerRole,WebServer.
        /// Depending on the type of target, the maximum number of values for a key might be lower than the
        /// global maximum of 50.
        /// Required: Yes
        /// Type: List of String
        /// Maximum: 50
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Values")]
        public List<Union<string, IntrinsicFunction>> Values { get; set; }

        /// <summary>
        /// Key
        /// User-defined criteria for sending commands that target instances that meet the criteria.
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
