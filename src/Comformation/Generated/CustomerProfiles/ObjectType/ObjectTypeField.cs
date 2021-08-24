using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CustomerProfiles.ObjectType
{
    /// <summary>
    /// AWS::CustomerProfiles::ObjectType ObjectTypeField
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-objecttype-objecttypefield.html
    /// </summary>
    public class ObjectTypeField
    {

        /// <summary>
        /// Source
        /// A field of a ProfileObject. For example: _source. FirstName, where “_source” is a ProfileObjectType
        /// of a Zendesk user and “FirstName” is a field in that ObjectType.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Source")]
        public Union<string, IntrinsicFunction> Source { get; set; }

        /// <summary>
        /// Target
        /// The location of the data in the standard ProfileObject model. For example: _profile. Address.
        /// PostalCode.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Target")]
        public Union<string, IntrinsicFunction> Target { get; set; }

        /// <summary>
        /// ContentType
        /// The content type of the field. Used for determining equality when searching.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ContentType")]
        public Union<string, IntrinsicFunction> ContentType { get; set; }

    }
}
