using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ServiceCatalog.TagOption
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalog-tagoption.html
    /// </summary>
    public class TagOptionResource : ResourceBase
    {
        public class TagOptionProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalog-tagoption.html#cfn-servicecatalog-tagoption-active
            /// </summary>
			public Union<bool, IntrinsicFunction> Active { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalog-tagoption.html#cfn-servicecatalog-tagoption-value
            /// </summary>
			public Union<string, IntrinsicFunction> Value { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalog-tagoption.html#cfn-servicecatalog-tagoption-key
            /// </summary>
			public Union<string, IntrinsicFunction> Key { get; set; }

        }
    
        public string Type { get; } = "AWS::ServiceCatalog::TagOption";
        
        public TagOptionProperties Properties { get; } = new TagOptionProperties();
    }
}
