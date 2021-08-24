using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Neptune.DBCluster
{
    /// <summary>
    /// AWS::Neptune::DBCluster DBClusterRole
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-neptune-dbcluster-dbclusterrole.html
    /// </summary>
    public class DBClusterRole
    {

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
        /// FeatureName
        /// The name of the feature associated with the Amazon Identity and Access Management (IAM) role. For
        /// the list of supported feature names, see DescribeDBEngineVersions.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FeatureName")]
        public Union<string, IntrinsicFunction> FeatureName { get; set; }

    }
}
