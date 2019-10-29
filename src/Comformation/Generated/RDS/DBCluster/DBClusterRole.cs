using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.RDS.DBCluster
{
    /// <summary>
    /// AWS::RDS::DBCluster DBClusterRole
    /// Describes an AWS Identity and Access Management (IAM) role that is associated with a DB cluster.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-dbcluster-dbclusterrole.html
    /// </summary>
    public class DBClusterRole
    {

        /// <summary>
        /// FeatureName
        /// The name of the feature associated with the AWS Identity and Access Management (IAM) role. For the
        /// list of supported feature names, see DBEngineVersion in the Amazon RDS API Reference.
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

        /// <summary>
        /// Status
        /// Describes the state of association between the IAM role and the DB cluster. The Status property
        /// returns one of the following values:
        /// ACTIVE - the IAM role ARN is associated with the DB cluster and can be used to access other AWS
        /// services on your behalf. PENDING - the IAM role ARN is being associated with the DB cluster. INVALID
        /// - the IAM role ARN is associated with the DB cluster, but the DB cluster is unable to assume the IAM
        /// role in order to access other AWS services on your behalf.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Status")]
        public Union<string, IntrinsicFunction> Status { get; set; }

    }
}
