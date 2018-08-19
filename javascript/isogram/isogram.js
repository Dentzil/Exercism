class Isogram {
    constructor(str) {
        this._isIsogram = this._isIsogram(str);
    }

    isIsogram() {
        return this._isIsogram;
    }

    _isIsogram(str) {
        let charRepetitions = {};

        for (let i = 0; i < str.length; i++) {
            let c = str[i].toLowerCase();

            if (!this._isRelevantChar(c)) {
                continue;
            }

            if (charRepetitions[c] === undefined) {
                charRepetitions[c] = 1;
            }
            else {
                charRepetitions[c]++;
            }
        }

        return Object.keys(charRepetitions).filter(e => charRepetitions[e] > 1).length == 0;
    }

    _isRelevantChar(c) {
        return c !== ' ' && c !== '-';
    }
};

module.exports = Isogram;
