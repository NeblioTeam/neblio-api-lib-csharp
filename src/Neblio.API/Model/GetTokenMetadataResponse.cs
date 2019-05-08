/* 
 * Neblio REST API Suite
 *
 * APIs for Interacting with NTP1 Tokens & The Neblio Blockchain
 *
 * OpenAPI spec version: 1.2.4
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
    /// GetTokenMetadataResponse
    /// </summary>
    [DataContract]
    public partial class GetTokenMetadataResponse :  IEquatable<GetTokenMetadataResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetTokenMetadataResponse" /> class.
        /// </summary>
        /// <param name="tokenId">ID of the token.</param>
        /// <param name="someUtxo">Example UTXO containing this token..</param>
        /// <param name="divisibility">Decimal places the token is divisible to.</param>
        /// <param name="lockStatus">Whether issuance of more tokens is locked.</param>
        /// <param name="aggregationPolicy">Whether the tokens are aggregatable.</param>
        /// <param name="totalSupply">Total number of tokens in supply.</param>
        /// <param name="numOfHolders">Total number of addresses this token is held at.</param>
        /// <param name="numOfTransfers">Total number of transactions of this token.</param>
        /// <param name="numOfIssuance">Total number of times this token has been issued.</param>
        /// <param name="numOfBurns">Number of times tokens have been burned.</param>
        /// <param name="firstBlock">Block number token was issued in.</param>
        /// <param name="issuanceTxid">TXID the token was issued with.</param>
        /// <param name="issueAddress">Address that issued the tokens.</param>
        /// <param name="metadataOfIssuence">metadataOfIssuence.</param>
        /// <param name="metadataOfUtxo">metadataOfUtxo.</param>
        public GetTokenMetadataResponse(string tokenId = default(string), string someUtxo = default(string), decimal? divisibility = default(decimal?), bool? lockStatus = default(bool?), string aggregationPolicy = default(string), decimal? totalSupply = default(decimal?), decimal? numOfHolders = default(decimal?), decimal? numOfTransfers = default(decimal?), decimal? numOfIssuance = default(decimal?), decimal? numOfBurns = default(decimal?), decimal? firstBlock = default(decimal?), string issuanceTxid = default(string), string issueAddress = default(string), GetTokenMetadataResponseMetadataOfIssuence metadataOfIssuence = default(GetTokenMetadataResponseMetadataOfIssuence), GetTokenMetadataResponseMetadataOfUtxo metadataOfUtxo = default(GetTokenMetadataResponseMetadataOfUtxo))
        {
            this.TokenId = tokenId;
            this.SomeUtxo = someUtxo;
            this.Divisibility = divisibility;
            this.LockStatus = lockStatus;
            this.AggregationPolicy = aggregationPolicy;
            this.TotalSupply = totalSupply;
            this.NumOfHolders = numOfHolders;
            this.NumOfTransfers = numOfTransfers;
            this.NumOfIssuance = numOfIssuance;
            this.NumOfBurns = numOfBurns;
            this.FirstBlock = firstBlock;
            this.IssuanceTxid = issuanceTxid;
            this.IssueAddress = issueAddress;
            this.MetadataOfIssuence = metadataOfIssuence;
            this.MetadataOfUtxo = metadataOfUtxo;
        }
        
        /// <summary>
        /// ID of the token
        /// </summary>
        /// <value>ID of the token</value>
        [DataMember(Name="tokenId", EmitDefaultValue=false)]
        public string TokenId { get; set; }

        /// <summary>
        /// Example UTXO containing this token.
        /// </summary>
        /// <value>Example UTXO containing this token.</value>
        [DataMember(Name="someUtxo", EmitDefaultValue=false)]
        public string SomeUtxo { get; set; }

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
        /// Total number of tokens in supply
        /// </summary>
        /// <value>Total number of tokens in supply</value>
        [DataMember(Name="totalSupply", EmitDefaultValue=false)]
        public decimal? TotalSupply { get; set; }

        /// <summary>
        /// Total number of addresses this token is held at
        /// </summary>
        /// <value>Total number of addresses this token is held at</value>
        [DataMember(Name="numOfHolders", EmitDefaultValue=false)]
        public decimal? NumOfHolders { get; set; }

        /// <summary>
        /// Total number of transactions of this token
        /// </summary>
        /// <value>Total number of transactions of this token</value>
        [DataMember(Name="numOfTransfers", EmitDefaultValue=false)]
        public decimal? NumOfTransfers { get; set; }

        /// <summary>
        /// Total number of times this token has been issued
        /// </summary>
        /// <value>Total number of times this token has been issued</value>
        [DataMember(Name="numOfIssuance", EmitDefaultValue=false)]
        public decimal? NumOfIssuance { get; set; }

        /// <summary>
        /// Number of times tokens have been burned
        /// </summary>
        /// <value>Number of times tokens have been burned</value>
        [DataMember(Name="numOfBurns", EmitDefaultValue=false)]
        public decimal? NumOfBurns { get; set; }

        /// <summary>
        /// Block number token was issued in
        /// </summary>
        /// <value>Block number token was issued in</value>
        [DataMember(Name="firstBlock", EmitDefaultValue=false)]
        public decimal? FirstBlock { get; set; }

        /// <summary>
        /// TXID the token was issued with
        /// </summary>
        /// <value>TXID the token was issued with</value>
        [DataMember(Name="issuanceTxid", EmitDefaultValue=false)]
        public string IssuanceTxid { get; set; }

        /// <summary>
        /// Address that issued the tokens
        /// </summary>
        /// <value>Address that issued the tokens</value>
        [DataMember(Name="issueAddress", EmitDefaultValue=false)]
        public string IssueAddress { get; set; }

        /// <summary>
        /// Gets or Sets MetadataOfIssuence
        /// </summary>
        [DataMember(Name="metadataOfIssuence", EmitDefaultValue=false)]
        public GetTokenMetadataResponseMetadataOfIssuence MetadataOfIssuence { get; set; }

        /// <summary>
        /// Gets or Sets MetadataOfUtxo
        /// </summary>
        [DataMember(Name="metadataOfUtxo", EmitDefaultValue=false)]
        public GetTokenMetadataResponseMetadataOfUtxo MetadataOfUtxo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetTokenMetadataResponse {\n");
            sb.Append("  TokenId: ").Append(TokenId).Append("\n");
            sb.Append("  SomeUtxo: ").Append(SomeUtxo).Append("\n");
            sb.Append("  Divisibility: ").Append(Divisibility).Append("\n");
            sb.Append("  LockStatus: ").Append(LockStatus).Append("\n");
            sb.Append("  AggregationPolicy: ").Append(AggregationPolicy).Append("\n");
            sb.Append("  TotalSupply: ").Append(TotalSupply).Append("\n");
            sb.Append("  NumOfHolders: ").Append(NumOfHolders).Append("\n");
            sb.Append("  NumOfTransfers: ").Append(NumOfTransfers).Append("\n");
            sb.Append("  NumOfIssuance: ").Append(NumOfIssuance).Append("\n");
            sb.Append("  NumOfBurns: ").Append(NumOfBurns).Append("\n");
            sb.Append("  FirstBlock: ").Append(FirstBlock).Append("\n");
            sb.Append("  IssuanceTxid: ").Append(IssuanceTxid).Append("\n");
            sb.Append("  IssueAddress: ").Append(IssueAddress).Append("\n");
            sb.Append("  MetadataOfIssuence: ").Append(MetadataOfIssuence).Append("\n");
            sb.Append("  MetadataOfUtxo: ").Append(MetadataOfUtxo).Append("\n");
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
            return this.Equals(input as GetTokenMetadataResponse);
        }

        /// <summary>
        /// Returns true if GetTokenMetadataResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GetTokenMetadataResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetTokenMetadataResponse input)
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
                    this.SomeUtxo == input.SomeUtxo ||
                    (this.SomeUtxo != null &&
                    this.SomeUtxo.Equals(input.SomeUtxo))
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
                ) && 
                (
                    this.TotalSupply == input.TotalSupply ||
                    (this.TotalSupply != null &&
                    this.TotalSupply.Equals(input.TotalSupply))
                ) && 
                (
                    this.NumOfHolders == input.NumOfHolders ||
                    (this.NumOfHolders != null &&
                    this.NumOfHolders.Equals(input.NumOfHolders))
                ) && 
                (
                    this.NumOfTransfers == input.NumOfTransfers ||
                    (this.NumOfTransfers != null &&
                    this.NumOfTransfers.Equals(input.NumOfTransfers))
                ) && 
                (
                    this.NumOfIssuance == input.NumOfIssuance ||
                    (this.NumOfIssuance != null &&
                    this.NumOfIssuance.Equals(input.NumOfIssuance))
                ) && 
                (
                    this.NumOfBurns == input.NumOfBurns ||
                    (this.NumOfBurns != null &&
                    this.NumOfBurns.Equals(input.NumOfBurns))
                ) && 
                (
                    this.FirstBlock == input.FirstBlock ||
                    (this.FirstBlock != null &&
                    this.FirstBlock.Equals(input.FirstBlock))
                ) && 
                (
                    this.IssuanceTxid == input.IssuanceTxid ||
                    (this.IssuanceTxid != null &&
                    this.IssuanceTxid.Equals(input.IssuanceTxid))
                ) && 
                (
                    this.IssueAddress == input.IssueAddress ||
                    (this.IssueAddress != null &&
                    this.IssueAddress.Equals(input.IssueAddress))
                ) && 
                (
                    this.MetadataOfIssuence == input.MetadataOfIssuence ||
                    (this.MetadataOfIssuence != null &&
                    this.MetadataOfIssuence.Equals(input.MetadataOfIssuence))
                ) && 
                (
                    this.MetadataOfUtxo == input.MetadataOfUtxo ||
                    (this.MetadataOfUtxo != null &&
                    this.MetadataOfUtxo.Equals(input.MetadataOfUtxo))
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
                if (this.SomeUtxo != null)
                    hashCode = hashCode * 59 + this.SomeUtxo.GetHashCode();
                if (this.Divisibility != null)
                    hashCode = hashCode * 59 + this.Divisibility.GetHashCode();
                if (this.LockStatus != null)
                    hashCode = hashCode * 59 + this.LockStatus.GetHashCode();
                if (this.AggregationPolicy != null)
                    hashCode = hashCode * 59 + this.AggregationPolicy.GetHashCode();
                if (this.TotalSupply != null)
                    hashCode = hashCode * 59 + this.TotalSupply.GetHashCode();
                if (this.NumOfHolders != null)
                    hashCode = hashCode * 59 + this.NumOfHolders.GetHashCode();
                if (this.NumOfTransfers != null)
                    hashCode = hashCode * 59 + this.NumOfTransfers.GetHashCode();
                if (this.NumOfIssuance != null)
                    hashCode = hashCode * 59 + this.NumOfIssuance.GetHashCode();
                if (this.NumOfBurns != null)
                    hashCode = hashCode * 59 + this.NumOfBurns.GetHashCode();
                if (this.FirstBlock != null)
                    hashCode = hashCode * 59 + this.FirstBlock.GetHashCode();
                if (this.IssuanceTxid != null)
                    hashCode = hashCode * 59 + this.IssuanceTxid.GetHashCode();
                if (this.IssueAddress != null)
                    hashCode = hashCode * 59 + this.IssueAddress.GetHashCode();
                if (this.MetadataOfIssuence != null)
                    hashCode = hashCode * 59 + this.MetadataOfIssuence.GetHashCode();
                if (this.MetadataOfUtxo != null)
                    hashCode = hashCode * 59 + this.MetadataOfUtxo.GetHashCode();
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
