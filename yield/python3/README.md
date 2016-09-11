# Local dev

    python3 main.py
    
# Docker

    docker build -t confusions-yield-python3 .
    docker run -it --rm --name confusions-yield-python3-running confusions-yield-python3
    
# Expected output

    creating strings
    doing first iter
    [0]: doing work: 0
    [1]: doing work: 1
    [2]: doing work: 2
    doing second iter
    done