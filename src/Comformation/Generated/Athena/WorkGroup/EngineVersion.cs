using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Athena.WorkGroup
{
    /// <summary>
    /// AWS::Athena::WorkGroup EngineVersion
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-athena-workgroup-engineversion.html
    /// </summary>
    public class EngineVersion
    {

        /// <summary>
        /// SelectedEngineVersion
        /// The engine version requested by the user. Possible values are determined by the output of
        /// ListEngineVersions, including Auto. The default is Auto.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 128
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SelectedEngineVersion")]
        public Union<string, IntrinsicFunction> SelectedEngineVersion { get; set; }

        /// <summary>
        /// EffectiveEngineVersion
        /// Read only. The engine version on which the query runs. If the user requests a valid engine version
        /// other than Auto, the effective engine version is the same as the engine version that the user
        /// requested. If the user requests Auto, the effective engine version is chosen by Athena. When a
        /// request to update the engine version is made by a CreateWorkGroup or UpdateWorkGroup operation, the
        /// EffectiveEngineVersion field is ignored.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 128
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EffectiveEngineVersion")]
        public Union<string, IntrinsicFunction> EffectiveEngineVersion { get; set; }

    }
}
