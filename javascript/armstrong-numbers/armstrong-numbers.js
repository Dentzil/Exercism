class ArmstrongNumber {
    constructor() { }

    validate (number) {
        if (number < 0) {
            return false;
        }

        let digits = this._toDigitArray(number);
        let exponent = digits.length;

        return digits.reduce((a, b) => a += Math.pow(b, exponent), 0) === number;
    }

    _toDigitArray(number) {
        let digits = [];

        if (number === 0) {
            digits.push(number);
        }
        else {
            while (number !== 0) {
                digits.push(number % 10);
                number = Math.floor(number / 10);
            }
        }

        return digits;
    }
}

module.exports = new ArmstrongNumber();
