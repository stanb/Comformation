using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.OpsWorks.Stack
{
    /// <summary>
    /// AWS OpsWorks Stack RdsDbInstance
    /// RdsDbInstance is a property of the AWS::OpsWorks::Stack resource that registers an Amazon Relational Database
    /// Service (Amazon RDS) DB instance with an AWS OpsWorks stack.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opsworks-stack-rdsdbinstance.html
    /// </summary>
    public class RdsDbInstance
    {

        /// <summary>
        /// DbPassword
        /// The password of the registered database.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("DbPassword")]
        public Union<string, IntrinsicFunction> DbPassword { get; set; }

        /// <summary>
        /// DbUser
        /// The master user name of the registered database.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("DbUser")]
        public Union<string, IntrinsicFunction> DbUser { get; set; }

        /// <summary>
        /// RdsDbInstanceArn
        /// The Amazon Resource Name (ARN) of the Amazon RDS DB instance to register with the AWS OpsWorks
        /// stack.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("RdsDbInstanceArn")]
        public Union<string, IntrinsicFunction> RdsDbInstanceArn { get; set; }

    }
}
