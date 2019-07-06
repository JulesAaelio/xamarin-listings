using System;
using System.Collections.Generic;
using listings.Models;
using listings.Services;

namespace listings.Views
{
    public class MessagePageViewModel: BaseViewModel
    {
        private List<Message> _messages;

        public List<Message> Messages
        {
            get { return _messages; }
            set
            {
                this._messages = value;
                OnPropertyChanged("Messages");
            }
        }
        
        public MessagePageViewModel(bool receivedMessageMode)
        {
            if (receivedMessageMode)
            {
                LoadReceivedMessages();
            }
            else
            {
                LoadSentMessages();
            }
        }

        async void LoadReceivedMessages()
        {
            this.Messages = await ListingAPIService.Instance.GetReceivedMessages();
        }

        async void LoadSentMessages()
        {
            this.Messages = await ListingAPIService.Instance.GetSentMessages();
        }
    }
}