//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System; 
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TicketDesk.Domain.Models.DataAnnotations
{
    public partial class TicketMeta
    {
    		
    	[DisplayName("Ticket Id")]
    	[Required]
        public int TicketId { get; set; }
    		
    	[DisplayName("Type")]
    	[Required]
    	[StringLength(50)]
        public string Type { get; set; }
    		
    	[DisplayName("Category")]
    	[Required]
    	[StringLength(50)]
        public string Category { get; set; }
    		
    	[DisplayName("Title")]
    	[Required]
    	[StringLength(500)]
        public string Title { get; set; }
    		
    	[DisplayName("Details")]
    	[Required]
        public string Details { get; set; }
    		
    	[DisplayName("Is Html")]
    	[Required]
        public bool IsHtml { get; set; }
    		
    	[DisplayName("Tag List")]
    	[StringLength(100)]
        public string TagList { get; set; }
    		
    	[DisplayName("Created By")]
    	[Required]
    	[StringLength(100)]
        public string CreatedBy { get; set; }
    		
    	[DisplayName("Created Date")]
    	[Required]
        public System.DateTime CreatedDate { get; set; }
    		
    	[DisplayName("Owner")]
    	[Required]
    	[StringLength(100)]
        public string Owner { get; set; }
    		
    	[DisplayName("Assigned To")]
    	[StringLength(100)]
        public string AssignedTo { get; set; }
    		
    	[DisplayName("Current Status")]
    	[Required]
    	[StringLength(50)]
        public string CurrentStatus { get; set; }
    		
    	[DisplayName("Current Status Date")]
    	[Required]
        public System.DateTime CurrentStatusDate { get; set; }
    		
    	[DisplayName("Current Status Set By")]
    	[Required]
    	[StringLength(100)]
        public string CurrentStatusSetBy { get; set; }
    		
    	[DisplayName("Last Update By")]
    	[Required]
    	[StringLength(100)]
        public string LastUpdateBy { get; set; }
    		
    	[DisplayName("Last Update Date")]
    	[Required]
        public System.DateTime LastUpdateDate { get; set; }
    		
    	[DisplayName("Priority")]
    	[StringLength(25)]
        public string Priority { get; set; }
    		
    	[DisplayName("Affects Customer")]
    	[Required]
        public bool AffectsCustomer { get; set; }
    		
    	[DisplayName("Published To Kb")]
    	[Required]
        public bool PublishedToKb { get; set; }
    		
    	[DisplayName("Version")]
    	[Required]
    	[StringLength(8)]
        public byte[] Version { get; set; }
    }
}
