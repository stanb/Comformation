using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodePipeline.CustomActionType
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codepipeline-customactiontype.html
    /// </summary>
    public class CustomActionTypeResource : ResourceBase
    {
        public class CustomActionTypeProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codepipeline-customactiontype.html#cfn-codepipeline-customactiontype-category
            /// </summary>
			public Union<string, IntrinsicFunction> Category { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codepipeline-customactiontype.html#cfn-codepipeline-customactiontype-configurationproperties
            /// </summary>
			public Union<List<ConfigurationProperties>, IntrinsicFunction> ConfigurationProperties { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codepipeline-customactiontype.html#cfn-codepipeline-customactiontype-inputartifactdetails
            /// </summary>
			public Union<ArtifactDetails, IntrinsicFunction> InputArtifactDetails { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codepipeline-customactiontype.html#cfn-codepipeline-customactiontype-outputartifactdetails
            /// </summary>
			public Union<ArtifactDetails, IntrinsicFunction> OutputArtifactDetails { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codepipeline-customactiontype.html#cfn-codepipeline-customactiontype-provider
            /// </summary>
			public Union<string, IntrinsicFunction> Provider { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codepipeline-customactiontype.html#cfn-codepipeline-customactiontype-settings
            /// </summary>
			public Union<Settings, IntrinsicFunction> Settings { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codepipeline-customactiontype.html#cfn-codepipeline-customactiontype-version
            /// </summary>
			public Union<string, IntrinsicFunction> Version { get; set; }

        }
    
        public string Type { get; } = "AWS::CodePipeline::CustomActionType";
        
        public CustomActionTypeProperties Properties { get; } = new CustomActionTypeProperties();
    }
}
