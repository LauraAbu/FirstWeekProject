 public IHttpActionResult Send(long phone, string message)
{
    var messagingService = new MessagingService("l.abukauskaite@gmail.com", "asturtinga12");
    var result = messagingService.SendMessage(new SmsMessage($"+{phone}", message, "EX0235290"));

    return Ok(result);



}
