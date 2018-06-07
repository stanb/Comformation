using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EMR.Cluster
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-cloudwatchalarmdefinition.html
    /// </summary>
    public class CloudWatchAlarmDefinition
    {

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-cloudwatchalarmdefinition.html#cfn-emr-cluster-cloudwatchalarmdefinition-comparisonoperator
        /// </summary>
        [JsonProperty("ComparisonOperator")]
        public Union<string, IntrinsicFunction> ComparisonOperator { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-cloudwatchalarmdefinition.html#cfn-emr-cluster-cloudwatchalarmdefinition-dimensions
        /// </summary>
        [JsonProperty("Dimensions")]
        public Union<List<MetricDimension>, IntrinsicFunction> Dimensions { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-cloudwatchalarmdefinition.html#cfn-emr-cluster-cloudwatchalarmdefinition-evaluationperiods
        /// </summary>
        [JsonProperty("EvaluationPeriods")]
        public Union<int, IntrinsicFunction> EvaluationPeriods { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-cloudwatchalarmdefinition.html#cfn-emr-cluster-cloudwatchalarmdefinition-metricname
        /// </summary>
        [JsonProperty("MetricName")]
        public Union<string, IntrinsicFunction> MetricName { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-cloudwatchalarmdefinition.html#cfn-emr-cluster-cloudwatchalarmdefinition-namespace
        /// </summary>
        [JsonProperty("Namespace")]
        public Union<string, IntrinsicFunction> Namespace { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-cloudwatchalarmdefinition.html#cfn-emr-cluster-cloudwatchalarmdefinition-period
        /// </summary>
        [JsonProperty("Period")]
        public Union<int, IntrinsicFunction> Period { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-cloudwatchalarmdefinition.html#cfn-emr-cluster-cloudwatchalarmdefinition-statistic
        /// </summary>
        [JsonProperty("Statistic")]
        public Union<string, IntrinsicFunction> Statistic { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-cloudwatchalarmdefinition.html#cfn-emr-cluster-cloudwatchalarmdefinition-threshold
        /// </summary>
        [JsonProperty("Threshold")]
        public Union<double, IntrinsicFunction> Threshold { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-cloudwatchalarmdefinition.html#cfn-emr-cluster-cloudwatchalarmdefinition-unit
        /// </summary>
        [JsonProperty("Unit")]
        public Union<string, IntrinsicFunction> Unit { get; set; }

    }
}
