using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.DataBrew.Project
{
    /// <summary>
    /// AWS::DataBrew::Project
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-databrew-project.html
    /// </summary>
    public class ProjectResource : ResourceBase
    {
        public class ProjectProperties
        {
            /// <summary>
            /// DatasetName
            /// The dataset that the project is to act upon.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 255
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> DatasetName { get; set; }

            /// <summary>
            /// Name
            /// The unique name of a project.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 255
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// RecipeName
            /// The name of a recipe that will be developed during a project session.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 255
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> RecipeName { get; set; }

            /// <summary>
            /// RoleArn
            /// The Amazon Resource Name (ARN) of the role that will be assumed for this project.
            /// Required: Yes
            /// Type: String
            /// Minimum: 20
            /// Maximum: 2048
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> RoleArn { get; set; }

            /// <summary>
            /// Sample
            /// The sample size and sampling type to apply to the data. If this parameter isn&#39;t specified, then the
            /// sample consists of the first 500 rows from the dataset.
            /// Required: No
            /// Type: Sample
            /// Update requires: No interruption
            /// </summary>
            public Sample Sample { get; set; }

            /// <summary>
            /// Tags
            /// Metadata tags that have been applied to the project.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: Replacement
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::DataBrew::Project";

        public ProjectProperties Properties { get; } = new ProjectProperties();

    }
}
