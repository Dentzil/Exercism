#!/usr/bin/env bash

error_handling()
{
    if [[ "$#" != 1 ]]; then
        echo "Usage: ./error_handling <greetee>"
        return 1
    fi

    echo "Hello, ${1}"
}

error_handling "$@"
