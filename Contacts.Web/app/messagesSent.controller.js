 public IHttpActionResult Send(long phone, string message)
{
    var messagingService = new MessagingService("sm.euro@gmail.com", "");
    var result = messagingService.SendMessage(new SmsMessage($"+{phone}", message, "EX0235200"));

    return Ok(result);



}
