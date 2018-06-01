/* 
 * Neblio REST API Suite
 *
 * APIs for Interacting with NTP1 Tokens & The Neblio Blockchain
 *
 * OpenAPI spec version: 1.2.0
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
    /// Object representing flags that potentialy modify this transaction
    /// </summary>
    [DataContract]
    public partial class IssueTokenRequestFlags :  IEquatable<IssueTokenRequestFlags>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IssueTokenRequestFlags" /> class.
        /// </summary>
        /// <param name="SplitChange">If true change will be split into 2 outputs, one for NEBL change and one for NTP1 change (recommended).</param>
        public IssueTokenRequestFlags(bool? SplitChange = default(bool?))
        {
            this.SplitChange = SplitChange;
        }
        
        /// <summary>
        /// If true change will be split into 2 outputs, one for NEBL change and one for NTP1 change (recommended)
        /// </summary>
        /// <value>If true change will be split into 2 outputs, one for NEBL change and one for NTP1 change (recommended)</value>
        [DataMember(Name="splitChange", EmitDefaultValue=false)]
        public bool? SplitChange { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IssueTokenRequestFlags {\n");
            sb.Append("  SplitChange: ").Append(SplitChange).Append("\n");
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
            return this.Equals(input as IssueTokenRequestFlags);
        }

        /// <summary>
        /// Returns true if IssueTokenRequestFlags instances are equal
        /// </summary>
        /// <param name="input">Instance of IssueTokenRequestFlags to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IssueTokenRequestFlags input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SplitChange == input.SplitChange ||
                    (this.SplitChange != null &&
                    this.SplitChange.Equals(input.SplitChange))
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
                if (this.SplitChange != null)
                    hashCode = hashCode * 59 + this.SplitChange.GetHashCode();
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
