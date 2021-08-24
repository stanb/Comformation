using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.RDS.DBCluster
{
    /// <summary>
    /// AWS::RDS::DBCluster DBClusterRole
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-dbcluster-dbclusterrole.html
    /// </summary>
    public class DBClusterRole
    {

        /// <summary>
        /// FeatureName
        /// The name of the feature associated with the AWS Identity and Access Management (IAM) role. IAM roles
        /// that are associated with a DB cluster grant permission for the DB cluster to access other AWS
        /// services on your behalf. For the list of supported feature names, see the SupportedFeatureNames
        /// description in DBEngineVersion in the Amazon RDS API Reference.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FeatureName")]
        public Union<string, IntrinsicFunction> FeatureName { get; set; }

        /// <summary>
        /// RoleArn
        /// The Amazon Resource Name (ARN) of the IAM role that is associated with the DB cluster.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RoleArn")]
        public Union<string, IntrinsicFunction> RoleArn { get; set; }

    }
}
