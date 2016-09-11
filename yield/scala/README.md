# Local dev

    scalac src/Main.scala
    scala Main
    
# Docker

    docker build -t confusions-yield-scala .
    docker run -it --rm --name confusions-yield-scala-running confusions-yield-scala

# Expected output
    
    creating strings
    doing first iter
    [0]: doing work: 0
    [1]: doing work: 1
    [2]: doing work: 2
    doing second iter
    [0]: doing work: 0
    [1]: doing work: 1
    [2]: doing work: 2
    done
