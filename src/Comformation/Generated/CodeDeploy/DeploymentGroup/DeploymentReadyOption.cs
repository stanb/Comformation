using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodeDeploy.DeploymentGroup
{
    /// <summary>
    /// AWS::CodeDeploy::DeploymentGroup DeploymentReadyOption
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentgroup-deploymentreadyoption.html
    /// </summary>
    public class DeploymentReadyOption
    {

        /// <summary>
        /// ActionOnTimeout
        /// Information about when to reroute traffic from an original environment to a replacement environment
        /// in a blue/green deployment.
        /// CONTINUE_DEPLOYMENT: Register new instances with the load balancer immediately after the new
        /// application revision is installed on the instances in the replacement environment. STOP_DEPLOYMENT:
        /// Do not register new instances with a load balancer unless traffic rerouting is started using
        /// ContinueDeployment . If traffic rerouting is not started before the end of the specified wait
        /// period, the deployment status is changed to Stopped.
        /// Required: No
        /// Type: String
        /// Allowed values: CONTINUE_DEPLOYMENT | STOP_DEPLOYMENT
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ActionOnTimeout")]
        public Union<string, IntrinsicFunction> ActionOnTimeout { get; set; }

        /// <summary>
        /// WaitTimeInMinutes
        /// The number of minutes to wait before the status of a blue/green deployment is changed to Stopped if
        /// rerouting is not started manually. Applies only to the STOP_DEPLOYMENT option for actionOnTimeout.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("WaitTimeInMinutes")]
        public Union<int, IntrinsicFunction> WaitTimeInMinutes { get; set; }

    }
}
