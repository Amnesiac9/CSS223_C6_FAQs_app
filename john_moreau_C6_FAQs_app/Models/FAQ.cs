﻿namespace john_moreau_C6_FAQs_app.Models
/*
* John Moreau
* CSS233
* 11/1/2023
*
*
*/
{
    public class FAQ
    {
        public int Id { get; set; }
        public string Question { get; set; } = string.Empty;
        public string Answer { get; set; } = string.Empty;
        public string CategoryId { get; set; } = string.Empty;
        public Category? Category { get; set; }
        public string TopicId { get; set; } = string.Empty;
        public Topic? Topic { get; set; }
    }
}
