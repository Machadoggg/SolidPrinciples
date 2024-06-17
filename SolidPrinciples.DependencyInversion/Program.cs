

// use Email sender
using SolidPrinciples.DependencyInversion;

IMessageSender emailSender = new EmailSender();
Notification emailNotification = new Notification(emailSender);
emailNotification.Send("Hello via Email!");

// use SMS sender
IMessageSender smsSender = new SmsSender();
Notification smsNotification = new Notification(smsSender);
smsNotification.Send("Hello via SMS");
