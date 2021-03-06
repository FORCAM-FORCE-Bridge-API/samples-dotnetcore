using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace FORCAM.BridgeAPI.Model
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class EmbeddedStaffMembers
    {
        /// <summary>
        /// The staff members
        /// </summary>
        /// <value>The staff members</value>
        [DataMember(Name = "staffMembers", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "staffMembers")]
        public List<StaffMember> StaffMembers { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmbeddedStaffMembers {\n");
            sb.Append("  StaffMembers: ").Append(StaffMembers).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Get the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

    }
}
