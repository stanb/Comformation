using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.DevOpsGuru.ResourceCollection
{
    /// <summary>
    /// AWS::DevOpsGuru::ResourceCollection
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-devopsguru-resourcecollection.html
    /// </summary>
    public class ResourceCollectionResource : ResourceBase
    {
        public class ResourceCollectionProperties
        {
            /// <summary>
            /// ResourceCollectionFilter
            /// 		
            /// 			Information about a filter used to specify which AWS resources are analyzed for anomalous
            /// behavior by DevOps Guru. 		
            /// 	
            /// Required: Yes
            /// Type: ResourceCollectionFilter
            /// Update requires: No interruption
            /// </summary>
            public ResourceCollectionFilter ResourceCollectionFilter { get; set; }

        }

        public string Type { get; } = "AWS::DevOpsGuru::ResourceCollection";

        public ResourceCollectionProperties Properties { get; } = new ResourceCollectionProperties();

    }

    public static class ResourceCollectionAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ResourceCollectionType = new ResourceAttribute<Union<string, IntrinsicFunction>>("ResourceCollectionType");
    }
}
