using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.QuickSight.Template
{
    /// <summary>
    /// AWS::QuickSight::Template
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-template.html
    /// </summary>
    public class TemplateResource : ResourceBase
    {
        public class TemplateProperties
        {
            /// <summary>
            /// AwsAccountId
            /// 		
            /// The ID for the AWS account; that the group is in. Currently, you use the ID for the 			AWS account;
            /// that contains your Amazon QuickSight account.
            /// 	
            /// Required: Yes
            /// Type: String
            /// Minimum: 12
            /// Maximum: 12
            /// Pattern: ^[0-9]{12}$
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> AwsAccountId { get; set; }

            /// <summary>
            /// Name
            /// 		
            /// A display name for the template.
            /// 	
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 2048
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// Permissions
            /// 		
            /// A list of resource permissions to be set on the template.
            /// 	
            /// Required: No
            /// Type: List of ResourcePermission
            /// Maximum: 64
            /// Update requires: No interruption
            /// </summary>
            public List<ResourcePermission> Permissions { get; set; }

            /// <summary>
            /// SourceEntity
            /// 		
            /// The entity that you are using as a source when you create the template. In 			SourceEntity, you
            /// specify the type of object you&#39;re using as source: 			SourceTemplate for a template or
            /// SourceAnalysis for an 			analysis. Both of these require an Amazon Resource Name (ARN). For
            /// 			SourceTemplate, specify the ARN of the source template. For 			SourceAnalysis, specify the ARN of
            /// the source analysis. The SourceTemplate 			ARN can contain any AWS account; and any
            /// QuickSight-supported AWS Region;.
            /// 		
            /// Use the DataSetReferences entity within SourceTemplate or 			SourceAnalysis to list the replacement
            /// datasets for the placeholders listed 			in the original. The schema in each dataset must match its
            /// placeholder.
            /// 		 	
            /// Required: No
            /// Type: TemplateSourceEntity
            /// Update requires: No interruption
            /// </summary>
            public TemplateSourceEntity SourceEntity { get; set; }

            /// <summary>
            /// Tags
            /// 		
            /// Contains a map of the key-value pairs for the resource tag or tags assigned to the resource.
            /// 	
            /// Required: No
            /// Type: List of Tag
            /// Maximum: 200
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

            /// <summary>
            /// TemplateId
            /// 		
            /// An ID for the template that you want to create. This template is unique per AWS Region; in 			each
            /// AWS account;.
            /// 	
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 2048
            /// Pattern: [\w\-]+
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> TemplateId { get; set; }

            /// <summary>
            /// VersionDescription
            /// 		
            /// A description of the current template version being created. This API operation creates the 			first
            /// version of the template. Every time UpdateTemplate is called, a new 			version is created. Each
            /// version of the template maintains a description of the version 			in the VersionDescription field.
            /// 	
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 512
            /// Update requires: No interruption
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
    }
}
