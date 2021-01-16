using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ECS.Service
{
    /// <summary>
    /// AWS::ECS::Service DeploymentCircuitBreaker
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-deploymentcircuitbreaker.html
    /// </summary>
    public class DeploymentCircuitBreaker
    {

        /// <summary>
        /// Enable
        /// 		
        /// Whether to enable the deployment circuit breaker logic for the service.
        /// 	
        /// Required: Yes
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Enable")]
        public Union<bool, IntrinsicFunction> Enable { get; set; }

        /// <summary>
        /// Rollback
        /// 		
        /// Whether to enable Amazon ECS to roll back the service if a service deployment fails. If 			rollback
        /// is enabled, when a service deployment fails, the service is rolled back to the 			last deployment
        /// that completed successfully.
        /// 	
        /// Required: Yes
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Rollback")]
        public Union<bool, IntrinsicFunction> Rollback { get; set; }

    }
}
