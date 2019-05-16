using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoT1Click.Project
{
    /// <summary>
    /// AWS::IoT1Click::Project PlacementTemplate
    /// In AWS CloudFormation, use the PlacementTemplate property type to define the template for an AWS IoT 1-Click
    /// project.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot1click-project-placementtemplate.html
    /// </summary>
    public class PlacementTemplate
    {

        /// <summary>
        /// DeviceTemplates
        /// An object specifying the DeviceTemplate for all placements using this (PlacementTemplate) template.
        /// Required: No
        /// Type: Json
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("DeviceTemplates")]
        public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> DeviceTemplates { get; set; }

        /// <summary>
        /// DefaultAttributes
        /// The default attributes (key-value pairs) to be applied to all placements using this template.
        /// Required: No
        /// Type: Json
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DefaultAttributes")]
        public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> DefaultAttributes { get; set; }

    }
}
