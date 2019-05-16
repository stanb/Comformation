using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ASK.Skill
{
    /// <summary>
    /// Alexa::ASK::Skill Overrides
    /// The Overrides property type provides overrides to the skill package to apply when creating or updating the
    /// skill. Values provided here do not modify the contents of the original skill package. Currently, only
    /// overriding values inside of the skill manifest component of the package is supported.
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
