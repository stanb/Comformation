using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.SDB.Domain
{
    /// <summary>
    /// AWS::SDB::Domain
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-simpledb.html
    /// </summary>
    public class DomainResource : ResourceBase
    {
        public class DomainProperties
        {
            /// <summary>
            /// Description
            /// Information about the SimpleDB domain.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

        }

        public string Type { get; } = "AWS::SDB::Domain";

        public DomainProperties Properties { get; } = new DomainProperties();

    }
}
