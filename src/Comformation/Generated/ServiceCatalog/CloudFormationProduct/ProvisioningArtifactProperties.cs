using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ServiceCatalog.CloudFormationProduct
{
    /// <summary>
    /// AWS::ServiceCatalog::CloudFormationProduct ProvisioningArtifactProperties
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-servicecatalog-cloudformationproduct-provisioningartifactproperties.html
    /// </summary>
    public class ProvisioningArtifactProperties
    {

        /// <summary>
        /// Description
        /// The description of the provisioning artifact, including how it differs from the previous
        /// provisioning artifact.
        /// Required: No
        /// Type: String
        /// Maximum: 8192
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Description")]
        public Union<string, IntrinsicFunction> Description { get; set; }

        /// <summary>
        /// DisableTemplateValidation
        /// If set to true, AWS Service Catalog stops validating the specified provisioning artifact even if it
        /// is invalid.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DisableTemplateValidation")]
        public Union<bool, IntrinsicFunction> DisableTemplateValidation { get; set; }

        /// <summary>
        /// Info
        /// Specify the template source with one of the following options, but not both. Keys accepted: [
        /// LoadTemplateFromURL, ImportFromPhysicalId ]
        /// The URL of the CloudFormation template in Amazon S3. Specify the URL in JSON format as follows:
        /// &quot;LoadTemplateFromURL&quot;: &quot;https://s3. amazonaws. com/cf-templates-ozkq9d3hgiq2-us-east-1/. . . &quot;
        /// ImportFromPhysicalId: The physical id of the resource that contains the template. Currently only
        /// supports CloudFormation stack arn. Specify the physical id in JSON format as follows:
        /// ImportFromPhysicalId: “arn:aws:cloudformation:[us-east-1]:[accountId]:stack/[StackName]/[resourceId]
        /// Required: Yes
        /// Type: Json
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Info")]
        public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Info { get; set; }

        /// <summary>
        /// Name
        /// The name of the provisioning artifact (for example, v1 v2beta). No spaces are allowed.
        /// Required: No
        /// Type: String
        /// Maximum: 8192
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

    }
}
