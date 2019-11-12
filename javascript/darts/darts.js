function solve(x, y) {
    let scores = 0;

    if (isInsideInnerCircle(x, y)) {
        scores = 10;
    } else if (isInsideMiddleCircle(x, y)) {
        scores = 5;
    } else if (isInsideOuterCircle(x, y)) {
        scores = 1;
    }

    return scores;
};

function isInsideInnerCircle(x, y) {
    let isInsideInner = isInsideCircle(x, y, 1);

    return isInsideInner;
};

function isInsideMiddleCircle(x, y) {
    let isInsideMiddle = isInsideCircle(x, y, 5);

    return isInsideMiddle;
};

function isInsideOuterCircle(x, y) {
    let isInsideOuter = isInsideCircle(x, y, 10);

    return isInsideOuter;
};

function isInsideCircle(x, y, radius) {
    let distance = Math.sqrt(x * x + y * y);
    let isInside = distance <= radius;

    return isInside;
};

export { solve };
