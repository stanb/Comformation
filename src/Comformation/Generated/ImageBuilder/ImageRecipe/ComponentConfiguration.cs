using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ImageBuilder.ImageRecipe
{
    /// <summary>
    /// AWS::ImageBuilder::ImageRecipe ComponentConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-imagerecipe-componentconfiguration.html
    /// </summary>
    public class ComponentConfiguration
    {

        /// <summary>
        /// ComponentArn
        /// The Amazon Resource Name (ARN) of the component.
        /// Required: No
        /// Type: String
        /// Pattern: ^arn:aws[^:]*:imagebuilder:[^:]+:(?:\d{12}|aws):component/[a-z0-9-_]+/(?:(?:(\d+|x)\.
        /// (\d+|x)\. (\d+|x))|(?:\d+\. \d+\. \d+/\d+))$
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("ComponentArn")]
        public Union<string, IntrinsicFunction> ComponentArn { get; set; }

    }
}
