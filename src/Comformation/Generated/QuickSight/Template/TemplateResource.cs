using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.QuickSight.Template
{
    /// <summary>
    /// Missing documentation http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-template.html
    /// </summary>
    public class TemplateResource : ResourceBase
    {
        public class TemplateProperties
        {
            /// <summary>
            /// AwsAccountId
            /// </summary>
            public Union<string, IntrinsicFunction> AwsAccountId { get; set; }

            /// <summary>
            /// Name
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// Permissions
            /// </summary>
            public List<ResourcePermission> Permissions { get; set; }

            /// <summary>
            /// SourceEntity
            /// </summary>
            public TemplateSourceEntity SourceEntity { get; set; }

            /// <summary>
            /// Tags
            /// </summary>
            public List<Tag> Tags { get; set; }

            /// <summary>
            /// TemplateId
            /// </summary>
            public Union<string, IntrinsicFunction> TemplateId { get; set; }

            /// <summary>
            /// VersionDescription
            /// </summary>
            public Union<string, IntrinsicFunction> VersionDescription { get; set; }

        }

        public string Type { get; } = "AWS::QuickSight::Template";

        public TemplateProperties Properties { get; } = new TemplateProperties();

    }

    public static class TemplateAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> CreatedTime = new ResourceAttribute<Union<string, IntrinsicFunction>>("CreatedTime");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> LastUpdatedTime = new ResourceAttribute<Union<string, IntrinsicFunction>>("LastUpdatedTime");
        public static readonly ResourceAttribute<TemplateVersion> Version = new ResourceAttribute<TemplateVersion>("Version");
    }
}
