using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTAnalytics.Dataset
{
    /// <summary>
    /// AWS::IoTAnalytics::Dataset ContainerAction
    /// Information needed to run the &quot;containerAction&quot; to produce data set contents.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-containeraction.html
    /// </summary>
    public class ContainerAction
    {

        /// <summary>
        /// Variables
        /// The values of variables used within the context of the execution of the containerized application
        /// (basically, parameters passed to the application). Each variable must have a name and a value given
        /// by one of &quot;stringValue&quot;, &quot;datasetContentVersionValue&quot;, or &quot;outputFileUriValue&quot;.
        /// Required: No
        /// Type: List of Variable
        /// Maximum: 50
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Variables")]
        public List<Variable> Variables { get; set; }

        /// <summary>
        /// ExecutionRoleArn
        /// The ARN of the role which gives permission to the system to access needed resources in order to run
        /// the &quot;containerAction&quot;. This includes, at minimum, permission to retrieve the data set contents which
        /// are the input to the containerized application.
        /// Required: Yes
        /// Type: String
        /// Minimum: 20
        /// Maximum: 2048
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ExecutionRoleArn")]
        public Union<string, IntrinsicFunction> ExecutionRoleArn { get; set; }

        /// <summary>
        /// Image
        /// The ARN of the Docker container stored in your account. The Docker container contains an application
        /// and needed support libraries and is used to generate data set contents.
        /// Required: Yes
        /// Type: String
        /// Maximum: 255
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Image")]
        public Union<string, IntrinsicFunction> Image { get; set; }

        /// <summary>
        /// ResourceConfiguration
        /// Configuration of the resource which executes the &quot;containerAction&quot;.
        /// Required: Yes
        /// Type: ResourceConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ResourceConfiguration")]
        public ResourceConfiguration ResourceConfiguration { get; set; }

    }
}
