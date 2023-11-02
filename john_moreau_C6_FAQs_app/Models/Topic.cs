﻿using System.ComponentModel.DataAnnotations;

namespace john_moreau_C6_FAQs_app.Models
{
    public class Topic
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; } = string.Empty;

    }
}