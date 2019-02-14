/* 
 * Neblio REST API Suite
 *
 * APIs for Interacting with NTP1 Tokens & The Neblio Blockchain
 *
 * OpenAPI spec version: 1.2.1
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Neblio.API.Client.OpenAPIDateConverter;

namespace Neblio.API.Model
{
    /// <summary>
    /// SendTokenRequest
    /// </summary>
    [DataContract]
    public partial class SendTokenRequest :  IEquatable<SendTokenRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SendTokenRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SendTokenRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SendTokenRequest" /> class.
        /// </summary>
        /// <param name="fee">Fee in satoshi to include in the issuance transaction min 10000 (0.0001 NEBL) (required).</param>
        /// <param name="from">Array of addresses to send the token from.</param>
        /// <param name="sendutxo">Array of UTXOs to send the token from.</param>
        /// <param name="to">to (required).</param>
        /// <param name="flags">flags.</param>
        /// <param name="metadata">metadata.</param>
        public SendTokenRequest(decimal? fee = default(decimal?), List<string> from = default(List<string>), List<string> sendutxo = default(List<string>), List<SendTokenRequestTo> to = default(List<SendTokenRequestTo>), IssueTokenRequestFlags flags = default(IssueTokenRequestFlags), IssueTokenRequestMetadata metadata = default(IssueTokenRequestMetadata))
        {
            // to ensure "fee" is required (not null)
            if (fee == null)
            {
                throw new InvalidDataException("fee is a required property for SendTokenRequest and cannot be null");
            }
            else
            {
                this.Fee = fee;
            }
            // to ensure "to" is required (not null)
            if (to == null)
            {
                throw new InvalidDataException("to is a required property for SendTokenRequest and cannot be null");
            }
            else
            {
                this.To = to;
            }
            this.From = from;
            this.Sendutxo = sendutxo;
            this.Flags = flags;
            this.Metadata = metadata;
        }
        
        /// <summary>
        /// Fee in satoshi to include in the issuance transaction min 10000 (0.0001 NEBL)
        /// </summary>
        /// <value>Fee in satoshi to include in the issuance transaction min 10000 (0.0001 NEBL)</value>
        [DataMember(Name="fee", EmitDefaultValue=false)]
        public decimal? Fee { get; set; }

        /// <summary>
        /// Array of addresses to send the token from
        /// </summary>
        /// <value>Array of addresses to send the token from</value>
        [DataMember(Name="from", EmitDefaultValue=false)]
        public List<string> From { get; set; }

        /// <summary>
        /// Array of UTXOs to send the token from
        /// </summary>
        /// <value>Array of UTXOs to send the token from</value>
        [DataMember(Name="sendutxo", EmitDefaultValue=false)]
        public List<string> Sendutxo { get; set; }

        /// <summary>
        /// Gets or Sets To
        /// </summary>
        [DataMember(Name="to", EmitDefaultValue=false)]
        public List<SendTokenRequestTo> To { get; set; }

        /// <summary>
        /// Gets or Sets Flags
        /// </summary>
        [DataMember(Name="flags", EmitDefaultValue=false)]
        public IssueTokenRequestFlags Flags { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public IssueTokenRequestMetadata Metadata { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SendTokenRequest {\n");
            sb.Append("  Fee: ").Append(Fee).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  Sendutxo: ").Append(Sendutxo).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  Flags: ").Append(Flags).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as SendTokenRequest);
        }

        /// <summary>
        /// Returns true if SendTokenRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SendTokenRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SendTokenRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Fee == input.Fee ||
                    (this.Fee != null &&
                    this.Fee.Equals(input.Fee))
                ) && 
                (
                    this.From == input.From ||
                    this.From != null &&
                    this.From.SequenceEqual(input.From)
                ) && 
                (
                    this.Sendutxo == input.Sendutxo ||
                    this.Sendutxo != null &&
                    this.Sendutxo.SequenceEqual(input.Sendutxo)
                ) && 
                (
                    this.To == input.To ||
                    this.To != null &&
                    this.To.SequenceEqual(input.To)
                ) && 
                (
                    this.Flags == input.Flags ||
                    (this.Flags != null &&
                    this.Flags.Equals(input.Flags))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    (this.Metadata != null &&
                    this.Metadata.Equals(input.Metadata))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Fee != null)
                    hashCode = hashCode * 59 + this.Fee.GetHashCode();
                if (this.From != null)
                    hashCode = hashCode * 59 + this.From.GetHashCode();
                if (this.Sendutxo != null)
                    hashCode = hashCode * 59 + this.Sendutxo.GetHashCode();
                if (this.To != null)
                    hashCode = hashCode * 59 + this.To.GetHashCode();
                if (this.Flags != null)
                    hashCode = hashCode * 59 + this.Flags.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
