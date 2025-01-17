# Template

.NET [NIST](https://github.com/astorDev/nist) API.

## Running the App 🚀

You can run the app directly:

```sh
cd host && dotnet run
```

Or via docker

```sh
docker compose up -d
```

## Testing 🧪

The app can be tested via .NET tests:

```sh
cd tests && dotnet test
```

Or via [httpyac CLI](https://httpyac.github.io/guide/installation_cli). 

> This tests are run against a running app instance, so don't forget to run it first

```sh
cd tests && httpyac send --all *.http --env=local
```