/* 
 * Neblio REST API Suite
 *
 * APIs for Interacting with NTP1 Tokens & The Neblio Blockchain
 *
 * OpenAPI spec version: 1.3.0
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
    /// BurnTokenRequest
    /// </summary>
    [DataContract]
    public partial class BurnTokenRequest :  IEquatable<BurnTokenRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BurnTokenRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BurnTokenRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BurnTokenRequest" /> class.
        /// </summary>
        /// <param name="fee">Fee in satoshi to include in the issuance transaction min 10000 (0.0001 NEBL) (required).</param>
        /// <param name="from">Array of addresses to send the token from.</param>
        /// <param name="transfer">transfer.</param>
        /// <param name="burn">Array of objects representing tokens to be burned (required).</param>
        public BurnTokenRequest(decimal? fee = default(decimal?), List<string> from = default(List<string>), List<SendTokenRequestTo> transfer = default(List<SendTokenRequestTo>), List<BurnTokenRequestBurn> burn = default(List<BurnTokenRequestBurn>))
        {
            // to ensure "fee" is required (not null)
            if (fee == null)
            {
                throw new InvalidDataException("fee is a required property for BurnTokenRequest and cannot be null");
            }
            else
            {
                this.Fee = fee;
            }
            // to ensure "burn" is required (not null)
            if (burn == null)
            {
                throw new InvalidDataException("burn is a required property for BurnTokenRequest and cannot be null");
            }
            else
            {
                this.Burn = burn;
            }
            this.From = from;
            this.Transfer = transfer;
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
        /// Gets or Sets Transfer
        /// </summary>
        [DataMember(Name="transfer", EmitDefaultValue=false)]
        public List<SendTokenRequestTo> Transfer { get; set; }

        /// <summary>
        /// Array of objects representing tokens to be burned
        /// </summary>
        /// <value>Array of objects representing tokens to be burned</value>
        [DataMember(Name="burn", EmitDefaultValue=false)]
        public List<BurnTokenRequestBurn> Burn { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BurnTokenRequest {\n");
            sb.Append("  Fee: ").Append(Fee).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  Transfer: ").Append(Transfer).Append("\n");
            sb.Append("  Burn: ").Append(Burn).Append("\n");
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
            return this.Equals(input as BurnTokenRequest);
        }

        /// <summary>
        /// Returns true if BurnTokenRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of BurnTokenRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BurnTokenRequest input)
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
                    this.Transfer == input.Transfer ||
                    this.Transfer != null &&
                    this.Transfer.SequenceEqual(input.Transfer)
                ) && 
                (
                    this.Burn == input.Burn ||
                    this.Burn != null &&
                    this.Burn.SequenceEqual(input.Burn)
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
                if (this.Transfer != null)
                    hashCode = hashCode * 59 + this.Transfer.GetHashCode();
                if (this.Burn != null)
                    hashCode = hashCode * 59 + this.Burn.GetHashCode();
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
