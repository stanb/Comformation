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
            /// The description of the project.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// PlacementTemplate
            /// An object describing the project&#39;s placement specifications.
            /// Required: Yes
            /// Type: PlacementTemplate
            /// Update requires: No interruption
            /// </summary>
			public PlacementTemplate PlacementTemplate { get; set; }

            /// <summary>
            /// ProjectName
            /// The name of the project from which to obtain information.
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
