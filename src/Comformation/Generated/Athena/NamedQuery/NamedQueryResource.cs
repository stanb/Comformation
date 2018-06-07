using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Athena.NamedQuery
{
    /// <summary>
    /// AWS::Athena::NamedQuery
    /// The AWS::Athena::NamedQuery resource creates an Amazon Athena query. For more information, see
    /// CreateNamedQuery in the Amazon Athena Documentation.
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-athena-namedquery.html
    /// </summary>
    public class NamedQueryResource : ResourceBase
    {
        public class NamedQueryProperties
        {
            /// <summary>
            /// Description
            /// A brief description of the query.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-athena-namedquery.html#cfn-athena-namedquery-description
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// QueryString
            /// The SQL query statements that comprise the query.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-athena-namedquery.html#cfn-athena-namedquery-querystring
            /// </summary>
			public Union<string, IntrinsicFunction> QueryString { get; set; }

            /// <summary>
            /// Database
            /// The database to which the query belongs.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-athena-namedquery.html#cfn-athena-namedquery-database
            /// </summary>
			public Union<string, IntrinsicFunction> Database { get; set; }

            /// <summary>
            /// Name
            /// The plain-language name of the query.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-athena-namedquery.html#cfn-athena-namedquery-name
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

        }
    
        public string Type { get; } = "AWS::Athena::NamedQuery";
        
        public NamedQueryProperties Properties { get; } = new NamedQueryProperties();
    }
}
