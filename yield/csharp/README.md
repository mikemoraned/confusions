# Local dev

    dotnet restore
    dotnet run

# Docker

    docker build -t confusions-csharp .
    docker run -it --rm --name confusions-csharp-running confusions-csharp

# Expected output

    creating strings
    doing first iter
    [0] doing work: 0
    [1] doing work: 1
    [2] doing work: 2
    doing second iter
    [3] doing work: 0
    [4] doing work: 1
    [5] doing work: 2
    done
