using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ECS.TaskDefinition
{
    /// <summary>
    /// AWS::ECS::TaskDefinition HealthCheck
    /// The HealthCheck property specifies an object representing a container health check. Health check parameters
    /// that are specified in a container definition override any Docker health checks that exist in the container
    /// image (such as those specified in a parent image or from the image&#39;s Dockerfile).
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-healthcheck.html
    /// </summary>
    public class HealthCheck
    {

        /// <summary>
        /// Command
        /// A string array representing the command that the container runs to determine if it is healthy. The
        /// string array must start with CMD to execute the command arguments directly, or CMD-SHELL to run the
        /// command with the container&#39;s default shell. For example:
        /// [ &quot;CMD-SHELL&quot;, &quot;curl -f http://localhost/ || exit 1&quot; ]
        /// An exit code of 0 indicates success, and non-zero exit code indicates failure. For more information,
        /// see HealthCheck in the Create a container section of the Docker Remote API.
        /// Required: Yes
        /// Type: List of String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Command")]
        public List<Union<string, IntrinsicFunction>> Command { get; set; }

        /// <summary>
        /// Interval
        /// The time period in seconds between each health check execution. You may specify between 5 and 300
        /// seconds. The default value is 30 seconds.
        /// Required: No
        /// Type: Integer
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Interval")]
        public Union<int, IntrinsicFunction> Interval { get; set; }

        /// <summary>
        /// Retries
        /// The number of times to retry a failed health check before the container is considered unhealthy. You
        /// may specify between 1 and 10 retries. The default value is 3.
        /// Required: No
        /// Type: Integer
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Retries")]
        public Union<int, IntrinsicFunction> Retries { get; set; }

        /// <summary>
        /// StartPeriod
        /// The optional grace period within which to provide containers time to bootstrap before failed health
        /// checks count towards the maximum number of retries. You may specify between 0 and 300 seconds. The
        /// startPeriod is disabled by default.
        /// Note If a health check succeeds within the startPeriod, then the container is considered healthy and
        /// any subsequent failures count toward the maximum number of retries.
        /// Required: No
        /// Type: Integer
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("StartPeriod")]
        public Union<int, IntrinsicFunction> StartPeriod { get; set; }

        /// <summary>
        /// Timeout
        /// The time period in seconds to wait for a health check to succeed before it is considered a failure.
        /// You may specify between 2 and 60 seconds. The default value is 5.
        /// Required: No
        /// Type: Integer
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Timeout")]
        public Union<int, IntrinsicFunction> Timeout { get; set; }

    }
}
