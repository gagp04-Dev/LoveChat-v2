using System;
using System.Collections.Generic;
using System.Text;

namespace LoveChat_v2.Models;

public class Conversation
{
    public string Name { get; set; } = string.Empty;  //Name of the person
    public string LastMessage { get; set; } = string.Empty; //Last message sent or received
    public string Time { get; set; } = string.Empty; //Time of the last message
}
