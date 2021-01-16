using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SecretsManager.RotationSchedule
{
    /// <summary>
    /// AWS::SecretsManager::RotationSchedule RotationRules
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-secretsmanager-rotationschedule-rotationrules.html
    /// </summary>
    public class RotationRules
    {

        /// <summary>
        /// AutomaticallyAfterDays
        /// Specifies the number of days after the previous rotation before Secrets Manager triggers the next
        /// automatic rotation.
        /// You can specify a minimum value of 1 and a maximum value of 1000.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AutomaticallyAfterDays")]
        public Union<int, IntrinsicFunction> AutomaticallyAfterDays { get; set; }

    }
}
