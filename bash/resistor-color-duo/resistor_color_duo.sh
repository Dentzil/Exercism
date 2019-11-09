#!/usr/bin/env bash

resistor_color_duo() {
    if (("$#" == 0)); then
        echo "Usage: ./resistor_color_duo.sh <color> [<color> ...]"
        return 1
    fi

    declare -A colorNumberMap=(
        ["black"]="0"
        ["brown"]="1"
        ["red"]="2"
        ["orange"]="3"
        ["yellow"]="4"
        ["green"]="5"
        ["blue"]="6"
        ["violet"]="7"
        ["grey"]="8"
        ["white"]="9")
    
    number=""

    for color in "${@:1:2}"; do
        if [[ -z "${colorNumberMap[${color}]}" ]]; then
            echo "invalid color: ${color}"
            return 1
        fi

        number+="${colorNumberMap[${color}]}"
    done

    echo "${number}"
}

resistor_color_duo "$@"
