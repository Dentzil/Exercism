#!/usr/bin/env bash

reverse_string()
{
    if (( "$#" != 1 )); then
        echo "Usage: ./reverse_string.sh <string>"
        return 1
    fi

    echo "$1" | rev
}

reverse_string "$@"
