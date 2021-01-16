using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.OpsWorks.Stack
{
    /// <summary>
    /// AWS::OpsWorks::Stack RdsDbInstance
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opsworks-stack-rdsdbinstance.html
    /// </summary>
    public class RdsDbInstance
    {

        /// <summary>
        /// DbPassword
        /// AWS OpsWorks Stacks returns *****FILTERED***** instead of the actual value.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DbPassword")]
        public Union<string, IntrinsicFunction> DbPassword { get; set; }

        /// <summary>
        /// DbUser
        /// The master user name.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DbUser")]
        public Union<string, IntrinsicFunction> DbUser { get; set; }

        /// <summary>
        /// RdsDbInstanceArn
        /// The instance&#39;s ARN.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RdsDbInstanceArn")]
        public Union<string, IntrinsicFunction> RdsDbInstanceArn { get; set; }

    }
}
