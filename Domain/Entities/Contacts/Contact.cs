﻿using Domain.Primitives;

namespace Domain.Entities.Contacts;

public class Contact : Entity
{
    public Contact(Guid id, string username, Guid? chatId)
        : base(id)
    {
        Username = username;
        ChatId = chatId;
    }

    public string Username { get; set; }

    public Guid? ChatId { get; set; }
}