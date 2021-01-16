using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.RDS.DBInstance
{
    /// <summary>
    /// AWS::RDS::DBInstance DBInstanceRole
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-dbinstance-dbinstancerole.html
    /// </summary>
    public class DBInstanceRole
    {

        /// <summary>
        /// FeatureName
        /// The name of the feature associated with the AWS Identity and Access Management (IAM) role. IAM roles
        /// that are associated with a DB instance grant permission for the DB instance to access other AWS
        /// services on your behalf. For the list of supported feature names, see DBEngineVersion in the Amazon
        /// RDS API Reference.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FeatureName")]
        public Union<string, IntrinsicFunction> FeatureName { get; set; }

        /// <summary>
        /// RoleArn
        /// The Amazon Resource Name (ARN) of the IAM role that is associated with the DB instance.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RoleArn")]
        public Union<string, IntrinsicFunction> RoleArn { get; set; }

    }
}
