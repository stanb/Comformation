using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.DataBrew.Recipe
{
    /// <summary>
    /// AWS::DataBrew::Recipe
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-databrew-recipe.html
    /// </summary>
    public class RecipeResource : ResourceBase
    {
        public class RecipeProperties
        {
            /// <summary>
            /// Description
            /// The description of the recipe.
            /// Required: No
            /// Type: String
            /// Maximum: 1024
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// Name
            /// The unique name for the recipe.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 255
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// Steps
            /// A list of steps that are defined by the recipe.
            /// Required: Yes
            /// Type: List of RecipeStep
            /// Update requires: No interruption
            /// </summary>
            public List<RecipeStep> Steps { get; set; }

            /// <summary>
            /// Tags
            /// Metadata tags that have been applied to the recipe.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: Replacement
            /// </summary>
            public List<Tag> Tags { get; set; }

        }

        public string Type { get; } = "AWS::DataBrew::Recipe";

        public RecipeProperties Properties { get; } = new RecipeProperties();

    }
}
