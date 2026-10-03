using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using LoveChat_v2.Models;

namespace LoveChat_v2.ViewModels;

public class ChatViewModel : INotifyPropertyChanged
{
    public ObservableCollection<Message> Messages { get; set; }

    public ICommand SendMessageCommand { get; }

    private string _newMessage = string.Empty;

    public string NewMessage
    {
        get => _newMessage;
        set
        {
            if (_newMessage == value)
                return;

            _newMessage = value;
            OnPropertyChanged();
        }
    }

    public ChatViewModel()
    {
        Messages = new ObservableCollection<Message>
        {
            new Message
            {
                Text = "Hey! How are you?",
                Time = "18:35",
                IsMine = false
            },

            new Message
            {
                Text = "I'm good! Just working on LoveChat 😎",
                Time = "18:36",
                IsMine = true
            },

            new Message
            {
                Text = "Already making your own messaging app?",
                Time = "18:38",
                IsMine = false
            },

            new Message
            {
                Text = "Yeah, I'm rebuilding it from scratch.",
                Time = "18:40",
                IsMine = true
            },

            new Message
            {
                Text = "See you tomorrow!",
                Time = "18:42",
                IsMine = false
            }
        };

        SendMessageCommand = new Command(SendMessage);
    }

    private void SendMessage()
    {
        if (string.IsNullOrWhiteSpace(NewMessage))
            return;

        Messages.Add(new Message
        {
            Text = NewMessage.Trim(),
            Time = DateTime.Now.ToString("HH:mm"),
            IsMine = true
        });

        NewMessage = string.Empty;
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    protected void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}