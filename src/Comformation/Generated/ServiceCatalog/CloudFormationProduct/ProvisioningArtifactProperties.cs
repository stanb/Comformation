using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ServiceCatalog.CloudFormationProduct
{
    /// <summary>
    /// AWS Service Catalog CloudFormationProduct ProvisioningArtifactProperties
    /// The ProvisioningArtifactProperties property type specifies information about a provisioning artifact (also
    /// known as a version) for a product.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-servicecatalog-cloudformationproduct-provisioningartifactproperties.html
    /// </summary>
    public class ProvisioningArtifactProperties
    {

        /// <summary>
        /// Description
        /// The description of the provisioning artifact.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Description")]
        public Union<string, IntrinsicFunction> Description { get; set; }

        /// <summary>
        /// Info
        /// The URL of the CloudFormation template in Amazon S3. Specify the URL in JSON format as follows:
        /// &quot;LoadTemplateFromURL&quot;: &quot;https://s3. amazonaws. com/cf-templates-ozkq9d3hgiq2-us-east-1/. . . &quot;
        /// Required: Yes
        /// Type: Json
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Info")]
        public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Info { get; set; }

        /// <summary>
        /// Name
        /// The name of the provisioning artifact.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

    }
}
