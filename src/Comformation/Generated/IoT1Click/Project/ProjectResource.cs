using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoT1Click.Project
{
    /// <summary>
    /// AWS::IoT1Click::Project
    /// The AWS::IoT1Click::Project resource creates an empty project with a placement template. A project contains
    /// zero or more placements that adhere to the placement template defined in the project. For more information,
    /// see CreateProject in the AWS IoT 1-Click Projects API Reference.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot1click-project.html
    /// </summary>
    public class ProjectResource : ResourceBase
    {
        public class ProjectProperties
        {
            /// <summary>
            /// Description
            /// An optional description for the project.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// PlacementTemplate
            /// The template defining the placement to be created. A placement template defines placement default
            /// attributes and device templates. You cannot add or remove device templates after the project has
            /// been created. However, you can update callbackOverrides for the device templates using the
            /// UpdateProject API.
            /// Required: Yes
            /// Type: PlacementTemplate
            /// Update requires: No interruption
            /// </summary>
			public PlacementTemplate PlacementTemplate { get; set; }

            /// <summary>
            /// ProjectName
            /// The name of the project to create.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ProjectName { get; set; }

        }

        public string Type { get; } = "AWS::IoT1Click::Project";

        public ProjectProperties Properties { get; } = new ProjectProperties();

    }

	public static class ProjectAttributes
	{
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ProjectName = new ResourceAttribute<Union<string, IntrinsicFunction>>("ProjectName");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
	}
}
