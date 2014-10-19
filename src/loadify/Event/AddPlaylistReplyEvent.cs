﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using loadify.Spotify;

namespace loadify.Event
{
    public class AddPlaylistReplyEvent : SessionEvent
    {
        public string Content { get; set; }

        public AddPlaylistReplyEvent(string content, LoadifySession session):
            base(session)
        {
            Content = content;
        }
    }
}