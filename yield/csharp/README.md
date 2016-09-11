# Local dev

    dotnet restore
    dotnet run

# Docker

    docker build -t confusions-csharp .
    docker run -it --rm --name confusions-csharp-running confusions-csharp