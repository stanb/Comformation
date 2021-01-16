using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Config.RemediationConfiguration
{
    /// <summary>
    /// AWS::Config::RemediationConfiguration SsmControls
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-remediationconfiguration-ssmcontrols.html
    /// </summary>
    public class SsmControls
    {

        /// <summary>
        /// ErrorPercentage
        /// 		
        /// The percentage of errors that are allowed before SSM stops running automations on non-compliant
        /// resources for that specific rule. 			You can specify a percentage of errors, for example 10%. If you
        /// do not specifiy a percentage, the default is 50%. 			For example, if you set the ErrorPercentage to
        /// 40% for 10 non-compliant resources, then SSM stops running the automations when the fifth error is
        /// received.
        /// 	
        /// Required: No
        /// Type: Integer
        /// Minimum: 1
        /// Maximum: 100
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ErrorPercentage")]
        public Union<int, IntrinsicFunction> ErrorPercentage { get; set; }

        /// <summary>
        /// ConcurrentExecutionRatePercentage
        /// 		
        /// The maximum percentage of remediation actions allowed to run in parallel on the non-compliant
        /// resources for that specific rule. You can specify a percentage, such as 10%. The default value is
        /// 10.
        /// 	
        /// Required: No
        /// Type: Integer
        /// Minimum: 1
        /// Maximum: 100
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ConcurrentExecutionRatePercentage")]
        public Union<int, IntrinsicFunction> ConcurrentExecutionRatePercentage { get; set; }

    }
}
