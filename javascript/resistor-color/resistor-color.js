const colorCodeMap = {
    "black": 0,
    "brown": 1,
    "red": 2,
    "orange": 3,
    "yellow": 4,
    "green": 5,
    "blue": 6,
    "violet": 7,
    "grey": 8,
    "white": 9
};

const COLORS = Object.keys(colorCodeMap);

function colorCode(color) {
    if (colorCodeMap[color] === undefined) {
        throw "Unknown color";
    }

    return colorCodeMap[color];
};

export { colorCode, COLORS };
