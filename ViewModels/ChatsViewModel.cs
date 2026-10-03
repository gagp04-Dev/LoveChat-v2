using LoveChat_v2.Models;
using LoveChat_v2.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;

namespace LoveChat_v2.ViewModels;

public class ChatsViewModel
{
    public ObservableCollection<Conversation> Conversations { get; set; } // Property to hold the list of conversations

    public ICommand OpenChatCommand { get; }

    public ChatsViewModel()
    {
        Conversations = new ObservableCollection<Conversation> // Initialize the Conversations collection with sample data
        {
            new Conversation
            {
                Name = "Sofia",
                LastMessage = "See you tomorrow!",
                Time = "18:42"
            },

            new Conversation
            {
                Name = "Lucas",
                LastMessage = "Did you finish the project?",
                Time = "17:15"
            },

            new Conversation
            {
                Name = "Emma",
                LastMessage = "😂😂😂",
                Time = "Yesterday"
            }
        };

        OpenChatCommand = new Command<Conversation>(OpenChat); // Initialize the OpenChatCommand with the OpenChat method

    }

    private async void OpenChat(Conversation conversation) // Method to handle opening a chat when a conversation is selected
    {
        if (conversation == null)
            return;

        await Shell.Current.GoToAsync( //Obtein the current Shell and navigate to the ChatPage, passing the conversation details as query parameters

            $"{nameof(ChatPage)}" + 
        $"?name={Uri.EscapeDataString(conversation.Name)}" +
        $"&lastMessage={Uri.EscapeDataString(conversation.LastMessage)}"

        );
    }
}