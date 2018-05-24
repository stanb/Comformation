using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.SDB.Domain
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-simpledb.html
    /// </summary>
    public class DomainResource : ResourceBase
    {
        public class DomainProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-simpledb.html#cfn-sdb-domain-description
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

        }
    
        public string Type { get; } = "AWS::SDB::Domain";
        
        public DomainProperties Properties { get; } = new DomainProperties();
    }
}
