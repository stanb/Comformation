using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CustomerProfiles.ObjectType
{
    /// <summary>
    /// AWS::CustomerProfiles::ObjectType FieldMap
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-objecttype-fieldmap.html
    /// </summary>
    public class FieldMap
    {

        /// <summary>
        /// Name
        /// Name of the field.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

        /// <summary>
        /// ObjectTypeField
        /// Represents a field in a ProfileObjectType.
        /// Required: No
        /// Type: ObjectTypeField
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ObjectTypeField")]
        public ObjectTypeField ObjectTypeField { get; set; }

    }
}
