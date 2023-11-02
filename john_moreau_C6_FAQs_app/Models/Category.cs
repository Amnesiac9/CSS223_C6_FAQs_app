using System.ComponentModel.DataAnnotations;
/*
* John Moreau
* CSS233
* 11/1/2023
*
*
*/
namespace john_moreau_C6_FAQs_app.Models
{
    public class Category
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; } = string.Empty;

    }
}
