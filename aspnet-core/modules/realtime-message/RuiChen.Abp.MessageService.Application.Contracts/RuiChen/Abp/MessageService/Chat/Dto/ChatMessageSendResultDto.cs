﻿namespace RuiChen.Abp.MessageService.Chat;

public class ChatMessageSendResultDto
{
    public string MessageId { get; }
    public ChatMessageSendResultDto(string messageId)
    {
        MessageId = messageId;
    }
}
