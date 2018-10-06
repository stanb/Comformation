using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.SDB.Domain
{
    /// <summary>
    /// AWS::SDB::Domain
    /// Use the AWS::SDB::Domain resource to declare an Amazon SimpleDB domain. When you specify AWS::SDB::Domain as
    /// an argument in a Ref function, AWS CloudFormation returns the value of the DomainName.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-simpledb.html
    /// </summary>
    public class DomainResource : ResourceBase
    {
        public class DomainProperties
        {
            /// <summary>
            /// Description
            /// Information about the Amazon SimpleDB domain.
            /// Required: No
            /// Type: String
            /// Update requires: Updates are not supported.
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

        }
    
        public string Type { get; } = "AWS::SDB::Domain";
        
        public DomainProperties Properties { get; } = new DomainProperties();

    }
}
