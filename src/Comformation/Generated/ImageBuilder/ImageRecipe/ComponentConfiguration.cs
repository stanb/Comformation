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
        /// 		
        /// The Amazon Resource Name (ARN) of the component.
        /// 	
        /// Required: No
        /// Type: String
        /// Pattern: ^arn:aws[^:]*:imagebuilder:[^:]+:(?:[0-9]{12}|aws):component/[a-z0-9-_]+/(?:(?:([0-9]+|x)\.
        /// ([0-9]+|x)\. ([0-9]+|x))|(?:[0-9]+\. [0-9]+\. [0-9]+/[0-9]+))$
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("ComponentArn")]
        public Union<string, IntrinsicFunction> ComponentArn { get; set; }

        /// <summary>
        /// Parameters
        /// 		
        /// A group of parameter settings that are used to configure the component for a specific recipe.
        /// 	
        /// Required: No
        /// Type: List of ComponentParameter
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Parameters")]
        public List<ComponentParameter> Parameters { get; set; }

    }
}
