using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.CustomerProfiles.ObjectType
{
    /// <summary>
    /// AWS::CustomerProfiles::ObjectType
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-customerprofiles-objecttype.html
    /// </summary>
    public class ObjectTypeResource : ResourceBase
    {
        public class ObjectTypeProperties
        {
            /// <summary>
            /// DomainName
            /// The unique name of the domain.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> DomainName { get; set; }

            /// <summary>
            /// ObjectTypeName
            /// The name of the profile object type.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ObjectTypeName { get; set; }

            /// <summary>
            /// AllowProfileCreation
            /// Indicates whether a profile should be created when data is received if one doesn’t exist for an
            /// object of this type. The default is FALSE. If the AllowProfileCreation flag is set to FALSE, then
            /// the service tries to fetch a standard profile and associate this object with the profile. If it is
            /// set to TRUE, and if no match is found, then the service creates a new standard profile.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> AllowProfileCreation { get; set; }

            /// <summary>
            /// Description
            /// The description of the profile object type mapping.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// EncryptionKey
            /// The customer-provided key to encrypt the profile object that will be created in this profile object
            /// type mapping. If not specified the system will use the encryption key of the domain.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> EncryptionKey { get; set; }

            /// <summary>
            /// ExpirationDays
            /// The number of days until the data of this type expires.
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> ExpirationDays { get; set; }

            /// <summary>
            /// Fields
            /// A list of field definitions for the object type mapping.
            /// Required: No
            /// Type: List of FieldMap
            /// Update requires: No interruption
            /// </summary>
            public List<FieldMap> Fields { get; set; }

            /// <summary>
            /// Keys
            /// A list of keys that can be used to map data to the profile or search for the profile.
            /// Required: No
            /// Type: List of KeyMap
            /// Update requires: No interruption
            /// </summary>
            public List<KeyMap> Keys { get; set; }

            /// <summary>
            /// Tags
            /// The tags used to organize, track, or control access for this resource.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

            /// <summary>
            /// TemplateId
            /// A unique identifier for the template mapping. This can be used instead of specifying the Keys and
            /// Fields properties directly.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> TemplateId { get; set; }

        }

        public string Type { get; } = "AWS::CustomerProfiles::ObjectType";

        public ObjectTypeProperties Properties { get; } = new ObjectTypeProperties();

    }

    public static class ObjectTypeAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> CreatedAt = new ResourceAttribute<Union<string, IntrinsicFunction>>("CreatedAt");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> LastUpdatedAt = new ResourceAttribute<Union<string, IntrinsicFunction>>("LastUpdatedAt");
    }
}
