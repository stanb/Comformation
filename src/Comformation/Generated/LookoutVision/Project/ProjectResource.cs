using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.LookoutVision.Project
{
    /// <summary>
    /// AWS::LookoutVision::Project
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lookoutvision-project.html
    /// </summary>
    public class ProjectResource : ResourceBase
    {
        public class ProjectProperties
        {
            /// <summary>
            /// ProjectName
            /// The name of the project.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 255
            /// Pattern: [a-zA-Z0-9][a-zA-Z0-9_\-]*
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ProjectName { get; set; }

        }

        public string Type { get; } = "AWS::LookoutVision::Project";

        public ProjectProperties Properties { get; } = new ProjectProperties();

    }

    public static class ProjectAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
    }
}
