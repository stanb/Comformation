using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Lambda.EventSourceMapping
{
    /// <summary>
    /// AWS::Lambda::EventSourceMapping SourceAccessConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-eventsourcemapping-sourceaccessconfiguration.html
    /// </summary>
    public class SourceAccessConfiguration
    {

        /// <summary>
        /// Type
        /// The type of authentication protocol, VPC components, or virtual host for your event source. For
        /// example: &quot;Type&quot;:&quot;SASL_SCRAM_512_AUTH&quot;.
        /// BASIC_AUTH - (Amazon MQ) The AWS Secrets Manager secret that stores your broker credentials.
        /// BASIC_AUTH - (Self-managed Apache Kafka) The Secrets Manager ARN of your secret key used for
        /// SASL/PLAIN authentication of your Apache Kafka brokers. VPC_SUBNET - The subnets associated with
        /// your VPC. Lambda connects to these subnets to fetch data from your self-managed Apache Kafka
        /// cluster. VPC_SECURITY_GROUP - The VPC security group used to manage access to your self-managed
        /// Apache Kafka brokers. SASL_SCRAM_256_AUTH - The Secrets Manager ARN of your secret key used for SASL
        /// SCRAM-256 authentication of your self-managed Apache Kafka brokers. SASL_SCRAM_512_AUTH - The
        /// Secrets Manager ARN of your secret key used for SASL SCRAM-512 authentication of your self-managed
        /// Apache Kafka brokers. VIRTUAL_HOST - (Amazon MQ) The name of the virtual host in your RabbitMQ
        /// broker. Lambda uses this RabbitMQ host as the event source.
        /// Required: No
        /// Type: String
        /// Allowed values: BASIC_AUTH | SASL_SCRAM_256_AUTH | SASL_SCRAM_512_AUTH | VIRTUAL_HOST |
        /// VPC_SECURITY_GROUP | VPC_SUBNET
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

        /// <summary>
        /// URI
        /// The value for your chosen configuration in Type. For example: &quot;URI&quot;:
        /// &quot;arn:aws:secretsmanager:us-east-1:01234567890:secret:MyBrokerSecretName&quot;.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 200
        /// Pattern: [a-zA-Z0-9-\/*:_+=. @-]*
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("URI")]
        public Union<string, IntrinsicFunction> URI { get; set; }

    }
}
