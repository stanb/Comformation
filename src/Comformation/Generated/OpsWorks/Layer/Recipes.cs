using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.OpsWorks.Layer
{
    /// <summary>
    /// AWS OpsWorks Recipes Type
    /// Describes custom event recipes for the AWS::OpsWorks::Layer resource type that AWS OpsWorks runs after the
    /// standard event recipes. For more information, see AWS OpsWorks Lifecycle Events in the AWS OpsWorks User
    /// Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opsworks-layer-recipes.html
    /// </summary>
    public class Recipes
    {

        /// <summary>
        /// Configure
        /// Custom recipe names to be run following a Configure event. The event occurs on all of the stack&#39;s
        /// instances when an instance enters or leaves the online state.
        /// Required: No
        /// Type: List of String values
        /// </summary>
        [JsonProperty("Configure")]
        public List<Union<string, IntrinsicFunction>> Configure { get; set; }

        /// <summary>
        /// Deploy
        /// Custom recipe names to be run following a Deploy event. The event occurs when you run a deploy
        /// command, typically to deploy an application to a set of application server instances.
        /// Required: No
        /// Type: List of String values
        /// </summary>
        [JsonProperty("Deploy")]
        public List<Union<string, IntrinsicFunction>> Deploy { get; set; }

        /// <summary>
        /// Setup
        /// Custom recipe names to be run following a Setup event. This event occurs on a new instance after it
        /// successfully boots.
        /// Required: No
        /// Type: List of String values
        /// </summary>
        [JsonProperty("Setup")]
        public List<Union<string, IntrinsicFunction>> Setup { get; set; }

        /// <summary>
        /// Shutdown
        /// Custom recipe names to be run following a Shutdown event. This event occurs after you direct AWS
        /// OpsWorks to shut an instance down before the associated Amazon EC2 instance is actually terminated.
        /// Required: No
        /// Type: List of String values
        /// </summary>
        [JsonProperty("Shutdown")]
        public List<Union<string, IntrinsicFunction>> Shutdown { get; set; }

        /// <summary>
        /// Undeploy
        /// Custom recipe names to be run following a Undeploy event. This event occurs when you delete an app
        /// or run an undeploy command to remove an app from a set of application server instances.
        /// Required: No
        /// Type: List of String values
        /// </summary>
        [JsonProperty("Undeploy")]
        public List<Union<string, IntrinsicFunction>> Undeploy { get; set; }

    }
}
