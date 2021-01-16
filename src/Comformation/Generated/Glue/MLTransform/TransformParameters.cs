using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Glue.MLTransform
{
    /// <summary>
    /// AWS::Glue::MLTransform TransformParameters
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-mltransform-transformparameters.html
    /// </summary>
    public class TransformParameters
    {

        /// <summary>
        /// TransformType
        /// The type of machine learning transform. FIND_MATCHES is the only option.
        /// 	
        /// For information about the types of machine learning transforms, see Creating Machine Learning
        /// Transforms.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TransformType")]
        public Union<string, IntrinsicFunction> TransformType { get; set; }

        /// <summary>
        /// FindMatchesParameters
        /// The parameters for the find matches algorithm.
        /// Required: No
        /// Type: FindMatchesParameters
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FindMatchesParameters")]
        public FindMatchesParameters FindMatchesParameters { get; set; }

    }
}
