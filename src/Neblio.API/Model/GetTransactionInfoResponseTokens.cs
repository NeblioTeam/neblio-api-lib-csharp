/* 
 * Neblio REST API Suite
 *
 * APIs for Interacting with NTP1 Tokens & The Neblio Blockchain
 *
 * OpenAPI spec version: 1.2.3
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
    /// GetTransactionInfoResponseTokens
    /// </summary>
    [DataContract]
    public partial class GetTransactionInfoResponseTokens :  IEquatable<GetTransactionInfoResponseTokens>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetTransactionInfoResponseTokens" /> class.
        /// </summary>
        /// <param name="tokenId">ID of the token.</param>
        /// <param name="amount">Number of tokens.</param>
        /// <param name="issueTxid">TXID the token was issued in.</param>
        /// <param name="divisibility">Decimal places the token is divisible to.</param>
        /// <param name="lockStatus">Whether issuance of more tokens is locked.</param>
        /// <param name="aggregationPolicy">Whether the tokens are aggregatable.</param>
        public GetTransactionInfoResponseTokens(string tokenId = default(string), decimal? amount = default(decimal?), string issueTxid = default(string), decimal? divisibility = default(decimal?), bool? lockStatus = default(bool?), string aggregationPolicy = default(string))
        {
            this.TokenId = tokenId;
            this.Amount = amount;
            this.IssueTxid = issueTxid;
            this.Divisibility = divisibility;
            this.LockStatus = lockStatus;
            this.AggregationPolicy = aggregationPolicy;
        }
        
        /// <summary>
        /// ID of the token
        /// </summary>
        /// <value>ID of the token</value>
        [DataMember(Name="tokenId", EmitDefaultValue=false)]
        public string TokenId { get; set; }

        /// <summary>
        /// Number of tokens
        /// </summary>
        /// <value>Number of tokens</value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public decimal? Amount { get; set; }

        /// <summary>
        /// TXID the token was issued in
        /// </summary>
        /// <value>TXID the token was issued in</value>
        [DataMember(Name="issueTxid", EmitDefaultValue=false)]
        public string IssueTxid { get; set; }

        /// <summary>
        /// Decimal places the token is divisible to
        /// </summary>
        /// <value>Decimal places the token is divisible to</value>
        [DataMember(Name="divisibility", EmitDefaultValue=false)]
        public decimal? Divisibility { get; set; }

        /// <summary>
        /// Whether issuance of more tokens is locked
        /// </summary>
        /// <value>Whether issuance of more tokens is locked</value>
        [DataMember(Name="lockStatus", EmitDefaultValue=false)]
        public bool? LockStatus { get; set; }

        /// <summary>
        /// Whether the tokens are aggregatable
        /// </summary>
        /// <value>Whether the tokens are aggregatable</value>
        [DataMember(Name="aggregationPolicy", EmitDefaultValue=false)]
        public string AggregationPolicy { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetTransactionInfoResponseTokens {\n");
            sb.Append("  TokenId: ").Append(TokenId).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  IssueTxid: ").Append(IssueTxid).Append("\n");
            sb.Append("  Divisibility: ").Append(Divisibility).Append("\n");
            sb.Append("  LockStatus: ").Append(LockStatus).Append("\n");
            sb.Append("  AggregationPolicy: ").Append(AggregationPolicy).Append("\n");
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
            return this.Equals(input as GetTransactionInfoResponseTokens);
        }

        /// <summary>
        /// Returns true if GetTransactionInfoResponseTokens instances are equal
        /// </summary>
        /// <param name="input">Instance of GetTransactionInfoResponseTokens to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetTransactionInfoResponseTokens input)
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
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.IssueTxid == input.IssueTxid ||
                    (this.IssueTxid != null &&
                    this.IssueTxid.Equals(input.IssueTxid))
                ) && 
                (
                    this.Divisibility == input.Divisibility ||
                    (this.Divisibility != null &&
                    this.Divisibility.Equals(input.Divisibility))
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
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.IssueTxid != null)
                    hashCode = hashCode * 59 + this.IssueTxid.GetHashCode();
                if (this.Divisibility != null)
                    hashCode = hashCode * 59 + this.Divisibility.GetHashCode();
                if (this.LockStatus != null)
                    hashCode = hashCode * 59 + this.LockStatus.GetHashCode();
                if (this.AggregationPolicy != null)
                    hashCode = hashCode * 59 + this.AggregationPolicy.GetHashCode();
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
