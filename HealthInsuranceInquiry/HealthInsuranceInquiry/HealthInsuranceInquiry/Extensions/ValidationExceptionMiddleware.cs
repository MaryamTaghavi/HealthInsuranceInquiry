namespace HealthInsuranceInquiry.Extensions;

/// <summary>
/// مدیریت پیغام های خطا
/// </summary>
public class ValidationExceptionMiddleware
{
    private readonly RequestDelegate _next;

    public ValidationExceptionMiddleware(RequestDelegate next) => _next = next;

    public async Task InvokeAsync(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (FluentValidation.ValidationException ex)
        {
            await HandleValidationExceptionAsync(context, ex);
        }
        catch (ArgumentOutOfRangeException ex)
        {
            await HandleCustomExceptionAsync(context, ex.Message);
        }
        catch
        {
            await HandleCustomExceptionAsync(context, "خطای غیرمنتظره‌ای رخ داده است.");
        }
    }

    private static async Task HandleValidationExceptionAsync(HttpContext context, FluentValidation.ValidationException ex)
    {
        context.Response.StatusCode = StatusCodes.Status400BadRequest;
        context.Response.ContentType = "application/json";

        var errors = ex.Errors.Select(e => e.ErrorMessage).ToArray();
        var result = new { Errors = errors };

        await context.Response.WriteAsJsonAsync(result);
    }

    private static async Task HandleCustomExceptionAsync(HttpContext context, string message)
    {
        context.Response.StatusCode = StatusCodes.Status400BadRequest;
        context.Response.ContentType = "application/json";

        var result = new { Errors = new[] { message } };

        await context.Response.WriteAsJsonAsync(result);
    }
}
