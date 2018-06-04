using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExploreCalifornia.Models
{
    public class Post
    {
        public long Id { get; set; }

        private string _key;

        public string key
        {
            get
            {
                if (String.IsNullOrEmpty(_key))
                {
                    _key = Regex.Replace(Title.ToLower(), "[^a-z0-9]", "-");
                }

                return _key;
            }

            set
            {
                _key = value;
            }
        }

        [Display(Name = "Post Title")]
        [Required]
        [DataType(DataType.Text)]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Title must be between 5 and 00 characters long")]
        public string Title { get; set; }
        [Required]
        [MinLength(10, ErrorMessage = "Blog posts must be at least 00 characters long")]
        [DataType(DataType.MultilineText)]
        public string Body { get; set; }
        public string Author { get; set; }
        public DateTime Posted { get; set; }
    }
}
