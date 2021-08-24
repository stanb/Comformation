using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.CustomerProfiles.Integration
{
    /// <summary>
    /// AWS::CustomerProfiles::Integration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-customerprofiles-integration.html
    /// </summary>
    public class IntegrationResource : ResourceBase
    {
        public class IntegrationProperties
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
            /// Uri
            /// The URI of the S3 bucket or any other type of data source.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Uri { get; set; }

            /// <summary>
            /// FlowDefinition
            /// Not currently supported by AWS CloudFormation.
            /// Required: No
            /// Type: FlowDefinition
            /// Update requires: No interruption
            /// </summary>
            public FlowDefinition FlowDefinition { get; set; }

            /// <summary>
            /// ObjectTypeName
            /// The name of the profile object type mapping to use.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> ObjectTypeName { get; set; }

            /// <summary>
            /// Tags
            /// The tags used to organize, track, or control access for this resource.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::CustomerProfiles::Integration";

        public IntegrationProperties Properties { get; } = new IntegrationProperties();

    }

    public static class IntegrationAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> CreatedAt = new ResourceAttribute<Union<string, IntrinsicFunction>>("CreatedAt");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> LastUpdatedAt = new ResourceAttribute<Union<string, IntrinsicFunction>>("LastUpdatedAt");
    }
}
