using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ServiceCatalog.TagOptionAssociation
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalog-tagoptionassociation.html
    /// </summary>
    public class TagOptionAssociationResource : ResourceBase
    {
        public class TagOptionAssociationProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalog-tagoptionassociation.html#cfn-servicecatalog-tagoptionassociation-tagoptionid
            /// </summary>
			public Union<string, IntrinsicFunction> TagOptionId { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalog-tagoptionassociation.html#cfn-servicecatalog-tagoptionassociation-resourceid
            /// </summary>
			public Union<string, IntrinsicFunction> ResourceId { get; set; }

        }
    
        public string Type { get; } = "AWS::ServiceCatalog::TagOptionAssociation";
        
        public TagOptionAssociationProperties Properties { get; } = new TagOptionAssociationProperties();
    }
}
