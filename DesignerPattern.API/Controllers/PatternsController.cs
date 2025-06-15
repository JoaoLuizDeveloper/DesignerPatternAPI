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
    /// <summary>
    /// Executes a basic payment processor and logs the action.
    /// </summary>
    /// <returns></returns>
    [HttpGet("singleton")]
    public IActionResult Singleton()
    {
        Logger.Instance.Log("Singleton example called.");
        return Ok("Check console output.");
    }

    /// <summary>
    /// Creates a payment using the factory pattern based on the provided type.
    /// </summary>
    /// <param name="type"></param>
    /// <returns></returns>
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

    /// <summary>
    /// Switches between different payment methods using the strategy pattern.
    /// </summary>
    /// <returns></returns>
    [HttpGet("strategy")]
    public IActionResult Strategy()
    {
        // Colocando o Strategy Pattern para calcular impostos no Brasil
        var calc = new TaxCalculator(new BrazilTax());
        var result = calc.CalculateTax(100);
        return Ok($"Calculated tax: {result}");
    }

    /// <summary>
    /// Notifies all attached observers about a payment confirmation event.
    /// </summary>
    /// <returns>An <see cref="IActionResult"/> indicating the result of the operation.  Returns an HTTP 200 OK response with the
    /// message "Observers notified".</returns>
    [HttpGet("observer")]
    public IActionResult Observer()
    {
        var subject = new PaymentSubject();
        subject.Attach(new EmailNotifier());
        subject.Attach(new SmsNotifier());
        subject.Notify("Payment confirmed");
        return Ok("Observers notified");
    }

    /// <summary>
    /// Add new feature to the payment processor using the decorator pattern.
    /// </summary>
    /// <returns></returns>
    [HttpGet("decorator")]
    public IActionResult Decorator()
    {
        IPaymentProcessor processor = new FraudCheckDecorator(new BasicPaymentProcessor());
        processor.Execute();
        return Ok("Decorator executed");
    }

    /// <summary>
    /// Builds a payment request using the builder pattern.
    /// </summary>
    /// <returns></returns>
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
