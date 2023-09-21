namespace Nist.Example;

public partial class Uris {
    public const string RussianRouletteShot = "russian-roulette-shot";
}

public record Shot(bool Idle);

public partial class Errors {
    public static readonly Error Killed = new(HttpStatusCode.BadRequest, "Killed");
}

public partial class Client {
    public async Task<Shot> GetRussianRouletteShot() => await Get<Shot>(Uris.RussianRouletteShot);
}