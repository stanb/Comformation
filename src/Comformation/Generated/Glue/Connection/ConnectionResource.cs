using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Glue.Connection
{
    /// <summary>
    /// AWS::Glue::Connection
    /// The AWS::Glue::Connection resource specifies an AWS Glue connection to a data source. For more information,
    /// see Adding a Connection to Your Data Store and Connection Structure in the AWS Glue Developer Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-connection.html
    /// </summary>
    public class ConnectionResource : ResourceBase
    {
        public class ConnectionProperties
        {
            /// <summary>
            /// ConnectionInput
            /// The connection that you want to create.
            /// Required: Yes
            /// Type: ConnectionInput
            /// Update requires: No interruption
            /// </summary>
			public ConnectionInput ConnectionInput { get; set; }

            /// <summary>
            /// CatalogId
            /// The ID of the data catalog to create the catalog object in. Currently, this should be the AWS
            /// account ID.
            /// Note To specify the account ID, you can use the Ref intrinsic function with the AWS::AccountId
            /// pseudo parameter. For example: !Ref AWS::AccountId.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> CatalogId { get; set; }

        }

        public string Type { get; } = "AWS::Glue::Connection";

        public ConnectionProperties Properties { get; } = new ConnectionProperties();

    }
}
