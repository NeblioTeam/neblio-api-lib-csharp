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
    /// GetTokenHoldersResponse
    /// </summary>
    [DataContract]
    public partial class GetTokenHoldersResponse :  IEquatable<GetTokenHoldersResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetTokenHoldersResponse" /> class.
        /// </summary>
        /// <param name="tokenId">TokenId of the token.</param>
        /// <param name="holders">holders.</param>
        /// <param name="divibility">How many decimal points the token is divisble to.</param>
        /// <param name="lockStatus">Whether new issuances of this token are locked.</param>
        /// <param name="aggregationPolicy">Whether the tokesn are aggregatable.</param>
        /// <param name="someUtxo">A UTXO of this token.</param>
        public GetTokenHoldersResponse(string tokenId = default(string), List<GetTokenHoldersResponseHolders> holders = default(List<GetTokenHoldersResponseHolders>), decimal? divibility = default(decimal?), bool? lockStatus = default(bool?), string aggregationPolicy = default(string), string someUtxo = default(string))
        {
            this.TokenId = tokenId;
            this.Holders = holders;
            this.Divibility = divibility;
            this.LockStatus = lockStatus;
            this.AggregationPolicy = aggregationPolicy;
            this.SomeUtxo = someUtxo;
        }
        
        /// <summary>
        /// TokenId of the token
        /// </summary>
        /// <value>TokenId of the token</value>
        [DataMember(Name="tokenId", EmitDefaultValue=false)]
        public string TokenId { get; set; }

        /// <summary>
        /// Gets or Sets Holders
        /// </summary>
        [DataMember(Name="holders", EmitDefaultValue=false)]
        public List<GetTokenHoldersResponseHolders> Holders { get; set; }

        /// <summary>
        /// How many decimal points the token is divisble to
        /// </summary>
        /// <value>How many decimal points the token is divisble to</value>
        [DataMember(Name="divibility", EmitDefaultValue=false)]
        public decimal? Divibility { get; set; }

        /// <summary>
        /// Whether new issuances of this token are locked
        /// </summary>
        /// <value>Whether new issuances of this token are locked</value>
        [DataMember(Name="lockStatus", EmitDefaultValue=false)]
        public bool? LockStatus { get; set; }

        /// <summary>
        /// Whether the tokesn are aggregatable
        /// </summary>
        /// <value>Whether the tokesn are aggregatable</value>
        [DataMember(Name="aggregationPolicy", EmitDefaultValue=false)]
        public string AggregationPolicy { get; set; }

        /// <summary>
        /// A UTXO of this token
        /// </summary>
        /// <value>A UTXO of this token</value>
        [DataMember(Name="someUtxo", EmitDefaultValue=false)]
        public string SomeUtxo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetTokenHoldersResponse {\n");
            sb.Append("  TokenId: ").Append(TokenId).Append("\n");
            sb.Append("  Holders: ").Append(Holders).Append("\n");
            sb.Append("  Divibility: ").Append(Divibility).Append("\n");
            sb.Append("  LockStatus: ").Append(LockStatus).Append("\n");
            sb.Append("  AggregationPolicy: ").Append(AggregationPolicy).Append("\n");
            sb.Append("  SomeUtxo: ").Append(SomeUtxo).Append("\n");
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
            return this.Equals(input as GetTokenHoldersResponse);
        }

        /// <summary>
        /// Returns true if GetTokenHoldersResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GetTokenHoldersResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetTokenHoldersResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TokenId == input.TokenId ||
                    (this.TokenId != null &&
                    this.TokenId.Equals(input.TokenId))
                ) && 
                (
                    this.Holders == input.Holders ||
                    this.Holders != null &&
                    this.Holders.SequenceEqual(input.Holders)
                ) && 
                (
                    this.Divibility == input.Divibility ||
                    (this.Divibility != null &&
                    this.Divibility.Equals(input.Divibility))
                ) && 
                (
                    this.LockStatus == input.LockStatus ||
                    (this.LockStatus != null &&
                    this.LockStatus.Equals(input.LockStatus))
                ) && 
                (
                    this.AggregationPolicy == input.AggregationPolicy ||
                    (this.AggregationPolicy != null &&
                    this.AggregationPolicy.Equals(input.AggregationPolicy))
                ) && 
                (
                    this.SomeUtxo == input.SomeUtxo ||
                    (this.SomeUtxo != null &&
                    this.SomeUtxo.Equals(input.SomeUtxo))
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
                if (this.TokenId != null)
                    hashCode = hashCode * 59 + this.TokenId.GetHashCode();
                if (this.Holders != null)
                    hashCode = hashCode * 59 + this.Holders.GetHashCode();
                if (this.Divibility != null)
                    hashCode = hashCode * 59 + this.Divibility.GetHashCode();
                if (this.LockStatus != null)
                    hashCode = hashCode * 59 + this.LockStatus.GetHashCode();
                if (this.AggregationPolicy != null)
                    hashCode = hashCode * 59 + this.AggregationPolicy.GetHashCode();
                if (this.SomeUtxo != null)
                    hashCode = hashCode * 59 + this.SomeUtxo.GetHashCode();
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
