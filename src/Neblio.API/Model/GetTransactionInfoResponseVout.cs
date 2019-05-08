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
    /// GetTransactionInfoResponseVout
    /// </summary>
    [DataContract]
    public partial class GetTransactionInfoResponseVout :  IEquatable<GetTransactionInfoResponseVout>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetTransactionInfoResponseVout" /> class.
        /// </summary>
        /// <param name="value">Value of the output in NEBL satoshi.</param>
        /// <param name="n">Output index.</param>
        /// <param name="scriptPubKey">scriptPubKey.</param>
        /// <param name="tokens">tokens.</param>
        /// <param name="used">Whether this output has now been used.</param>
        /// <param name="blockheight">Blockheight of this transaction.</param>
        /// <param name="usedBlockheight">Blockheight this output was used in.</param>
        /// <param name="usedTxid">TXID this output was used in.</param>
        public GetTransactionInfoResponseVout(decimal? value = default(decimal?), decimal? n = default(decimal?), GetTransactionInfoResponsePreviousOutput scriptPubKey = default(GetTransactionInfoResponsePreviousOutput), List<GetTransactionInfoResponseTokens> tokens = default(List<GetTransactionInfoResponseTokens>), bool? used = default(bool?), decimal? blockheight = default(decimal?), decimal? usedBlockheight = default(decimal?), string usedTxid = default(string))
        {
            this.Value = value;
            this.N = n;
            this.ScriptPubKey = scriptPubKey;
            this.Tokens = tokens;
            this.Used = used;
            this.Blockheight = blockheight;
            this.UsedBlockheight = usedBlockheight;
            this.UsedTxid = usedTxid;
        }
        
        /// <summary>
        /// Value of the output in NEBL satoshi
        /// </summary>
        /// <value>Value of the output in NEBL satoshi</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public decimal? Value { get; set; }

        /// <summary>
        /// Output index
        /// </summary>
        /// <value>Output index</value>
        [DataMember(Name="n", EmitDefaultValue=false)]
        public decimal? N { get; set; }

        /// <summary>
        /// Gets or Sets ScriptPubKey
        /// </summary>
        [DataMember(Name="scriptPubKey", EmitDefaultValue=false)]
        public GetTransactionInfoResponsePreviousOutput ScriptPubKey { get; set; }

        /// <summary>
        /// Gets or Sets Tokens
        /// </summary>
        [DataMember(Name="tokens", EmitDefaultValue=false)]
        public List<GetTransactionInfoResponseTokens> Tokens { get; set; }

        /// <summary>
        /// Whether this output has now been used
        /// </summary>
        /// <value>Whether this output has now been used</value>
        [DataMember(Name="used", EmitDefaultValue=false)]
        public bool? Used { get; set; }

        /// <summary>
        /// Blockheight of this transaction
        /// </summary>
        /// <value>Blockheight of this transaction</value>
        [DataMember(Name="blockheight", EmitDefaultValue=false)]
        public decimal? Blockheight { get; set; }

        /// <summary>
        /// Blockheight this output was used in
        /// </summary>
        /// <value>Blockheight this output was used in</value>
        [DataMember(Name="usedBlockheight", EmitDefaultValue=false)]
        public decimal? UsedBlockheight { get; set; }

        /// <summary>
        /// TXID this output was used in
        /// </summary>
        /// <value>TXID this output was used in</value>
        [DataMember(Name="usedTxid", EmitDefaultValue=false)]
        public string UsedTxid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetTransactionInfoResponseVout {\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  N: ").Append(N).Append("\n");
            sb.Append("  ScriptPubKey: ").Append(ScriptPubKey).Append("\n");
            sb.Append("  Tokens: ").Append(Tokens).Append("\n");
            sb.Append("  Used: ").Append(Used).Append("\n");
            sb.Append("  Blockheight: ").Append(Blockheight).Append("\n");
            sb.Append("  UsedBlockheight: ").Append(UsedBlockheight).Append("\n");
            sb.Append("  UsedTxid: ").Append(UsedTxid).Append("\n");
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
            return this.Equals(input as GetTransactionInfoResponseVout);
        }

        /// <summary>
        /// Returns true if GetTransactionInfoResponseVout instances are equal
        /// </summary>
        /// <param name="input">Instance of GetTransactionInfoResponseVout to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetTransactionInfoResponseVout input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.N == input.N ||
                    (this.N != null &&
                    this.N.Equals(input.N))
                ) && 
                (
                    this.ScriptPubKey == input.ScriptPubKey ||
                    (this.ScriptPubKey != null &&
                    this.ScriptPubKey.Equals(input.ScriptPubKey))
                ) && 
                (
                    this.Tokens == input.Tokens ||
                    this.Tokens != null &&
                    this.Tokens.SequenceEqual(input.Tokens)
                ) && 
                (
                    this.Used == input.Used ||
                    (this.Used != null &&
                    this.Used.Equals(input.Used))
                ) && 
                (
                    this.Blockheight == input.Blockheight ||
                    (this.Blockheight != null &&
                    this.Blockheight.Equals(input.Blockheight))
                ) && 
                (
                    this.UsedBlockheight == input.UsedBlockheight ||
                    (this.UsedBlockheight != null &&
                    this.UsedBlockheight.Equals(input.UsedBlockheight))
                ) && 
                (
                    this.UsedTxid == input.UsedTxid ||
                    (this.UsedTxid != null &&
                    this.UsedTxid.Equals(input.UsedTxid))
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
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.N != null)
                    hashCode = hashCode * 59 + this.N.GetHashCode();
                if (this.ScriptPubKey != null)
                    hashCode = hashCode * 59 + this.ScriptPubKey.GetHashCode();
                if (this.Tokens != null)
                    hashCode = hashCode * 59 + this.Tokens.GetHashCode();
                if (this.Used != null)
                    hashCode = hashCode * 59 + this.Used.GetHashCode();
                if (this.Blockheight != null)
                    hashCode = hashCode * 59 + this.Blockheight.GetHashCode();
                if (this.UsedBlockheight != null)
                    hashCode = hashCode * 59 + this.UsedBlockheight.GetHashCode();
                if (this.UsedTxid != null)
                    hashCode = hashCode * 59 + this.UsedTxid.GetHashCode();
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
