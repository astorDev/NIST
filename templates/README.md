## Installation

Use the command b

```sh
dotnet new install Nist.Template
```

## Usage

Running the command below will add initial project files from the nist template:

```sh
dotnet new nist 
```

This is what the file structure will look after:

```text
📁 protocol
📁 tests
📁 webapi
📄 docker-compose.yml
📄 <folder-name>.sln
```

### Ensuring everything works fine

After the files are added, you should be able to successfully run the tests with:

```sh
cd tests && dotnet test
```

You should also be able to run the app via:

```sh
cd webapi && dotnet run
```

Assuming you have [httpyac CLI installed](https://httpyac.github.io/guide/installation_cli) In another terminal session from the `tests` folder run:

```sh
httpyac send --all *.http --env=local
```

And you should get something resembling this:

![](/templates/httpyac-demo.png)