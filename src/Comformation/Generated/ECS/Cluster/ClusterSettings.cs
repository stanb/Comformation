using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ECS.Cluster
{
    /// <summary>
    /// AWS::ECS::Cluster ClusterSettings
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-cluster-clustersettings.html
    /// </summary>
    public class ClusterSettings
    {

        /// <summary>
        /// Name
        /// 		
        /// The name of the cluster setting. The only supported value is 				containerInsights.
        /// 	
        /// Required: No
        /// Type: String
        /// Allowed values: containerInsights
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

        /// <summary>
        /// Value
        /// The value to set for the cluster setting. The supported values are enabled and disabled. If enabled
        /// is specified, CloudWatch Container Insights will be enabled for the cluster, otherwise it will be
        /// disabled unless the containerInsights account setting is enabled. If a cluster value is specified,
        /// it will override the containerInsights value set with PutAccountSetting or PutAccountSettingDefault.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Value")]
        public Union<string, IntrinsicFunction> Value { get; set; }

    }
}
