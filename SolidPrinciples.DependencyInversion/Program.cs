

// use Email sender
//using SolidPrinciples.DependencyInversion;

//IMessageSender emailSender = new EmailSender();
//Notification emailNotification = new Notification(emailSender);
//emailNotification.Send("Hello via Email!");

//// use SMS sender
//IMessageSender smsSender = new SmsSender();
//Notification smsNotification = new Notification(smsSender);
//smsNotification.Send("Hello via SMS");


// Configure container Dependency Inversion (DI)
using Microsoft.Extensions.DependencyInjection;
using SolidPrinciples.DependencyInversion;

var serviceProvider = new ServiceCollection()
    .AddTransient<IMessageSender, EmailSender>() // Cambia a SmsSender según sea necesario
    .BuildServiceProvider();

// Resolve dependency
var messageSender = serviceProvider.GetService<IMessageSender>();
var notification = new Notification(messageSender);
notification.Send("Hello via Email or SMS depending on DI configuration!");
