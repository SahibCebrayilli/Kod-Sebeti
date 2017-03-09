using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kod_Sebeti.Models
{
    public class Author
    {
        public string AuthorFullName { get; set; }
        public string AuthorEmail { get; set; }
        public Role AuthorRole { get; set; }
        public Post[] AuthorPosts { get; set; }
    }
    public enum Role
    {
        Admin,Editor
    }
}