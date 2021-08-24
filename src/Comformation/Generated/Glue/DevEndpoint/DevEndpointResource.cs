using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Glue.DevEndpoint
{
    /// <summary>
    /// AWS::Glue::DevEndpoint
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-devendpoint.html
    /// </summary>
    public class DevEndpointResource : ResourceBase
    {
        public class DevEndpointProperties
        {
            /// <summary>
            /// ExtraJarsS3Path
            /// The path to one or more Java . jar files in an S3 bucket that should be loaded in your DevEndpoint.
            /// Note You can only use pure Java/Scala libraries with a DevEndpoint.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> ExtraJarsS3Path { get; set; }

            /// <summary>
            /// PublicKey
            /// The public key to be used by this DevEndpoint for authentication. This attribute is provided for
            /// backward compatibility because the recommended attribute to use is public keys.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> PublicKey { get; set; }

            /// <summary>
            /// NumberOfNodes
            /// The number of AWS Glue Data Processing Units (DPUs) allocated to this DevEndpoint.
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> NumberOfNodes { get; set; }

            /// <summary>
            /// Arguments
            /// 		
            /// A map of arguments used to configure the DevEndpoint.
            /// 		
            /// Valid arguments are:
            /// 		
            /// 			 			 			 		 &quot;--enable-glue-datacatalog&quot;: &quot;&quot; &quot;GLUE_PYTHON_VERSION&quot;: &quot;3&quot; &quot;GLUE_PYTHON_VERSION&quot;: &quot;2&quot;
            /// 	 		
            /// You can specify a version of Python support for development endpoints by using the Arguments
            /// parameter in the CreateDevEndpoint or UpdateDevEndpoint APIs. If no arguments are provided, the
            /// version defaults to Python 2.
            /// 		
            /// Required: No
            /// Type: Json
            /// Update requires: No interruption
            /// </summary>
            public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Arguments { get; set; }

            /// <summary>
            /// SubnetId
            /// The subnet ID for this DevEndpoint.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> SubnetId { get; set; }

            /// <summary>
            /// PublicKeys
            /// A list of public keys to be used by the DevEndpoints for authentication. Using this attribute is
            /// preferred over a single public key because the public keys allow you to have a different private key
            /// per client.
            /// Note If you previously created an endpoint with a public key, you must remove that key to be able to
            /// set a list of public keys. Call the UpdateDevEndpoint API operation with the public key content in
            /// the deletePublicKeys attribute, and the list of new keys in the addPublicKeys attribute.
            /// Required: No
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> PublicKeys { get; set; }

            /// <summary>
            /// SecurityGroupIds
            /// A list of security group identifiers used in this DevEndpoint.
            /// Required: No
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> SecurityGroupIds { get; set; }

            /// <summary>
            /// RoleArn
            /// The Amazon Resource Name (ARN) of the IAM role used in this DevEndpoint.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> RoleArn { get; set; }

            /// <summary>
            /// WorkerType
            /// 	
            /// The type of predefined worker that is allocated to the development endpoint. Accepts a value of
            /// Standard, G. 1X, or G. 2X.
            /// 		
            /// 			 			 			 		 For the Standard worker type, each worker provides 4 vCPU, 16 GB of memory and a 50GB
            /// disk, and 2 executors per worker. For the G. 1X worker type, each worker maps to 1 DPU (4 vCPU, 16
            /// GB of memory, 64 GB disk), and provides 1 executor per worker. We recommend this worker type for
            /// memory-intensive jobs. For the G. 2X worker type, each worker maps to 2 DPU (8 vCPU, 32 GB of
            /// memory, 128 GB disk), and provides 1 executor per worker. We recommend this worker type for
            /// memory-intensive jobs.
            /// 	 		
            /// Known issue: when a development endpoint is created with the G. 2X WorkerType configuration, the
            /// Spark drivers for the development endpoint will run on 4 vCPU, 16 GB of memory, and a 64 GB disk.
            /// 	
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> WorkerType { get; set; }

            /// <summary>
            /// EndpointName
            /// The name of the DevEndpoint.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> EndpointName { get; set; }

            /// <summary>
            /// GlueVersion
            /// 	
            /// The AWS Glue version determines the versions of Apache Spark and Python that AWS Glue supports. The
            /// Python version indicates the version supported for running your ETL scripts on development
            /// endpoints.
            /// 		
            /// For more information about the available AWS Glue versions and corresponding Spark and Python
            /// versions, see Glue version in the developer guide.
            /// 	 		
            /// Development endpoints that are created without specifying a Glue version default to Glue 0. 9.
            /// 	 		
            /// You can specify a version of Python support for development endpoints by using the Arguments
            /// parameter in the CreateDevEndpoint or UpdateDevEndpoint APIs. If no arguments are provided, the
            /// version defaults to Python 2.
            /// 	
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> GlueVersion { get; set; }

            /// <summary>
            /// ExtraPythonLibsS3Path
            /// The paths to one or more Python libraries in an Amazon S3 bucket that should be loaded in your
            /// DevEndpoint. Multiple values must be complete paths separated by a comma.
            /// Note You can only use pure Python libraries with a DevEndpoint. Libraries that rely on C extensions,
            /// such as the pandas Python data analysis library, are not currently supported.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> ExtraPythonLibsS3Path { get; set; }

            /// <summary>
            /// SecurityConfiguration
            /// The name of the SecurityConfiguration structure to be used with this DevEndpoint.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> SecurityConfiguration { get; set; }

            /// <summary>
            /// NumberOfWorkers
            /// 	
            /// The number of workers of a defined workerType that are allocated to the development endpoint.
            /// 	 		
            /// The maximum number of workers you can define are 299 for G. 1X, and 149 for G. 2X.
            /// 	
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> NumberOfWorkers { get; set; }

            /// <summary>
            /// Tags
            /// The tags to use with this DevEndpoint.
            /// Required: No
            /// Type: Json
            /// Update requires: No interruption
            /// </summary>
            public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Tags { get; set; }

        }

        public string Type { get; } = "AWS::Glue::DevEndpoint";

        public DevEndpointProperties Properties { get; } = new DevEndpointProperties();

    }
}
