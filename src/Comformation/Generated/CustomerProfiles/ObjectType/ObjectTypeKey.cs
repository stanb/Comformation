using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CustomerProfiles.ObjectType
{
    /// <summary>
    /// AWS::CustomerProfiles::ObjectType ObjectTypeKey
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-objecttype-objecttypekey.html
    /// </summary>
    public class ObjectTypeKey
    {

        /// <summary>
        /// FieldNames
        /// The reference for the key name of the fields map.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FieldNames")]
        public List<Union<string, IntrinsicFunction>> FieldNames { get; set; }

        /// <summary>
        /// StandardIdentifiers
        /// The types of keys that a ProfileObject can have. Each ProfileObject can have only 1 UNIQUE key but
        /// multiple PROFILE keys. PROFILE means that this key can be used to tie an object to a PROFILE. UNIQUE
        /// means that it can be used to uniquely identify an object. If a key a is marked as SECONDARY, it will
        /// be used to search for profiles after all other PROFILE keys have been searched. A LOOKUP_ONLY key is
        /// only used to match a profile but is not persisted to be used for searching of the profile. A
        /// NEW_ONLY key is only used if the profile does not already exist before the object is ingested,
        /// otherwise it is only used for matching objects to profiles.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("StandardIdentifiers")]
        public List<Union<string, IntrinsicFunction>> StandardIdentifiers { get; set; }

    }
}
