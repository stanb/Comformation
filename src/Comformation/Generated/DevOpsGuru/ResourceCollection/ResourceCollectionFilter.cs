using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DevOpsGuru.ResourceCollection
{
    /// <summary>
    /// AWS::DevOpsGuru::ResourceCollection ResourceCollectionFilter
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsguru-resourcecollection-resourcecollectionfilter.html
    /// </summary>
    public class ResourceCollectionFilter
    {

        /// <summary>
        /// CloudFormation
        /// 		
        /// 			Information about AWS CloudFormation stacks. You can use up to 500 stacks to specify which AWS
        /// resources in your account to analyze. 			For more information, see Stacks 			in the AWS
        /// CloudFormation User Guide. 		
        /// 	
        /// Required: No
        /// Type: CloudFormationCollectionFilter
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CloudFormation")]
        public CloudFormationCollectionFilter CloudFormation { get; set; }

    }
}
