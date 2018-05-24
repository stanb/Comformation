using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Glue.Connection
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-connection.html
    /// </summary>
    public class ConnectionResource : ResourceBase
    {
        public class ConnectionProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-connection.html#cfn-glue-connection-connectioninput
            /// </summary>
			public Union<ConnectionInput, IntrinsicFunction> ConnectionInput { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-connection.html#cfn-glue-connection-catalogid
            /// </summary>
			public Union<string, IntrinsicFunction> CatalogId { get; set; }

        }
    
        public string Type { get; } = "AWS::Glue::Connection";
        
        public ConnectionProperties Properties { get; } = new ConnectionProperties();
    }
}
