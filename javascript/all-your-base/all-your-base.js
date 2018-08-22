export default class Converter {
    constructor() {}

    convert(digits, fromBase, toBase) {
        if (!this._isValidBase(fromBase)) {
            throw new Error("Wrong input base");
        }

        if (!this._isValidBase(toBase)) {
            throw new Error("Wrong output base");
        }
        
        if (!this._isValidDigitsForBase(digits, fromBase)) {
            throw new Error("Input has wrong format");
        }

        let numberInBase10 = this._convertToBase10(digits, fromBase);

        return this._convertFromBase10(numberInBase10, toBase);
    }

    _isValidBase(base) {
        return this._isInteger(base) && base > 1;
    }

    _isInteger(number) {
        return typeof(number) === "number" && (number % 1) === 0;
    }

    _isValidDigitsForBase(digits, base) {
        return digits.length !== 0 && !this._hasLeadingZeros(digits) && digits.every(e => e >= 0 && e < base);
    }

    _hasLeadingZeros(digits) {
        return digits.length > 1 && digits[0] === 0;
    }

    _convertToBase10(digits, fromBase) {
        let number = 0;

        for (let i = digits.length - 1, exponent = 0; i >= 0; i--, exponent++) {
            number += digits[i] * (fromBase ** exponent);
        }

        return number;
    }

    _convertFromBase10(number, toBase) {
        if (number === 0) {
            return [0];
        }

        let digitsInTargetBase = [];

        while(number != 0) {
            digitsInTargetBase.unshift(number % toBase);
            number = Math.floor(number / toBase);
        }

        return digitsInTargetBase;
    }
}
