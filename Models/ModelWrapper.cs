using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoginReg.Models
{
    public class ModelWrapper
    {
        public User User { get; set; }
        public Message Message { get; set; }
        public Comment Comment { get; set; }
        public List<Message> Messages { get; set; }
        public List<Comment> Comments { get; set; }
    }
}