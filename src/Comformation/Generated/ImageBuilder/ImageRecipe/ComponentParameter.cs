using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ImageBuilder.ImageRecipe
{
    /// <summary>
    /// AWS::ImageBuilder::ImageRecipe ComponentParameter
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-imagerecipe-componentparameter.html
    /// </summary>
    public class ComponentParameter
    {

        /// <summary>
        /// Name
        /// 		
        /// The name of the component parameter to set.
        /// 	
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 256
        /// Pattern: [^\x00]+
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

        /// <summary>
        /// Value
        /// 		
        /// Sets the value for the named component parameter.
        /// 	
        /// Required: Yes
        /// Type: List of String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Value")]
        public List<Union<string, IntrinsicFunction>> Value { get; set; }

    }
}
