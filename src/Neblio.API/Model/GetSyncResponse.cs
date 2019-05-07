/* 
 * Neblio REST API Suite
 *
 * APIs for Interacting with NTP1 Tokens & The Neblio Blockchain
 *
 * OpenAPI spec version: 1.2.2
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
    /// Object containing node sync status
    /// </summary>
    [DataContract]
    public partial class GetSyncResponse :  IEquatable<GetSyncResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetSyncResponse" /> class.
        /// </summary>
        /// <param name="status">Current sync status.</param>
        /// <param name="blockChainHeight">Current blockchain height.</param>
        /// <param name="syncPercentage">Current sync percentage.</param>
        /// <param name="height">Height node is synced to.</param>
        /// <param name="error">Recent sync error messages.</param>
        /// <param name="type">Node type.</param>
        public GetSyncResponse(string status = default(string), decimal? blockChainHeight = default(decimal?), decimal? syncPercentage = default(decimal?), decimal? height = default(decimal?), string error = default(string), string type = default(string))
        {
            this.Status = status;
            this.BlockChainHeight = blockChainHeight;
            this.SyncPercentage = syncPercentage;
            this.Height = height;
            this.Error = error;
            this.Type = type;
        }
        
        /// <summary>
        /// Current sync status
        /// </summary>
        /// <value>Current sync status</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// Current blockchain height
        /// </summary>
        /// <value>Current blockchain height</value>
        [DataMember(Name="blockChainHeight", EmitDefaultValue=false)]
        public decimal? BlockChainHeight { get; set; }

        /// <summary>
        /// Current sync percentage
        /// </summary>
        /// <value>Current sync percentage</value>
        [DataMember(Name="syncPercentage", EmitDefaultValue=false)]
        public decimal? SyncPercentage { get; set; }

        /// <summary>
        /// Height node is synced to
        /// </summary>
        /// <value>Height node is synced to</value>
        [DataMember(Name="height", EmitDefaultValue=false)]
        public decimal? Height { get; set; }

        /// <summary>
        /// Recent sync error messages
        /// </summary>
        /// <value>Recent sync error messages</value>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public string Error { get; set; }

        /// <summary>
        /// Node type
        /// </summary>
        /// <value>Node type</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetSyncResponse {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  BlockChainHeight: ").Append(BlockChainHeight).Append("\n");
            sb.Append("  SyncPercentage: ").Append(SyncPercentage).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as GetSyncResponse);
        }

        /// <summary>
        /// Returns true if GetSyncResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GetSyncResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetSyncResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.BlockChainHeight == input.BlockChainHeight ||
                    (this.BlockChainHeight != null &&
                    this.BlockChainHeight.Equals(input.BlockChainHeight))
                ) && 
                (
                    this.SyncPercentage == input.SyncPercentage ||
                    (this.SyncPercentage != null &&
                    this.SyncPercentage.Equals(input.SyncPercentage))
                ) && 
                (
                    this.Height == input.Height ||
                    (this.Height != null &&
                    this.Height.Equals(input.Height))
                ) && 
                (
                    this.Error == input.Error ||
                    (this.Error != null &&
                    this.Error.Equals(input.Error))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.BlockChainHeight != null)
                    hashCode = hashCode * 59 + this.BlockChainHeight.GetHashCode();
                if (this.SyncPercentage != null)
                    hashCode = hashCode * 59 + this.SyncPercentage.GetHashCode();
                if (this.Height != null)
                    hashCode = hashCode * 59 + this.Height.GetHashCode();
                if (this.Error != null)
                    hashCode = hashCode * 59 + this.Error.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
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
