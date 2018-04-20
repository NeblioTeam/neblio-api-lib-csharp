/* 
 * Neblio REST API Suite
 *
 * APIs for Interacting with NTP1 Tokens & The Neblio Blockchain
 *
 * OpenAPI spec version: 1.1.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
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
        /// <param name="TokenId">ID of the token.</param>
        /// <param name="Divisibility">Decimal places the token is divisible to.</param>
        /// <param name="LockStatus">Whether issuance of more tokens is locked.</param>
        /// <param name="AggregationPolicy">Whether the tokens are aggregatable.</param>
        /// <param name="TotalSupply">Total number of tokens in supply.</param>
        /// <param name="NumOfHolders">Total number of addresses this token is held at.</param>
        /// <param name="NumOfTransfers">Total number of transactions of this token.</param>
        /// <param name="NumofIssuance">Total number of times this token has been issued.</param>
        /// <param name="NumOfBurns">Number of times tokens have been burned.</param>
        /// <param name="FirstBlock">Block number token was issued in.</param>
        /// <param name="IssuanceTxid">TXID the token was issued with.</param>
        /// <param name="IssueAddress">Address that issued the tokens.</param>
        /// <param name="MetadataOfIssuance">MetadataOfIssuance.</param>
        /// <param name="MetadataOfUtxo">MetadataOfUtxo.</param>
        public GetTokenMetadataResponse(string TokenId = default(string), decimal? Divisibility = default(decimal?), bool? LockStatus = default(bool?), string AggregationPolicy = default(string), decimal? TotalSupply = default(decimal?), decimal? NumOfHolders = default(decimal?), decimal? NumOfTransfers = default(decimal?), decimal? NumofIssuance = default(decimal?), decimal? NumOfBurns = default(decimal?), decimal? FirstBlock = default(decimal?), string IssuanceTxid = default(string), string IssueAddress = default(string), GetTokenMetadataResponseMetadataOfIssuance MetadataOfIssuance = default(GetTokenMetadataResponseMetadataOfIssuance), GetTokenMetadataResponseMetadataOfIssuance MetadataOfUtxo = default(GetTokenMetadataResponseMetadataOfIssuance))
        {
            this.TokenId = TokenId;
            this.Divisibility = Divisibility;
            this.LockStatus = LockStatus;
            this.AggregationPolicy = AggregationPolicy;
            this.TotalSupply = TotalSupply;
            this.NumOfHolders = NumOfHolders;
            this.NumOfTransfers = NumOfTransfers;
            this.NumofIssuance = NumofIssuance;
            this.NumOfBurns = NumOfBurns;
            this.FirstBlock = FirstBlock;
            this.IssuanceTxid = IssuanceTxid;
            this.IssueAddress = IssueAddress;
            this.MetadataOfIssuance = MetadataOfIssuance;
            this.MetadataOfUtxo = MetadataOfUtxo;
        }
        
        /// <summary>
        /// ID of the token
        /// </summary>
        /// <value>ID of the token</value>
        [DataMember(Name="tokenId", EmitDefaultValue=false)]
        public string TokenId { get; set; }

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
        [DataMember(Name="numofIssuance", EmitDefaultValue=false)]
        public decimal? NumofIssuance { get; set; }

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
        /// Gets or Sets MetadataOfIssuance
        /// </summary>
        [DataMember(Name="metadataOfIssuance", EmitDefaultValue=false)]
        public GetTokenMetadataResponseMetadataOfIssuance MetadataOfIssuance { get; set; }

        /// <summary>
        /// Gets or Sets MetadataOfUtxo
        /// </summary>
        [DataMember(Name="metadataOfUtxo", EmitDefaultValue=false)]
        public GetTokenMetadataResponseMetadataOfIssuance MetadataOfUtxo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetTokenMetadataResponse {\n");
            sb.Append("  TokenId: ").Append(TokenId).Append("\n");
            sb.Append("  Divisibility: ").Append(Divisibility).Append("\n");
            sb.Append("  LockStatus: ").Append(LockStatus).Append("\n");
            sb.Append("  AggregationPolicy: ").Append(AggregationPolicy).Append("\n");
            sb.Append("  TotalSupply: ").Append(TotalSupply).Append("\n");
            sb.Append("  NumOfHolders: ").Append(NumOfHolders).Append("\n");
            sb.Append("  NumOfTransfers: ").Append(NumOfTransfers).Append("\n");
            sb.Append("  NumofIssuance: ").Append(NumofIssuance).Append("\n");
            sb.Append("  NumOfBurns: ").Append(NumOfBurns).Append("\n");
            sb.Append("  FirstBlock: ").Append(FirstBlock).Append("\n");
            sb.Append("  IssuanceTxid: ").Append(IssuanceTxid).Append("\n");
            sb.Append("  IssueAddress: ").Append(IssueAddress).Append("\n");
            sb.Append("  MetadataOfIssuance: ").Append(MetadataOfIssuance).Append("\n");
            sb.Append("  MetadataOfUtxo: ").Append(MetadataOfUtxo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
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
                    this.NumofIssuance == input.NumofIssuance ||
                    (this.NumofIssuance != null &&
                    this.NumofIssuance.Equals(input.NumofIssuance))
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
                    this.MetadataOfIssuance == input.MetadataOfIssuance ||
                    (this.MetadataOfIssuance != null &&
                    this.MetadataOfIssuance.Equals(input.MetadataOfIssuance))
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
                if (this.NumofIssuance != null)
                    hashCode = hashCode * 59 + this.NumofIssuance.GetHashCode();
                if (this.NumOfBurns != null)
                    hashCode = hashCode * 59 + this.NumOfBurns.GetHashCode();
                if (this.FirstBlock != null)
                    hashCode = hashCode * 59 + this.FirstBlock.GetHashCode();
                if (this.IssuanceTxid != null)
                    hashCode = hashCode * 59 + this.IssuanceTxid.GetHashCode();
                if (this.IssueAddress != null)
                    hashCode = hashCode * 59 + this.IssueAddress.GetHashCode();
                if (this.MetadataOfIssuance != null)
                    hashCode = hashCode * 59 + this.MetadataOfIssuance.GetHashCode();
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
