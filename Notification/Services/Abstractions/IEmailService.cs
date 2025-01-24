﻿namespace Notification.Services.Abstractions;

public interface IEmailService
{
    Task SendEmailAsync(string to, string subject, string body);
}