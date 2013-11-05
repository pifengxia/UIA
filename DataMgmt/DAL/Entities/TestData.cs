//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    
    public partial class TestData
    {
        public int Id { get; set; }

        public int ProjectId { get; set; }

        [DisplayName("Test Case ID")]
        [Required(ErrorMessage="Test Case ID Required")]
        public string TestCaseId { get; set; }

        [DisplayName("Name")]
        [Required(ErrorMessage = "Name Required")]
        public string Name { get; set; }

        public string Value { get; set; }
    }
}
