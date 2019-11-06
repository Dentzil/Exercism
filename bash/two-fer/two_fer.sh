#!/usr/bin/env bash

two_fer () {
    echo "One for ${1}, one for me."
}

two_fer "${1:-you}"
