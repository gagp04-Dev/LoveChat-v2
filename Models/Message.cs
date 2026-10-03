using System;
using System.Collections.Generic;
using System.Text;

namespace LoveChat_v2.Models
{
    public class Message
    {
        public string Text { get; set; } = string.Empty; // The text of the message

        public string Time { get; set; } = string.Empty; // The time the message was sent

        public bool IsMine { get; set; }  // Indicates if the message was sent by the user (true) or received from someone else (false)
    }
}
