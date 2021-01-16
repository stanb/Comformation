using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DevOpsGuru.ResourceCollection
{
    /// <summary>
    /// AWS::DevOpsGuru::ResourceCollection CloudFormationCollectionFilter
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsguru-resourcecollection-cloudformationcollectionfilter.html
    /// </summary>
    public class CloudFormationCollectionFilter
    {

        /// <summary>
        /// StackNames
        /// 		
        /// 			An array of CloudFormation stack names. 		
        /// 	
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("StackNames")]
        public List<Union<string, IntrinsicFunction>> StackNames { get; set; }

    }
}
