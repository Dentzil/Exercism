#!/usr/bin/env bash

leap() {
    if [[ "$#" -ne "1"  || ! "$1" =~ ^[0-9]+$ ]]; then
        echo "Usage: leap.sh <year>"
        return 1
    fi

    year="$1"

    if ((!("$year" % 4) && ("$year" % 100 || !("$year" % 400)))); then
        echo 'true'
    else
        echo 'false'
    fi
}

leap "$@"
