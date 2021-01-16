using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SageMaker.Endpoint
{
    /// <summary>
    /// AWS::SageMaker::Endpoint VariantProperty
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpoint-variantproperty.html
    /// </summary>
    public class VariantProperty
    {

        /// <summary>
        /// VariantPropertyType
        /// The type of variant property. The supported values are:
        /// DesiredInstanceCount: Overrides the existing variant instance counts using the InitialInstanceCount
        /// values in the ProductionVariants. DesiredWeight: Overrides the existing variant weights using the
        /// InitialVariantWeight values in the ProductionVariants. DataCaptureConfig: (Not currently supported.
        /// )
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("VariantPropertyType")]
        public Union<string, IntrinsicFunction> VariantPropertyType { get; set; }

    }
}
