using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EMR.Cluster
{
    /// <summary>
    /// Amazon EMR Cluster Application
    /// Application is a property of the AWS::EMR::Cluster resource that adds an Amazon EMR (Amazon EMR) application
    /// bundle or third-party software to an Amazon EMR cluster.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-cluster-application.html
    /// </summary>
    public class Application
    {

        /// <summary>
        /// AdditionalInfo
        /// Metadata about third-party applications that third-party vendors use for testing purposes.
        /// Required: No
        /// Type: String-to-string map
        /// </summary>
        [JsonProperty("AdditionalInfo")]
        public Dictionary<string, Union<string, IntrinsicFunction>> AdditionalInfo { get; set; }

        /// <summary>
        /// Args
        /// Arguments that Amazon EMR passes to the application.
        /// Required: No
        /// Type: List of String values
        /// </summary>
        [JsonProperty("Args")]
        public List<Union<string, IntrinsicFunction>> Args { get; set; }

        /// <summary>
        /// Name
        /// The name of the application to add to your cluster, such as Hadoop or Hive. For valid values, see
        /// the Applications parameter in the Amazon EMR API Reference.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

        /// <summary>
        /// Version
        /// The version of the application.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("Version")]
        public Union<string, IntrinsicFunction> Version { get; set; }

    }
}
