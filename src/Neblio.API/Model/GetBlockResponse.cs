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
    /// GetBlockResponse
    /// </summary>
    [DataContract]
    public partial class GetBlockResponse :  IEquatable<GetBlockResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetBlockResponse" /> class.
        /// </summary>
        /// <param name="hash">Block hash.</param>
        /// <param name="confirmations">Number of confirmations block has.</param>
        /// <param name="size">Block size in bytes.</param>
        /// <param name="height">Block height.</param>
        /// <param name="version">Block version.</param>
        /// <param name="merkleroot">Merkleroot of block.</param>
        /// <param name="tx">Array of tx ids in the block.</param>
        /// <param name="time">Block time relative to epoch.</param>
        /// <param name="nonce">Block nonce.</param>
        /// <param name="bits">Block bits.</param>
        /// <param name="difficulty">Block difficulty.</param>
        /// <param name="previousblockhash">Hash of the previous block on the chain.</param>
        /// <param name="nextblockhash">Hash of the next block on the chain.</param>
        /// <param name="reward">Number of NEBL awarded in this block.</param>
        public GetBlockResponse(string hash = default(string), decimal? confirmations = default(decimal?), decimal? size = default(decimal?), decimal? height = default(decimal?), decimal? version = default(decimal?), string merkleroot = default(string), List<string> tx = default(List<string>), decimal? time = default(decimal?), decimal? nonce = default(decimal?), string bits = default(string), decimal? difficulty = default(decimal?), string previousblockhash = default(string), string nextblockhash = default(string), decimal? reward = default(decimal?))
        {
            this.Hash = hash;
            this.Confirmations = confirmations;
            this.Size = size;
            this.Height = height;
            this.Version = version;
            this.Merkleroot = merkleroot;
            this.Tx = tx;
            this.Time = time;
            this.Nonce = nonce;
            this.Bits = bits;
            this.Difficulty = difficulty;
            this.Previousblockhash = previousblockhash;
            this.Nextblockhash = nextblockhash;
            this.Reward = reward;
        }
        
        /// <summary>
        /// Block hash
        /// </summary>
        /// <value>Block hash</value>
        [DataMember(Name="hash", EmitDefaultValue=false)]
        public string Hash { get; set; }

        /// <summary>
        /// Number of confirmations block has
        /// </summary>
        /// <value>Number of confirmations block has</value>
        [DataMember(Name="confirmations", EmitDefaultValue=false)]
        public decimal? Confirmations { get; set; }

        /// <summary>
        /// Block size in bytes
        /// </summary>
        /// <value>Block size in bytes</value>
        [DataMember(Name="size", EmitDefaultValue=false)]
        public decimal? Size { get; set; }

        /// <summary>
        /// Block height
        /// </summary>
        /// <value>Block height</value>
        [DataMember(Name="height", EmitDefaultValue=false)]
        public decimal? Height { get; set; }

        /// <summary>
        /// Block version
        /// </summary>
        /// <value>Block version</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public decimal? Version { get; set; }

        /// <summary>
        /// Merkleroot of block
        /// </summary>
        /// <value>Merkleroot of block</value>
        [DataMember(Name="merkleroot", EmitDefaultValue=false)]
        public string Merkleroot { get; set; }

        /// <summary>
        /// Array of tx ids in the block
        /// </summary>
        /// <value>Array of tx ids in the block</value>
        [DataMember(Name="tx", EmitDefaultValue=false)]
        public List<string> Tx { get; set; }

        /// <summary>
        /// Block time relative to epoch
        /// </summary>
        /// <value>Block time relative to epoch</value>
        [DataMember(Name="time", EmitDefaultValue=false)]
        public decimal? Time { get; set; }

        /// <summary>
        /// Block nonce
        /// </summary>
        /// <value>Block nonce</value>
        [DataMember(Name="nonce", EmitDefaultValue=false)]
        public decimal? Nonce { get; set; }

        /// <summary>
        /// Block bits
        /// </summary>
        /// <value>Block bits</value>
        [DataMember(Name="bits", EmitDefaultValue=false)]
        public string Bits { get; set; }

        /// <summary>
        /// Block difficulty
        /// </summary>
        /// <value>Block difficulty</value>
        [DataMember(Name="difficulty", EmitDefaultValue=false)]
        public decimal? Difficulty { get; set; }

        /// <summary>
        /// Hash of the previous block on the chain
        /// </summary>
        /// <value>Hash of the previous block on the chain</value>
        [DataMember(Name="previousblockhash", EmitDefaultValue=false)]
        public string Previousblockhash { get; set; }

        /// <summary>
        /// Hash of the next block on the chain
        /// </summary>
        /// <value>Hash of the next block on the chain</value>
        [DataMember(Name="nextblockhash", EmitDefaultValue=false)]
        public string Nextblockhash { get; set; }

        /// <summary>
        /// Number of NEBL awarded in this block
        /// </summary>
        /// <value>Number of NEBL awarded in this block</value>
        [DataMember(Name="reward", EmitDefaultValue=false)]
        public decimal? Reward { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetBlockResponse {\n");
            sb.Append("  Hash: ").Append(Hash).Append("\n");
            sb.Append("  Confirmations: ").Append(Confirmations).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  Merkleroot: ").Append(Merkleroot).Append("\n");
            sb.Append("  Tx: ").Append(Tx).Append("\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
            sb.Append("  Nonce: ").Append(Nonce).Append("\n");
            sb.Append("  Bits: ").Append(Bits).Append("\n");
            sb.Append("  Difficulty: ").Append(Difficulty).Append("\n");
            sb.Append("  Previousblockhash: ").Append(Previousblockhash).Append("\n");
            sb.Append("  Nextblockhash: ").Append(Nextblockhash).Append("\n");
            sb.Append("  Reward: ").Append(Reward).Append("\n");
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
            return this.Equals(input as GetBlockResponse);
        }

        /// <summary>
        /// Returns true if GetBlockResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GetBlockResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetBlockResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Hash == input.Hash ||
                    (this.Hash != null &&
                    this.Hash.Equals(input.Hash))
                ) && 
                (
                    this.Confirmations == input.Confirmations ||
                    (this.Confirmations != null &&
                    this.Confirmations.Equals(input.Confirmations))
                ) && 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
                ) && 
                (
                    this.Height == input.Height ||
                    (this.Height != null &&
                    this.Height.Equals(input.Height))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
                ) && 
                (
                    this.Merkleroot == input.Merkleroot ||
                    (this.Merkleroot != null &&
                    this.Merkleroot.Equals(input.Merkleroot))
                ) && 
                (
                    this.Tx == input.Tx ||
                    this.Tx != null &&
                    this.Tx.SequenceEqual(input.Tx)
                ) && 
                (
                    this.Time == input.Time ||
                    (this.Time != null &&
                    this.Time.Equals(input.Time))
                ) && 
                (
                    this.Nonce == input.Nonce ||
                    (this.Nonce != null &&
                    this.Nonce.Equals(input.Nonce))
                ) && 
                (
                    this.Bits == input.Bits ||
                    (this.Bits != null &&
                    this.Bits.Equals(input.Bits))
                ) && 
                (
                    this.Difficulty == input.Difficulty ||
                    (this.Difficulty != null &&
                    this.Difficulty.Equals(input.Difficulty))
                ) && 
                (
                    this.Previousblockhash == input.Previousblockhash ||
                    (this.Previousblockhash != null &&
                    this.Previousblockhash.Equals(input.Previousblockhash))
                ) && 
                (
                    this.Nextblockhash == input.Nextblockhash ||
                    (this.Nextblockhash != null &&
                    this.Nextblockhash.Equals(input.Nextblockhash))
                ) && 
                (
                    this.Reward == input.Reward ||
                    (this.Reward != null &&
                    this.Reward.Equals(input.Reward))
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
                if (this.Hash != null)
                    hashCode = hashCode * 59 + this.Hash.GetHashCode();
                if (this.Confirmations != null)
                    hashCode = hashCode * 59 + this.Confirmations.GetHashCode();
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.Height != null)
                    hashCode = hashCode * 59 + this.Height.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.Merkleroot != null)
                    hashCode = hashCode * 59 + this.Merkleroot.GetHashCode();
                if (this.Tx != null)
                    hashCode = hashCode * 59 + this.Tx.GetHashCode();
                if (this.Time != null)
                    hashCode = hashCode * 59 + this.Time.GetHashCode();
                if (this.Nonce != null)
                    hashCode = hashCode * 59 + this.Nonce.GetHashCode();
                if (this.Bits != null)
                    hashCode = hashCode * 59 + this.Bits.GetHashCode();
                if (this.Difficulty != null)
                    hashCode = hashCode * 59 + this.Difficulty.GetHashCode();
                if (this.Previousblockhash != null)
                    hashCode = hashCode * 59 + this.Previousblockhash.GetHashCode();
                if (this.Nextblockhash != null)
                    hashCode = hashCode * 59 + this.Nextblockhash.GetHashCode();
                if (this.Reward != null)
                    hashCode = hashCode * 59 + this.Reward.GetHashCode();
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
