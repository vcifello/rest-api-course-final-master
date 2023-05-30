namespace Movies.Api.Auth;

public static class IdentityExtensions
{
    public static Guid? GetUserId(this HttpContext context)
    {
        var userid = context.User.Claims.SingleOrDefault(x => x.Type == "userid");

        if (Guid.TryParse(userid?.Value, out var parsedId))
        {
            return parsedId;
        }

        return null;
    }
}
