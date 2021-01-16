using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ASK.Skill
{
    /// <summary>
    /// Alexa::ASK::Skill Overrides
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ask-skill-overrides.html
    /// </summary>
    public class Overrides
    {

        /// <summary>
        /// Manifest
        /// Overrides to apply to the skill manifest inside of the skill package. The skill manifest contains
        /// metadata about the skill. For more information, see Skill Manifest Schemas.
        /// Required: No
        /// Type: Json
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Manifest")]
        public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Manifest { get; set; }

    }
}
