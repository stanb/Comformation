using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.RDS.DBProxyEndpoint
{
    /// <summary>
    /// AWS::RDS::DBProxyEndpoint
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-dbproxyendpoint.html
    /// </summary>
    public class DBProxyEndpointResource : ResourceBase
    {
        public class DBProxyEndpointProperties
        {
            /// <summary>
            /// DBProxyEndpointName
            /// The name of the DB proxy endpoint to create.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> DBProxyEndpointName { get; set; }

            /// <summary>
            /// DBProxyName
            /// The name of the DB proxy associated with the DB proxy endpoint that you create.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> DBProxyName { get; set; }

            /// <summary>
            /// VpcSecurityGroupIds
            /// The VPC security group IDs for the DB proxy endpoint that you create. You can specify a different
            /// set of security group IDs than for the original DB proxy. The default is the default security group
            /// for the VPC.
            /// Required: No
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> VpcSecurityGroupIds { get; set; }

            /// <summary>
            /// VpcSubnetIds
            /// The VPC subnet IDs for the DB proxy endpoint that you create. You can specify a different set of
            /// subnet IDs than for the original DB proxy.
            /// Required: Yes
            /// Type: List of String
            /// Update requires: Replacement
            /// </summary>
            public List<Union<string, IntrinsicFunction>> VpcSubnetIds { get; set; }

            /// <summary>
            /// TargetRole
            /// A value that indicates whether the DB proxy endpoint can be used for read/write or read-only
            /// operations.
            /// Valid Values: READ_WRITE | READ_ONLY
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> TargetRole { get; set; }

            /// <summary>
            /// Tags
            /// An optional set of key-value pairs to associate arbitrary data of your choosing with the proxy.
            /// Required: No
            /// Type: List of TagFormat
            /// Update requires: No interruption
            /// </summary>
            public List<TagFormat> Tags { get; set; }

        }

        public string Type { get; } = "AWS::RDS::DBProxyEndpoint";

        public DBProxyEndpointProperties Properties { get; } = new DBProxyEndpointProperties();

    }

    public static class DBProxyEndpointAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> DBProxyEndpointArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("DBProxyEndpointArn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> VpcId = new ResourceAttribute<Union<string, IntrinsicFunction>>("VpcId");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Endpoint = new ResourceAttribute<Union<string, IntrinsicFunction>>("Endpoint");
        public static readonly ResourceAttribute<Union<bool, IntrinsicFunction>> IsDefault = new ResourceAttribute<Union<bool, IntrinsicFunction>>("IsDefault");
    }
}
