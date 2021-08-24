using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoT.MitigationAction
{
    /// <summary>
    /// AWS::IoT::MitigationAction AddThingsToThingGroupParams
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-mitigationaction-addthingstothinggroupparams.html
    /// </summary>
    public class AddThingsToThingGroupParams
    {

        /// <summary>
        /// OverrideDynamicGroups
        /// Specifies if this mitigation action can move the things that triggered the mitigation action even if
        /// they are part of one or more dynamic thing groups.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("OverrideDynamicGroups")]
        public Union<bool, IntrinsicFunction> OverrideDynamicGroups { get; set; }

        /// <summary>
        /// ThingGroupNames
        /// The list of groups to which you want to add the things that triggered the mitigation action. You can
        /// add a thing to a maximum of 10 groups, but you can&#39;t add a thing to more than one group in the same
        /// hierarchy.
        /// Required: Yes
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ThingGroupNames")]
        public List<Union<string, IntrinsicFunction>> ThingGroupNames { get; set; }

    }
}
