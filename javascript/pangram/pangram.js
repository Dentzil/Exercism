class Pangram {
    constructor(sentence) {
        this._isPangram = this._isPangram(sentence.toLowerCase());
    }

    isPangram() {
        return this._isPangram;
    }

    _isPangram(sentence) {
        let letters = Array(26).fill(0);

        for (let i = 0; i < sentence.length; i++) {
            if (this._isLetter(sentence[i])) {
                letters[sentence[i].charCodeAt(0) - 97]++;
            }
        }

        const missingLetters = letters.filter(e => e === 0).length;

        return missingLetters === 0;
    }

    _isLetter(c) {
        return c.toLowerCase() !== c.toUpperCase();
    }
};

module.exports = Pangram;
