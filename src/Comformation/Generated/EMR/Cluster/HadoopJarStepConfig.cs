using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EMR.Cluster
{
    /// <summary>
    /// AWS::EMR::Cluster HadoopJarStepConfig
    /// The HadoopJarStepConfig property type specifies a job flow step consisting of a JAR file whose main function
    /// will be executed. The main function submits a job for the cluster to execute as a step on the master node, and
    /// then waits for the job to finish or fail before executing subsequent steps.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-hadoopjarstepconfig.html
    /// </summary>
    public class HadoopJarStepConfig
    {

        /// <summary>
        /// Args
        /// A list of command line arguments passed to the JAR file&#39;s main function when executed.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Args")]
        public List<Union<string, IntrinsicFunction>> Args { get; set; }

        /// <summary>
        /// Jar
        /// A path to a JAR file run during the step.
        /// Required: Yes
        /// Type: String
        /// Minimum: 0
        /// Maximum: 10280
        /// Pattern: [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Jar")]
        public Union<string, IntrinsicFunction> Jar { get; set; }

        /// <summary>
        /// MainClass
        /// The name of the main class in the specified Java file. If not specified, the JAR file should specify
        /// a Main-Class in its manifest file.
        /// Required: No
        /// Type: String
        /// Minimum: 0
        /// Maximum: 10280
        /// Pattern: [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MainClass")]
        public Union<string, IntrinsicFunction> MainClass { get; set; }

        /// <summary>
        /// StepProperties
        /// A list of Java properties that are set when the step runs. You can use these properties to pass key
        /// value pairs to your main function.
        /// Required: No
        /// Type: List of KeyValue
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("StepProperties")]
        public List<KeyValue> StepProperties { get; set; }

    }
}
