using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ECS.Cluster
{
    /// <summary>
    /// AWS::ECS::Cluster ClusterConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-cluster-clusterconfiguration.html
    /// </summary>
    public class ClusterConfiguration
    {

        /// <summary>
        /// ExecuteCommandConfiguration
        /// 		
        /// The details of the execute command configuration.
        /// 	
        /// Required: No
        /// Type: ExecuteCommandConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ExecuteCommandConfiguration")]
        public ExecuteCommandConfiguration ExecuteCommandConfiguration { get; set; }

    }
}
