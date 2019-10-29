using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Config.RemediationConfiguration
{
    /// <summary>
    /// AWS::Config::RemediationConfiguration ExecutionControls
    /// The controls that AWS Config uses for executing remediations.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-remediationconfiguration-executioncontrols.html
    /// </summary>
    public class ExecutionControls
    {

        /// <summary>
        /// SsmControls
        /// 		
        /// A SsmControls object.
        /// 	
        /// Required: No
        /// Type: SsmControls
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SsmControls")]
        public SsmControls SsmControls { get; set; }

    }
}
