﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace bookstore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Book
    {
        public int BId { get; set; }
        [Display(Name ="Tên sách")]
        [Required]
        public string BName { get; set; }
        [Display(Name ="Mô tả")]
        [Required]
        public string BDesc { get; set; }
        [Display(Name = "Danh mục")]
        [Required]
        public int BCategoryID { get; set; }
    }
}
