using DesignerPattern.Application.Application.Decorators;
using DesignerPattern.Application.Builders;
using DesignerPattern.Application.Events;
using DesignerPattern.Application.Factories;
using DesignerPattern.Application.Interfaces;
using DesignerPattern.Application.Services;
using DesignerPattern.Application.Strategies;
using DesignerPattern.Infrastructure.Notifications;
using DesignerPattern.Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class PatternsController : ControllerBase
{
    [HttpGet("singleton")]
    public IActionResult Singleton()
    {
        Logger.Instance.Log("Singleton example called.");
        return Ok("Check console output.");
    }

    [HttpGet("factory/{type}")]
    public IActionResult Factory(string type)
    {
        try
        {
            var payment = PaymentFactory.Create(type);
            payment.ProcessPayment();
            return Ok($"Factory executed for type: {type}");
        }
        catch (ArgumentException ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("strategy")]
    public IActionResult Strategy()
    {
        var calc = new TaxCalculator(new BrazilTax());
        var result = calc.CalculateTax(100);
        return Ok($"Calculated tax: {result}");
    }

    [HttpGet("observer")]
    public IActionResult Observer()
    {
        var subject = new PaymentSubject();
        subject.Attach(new EmailNotifier());
        subject.Attach(new SmsNotifier());
        subject.Notify("Payment confirmed");
        return Ok("Observers notified");
    }

    [HttpGet("decorator")]
    public IActionResult Decorator()
    {
        IPaymentProcessor processor = new FraudCheckDecorator(new BasicPaymentProcessor());
        processor.Execute();
        return Ok("Decorator executed");
    }

    [HttpGet("builder")]
    public IActionResult Builder()
    {
        var request = new PaymentRequestBuilder()
            .WithMethod("pix")
            .WithAmount(500)
            .WithDescription("Service payment")
            .Build();

        return Ok(request);
    }
}
