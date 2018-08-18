class Raindrops {
    constructor() {}

    convert(number) {
        let output = [];

        if (number % 3 === 0) {
            output.push("Pling");
        }

        if (number % 5 === 0) {
            output.push("Plang");
        }

        if (number % 7 === 0) {
            output.push("Plong")
        }

        if (output.length === 0) {
            output.push(number + '');
        }

        return output.join('');
    }
};

module.exports = Raindrops;
