class RotationalCipher {
    constructor() {
        this._lowerCaseLetters = "abcdefghijklmnopqrstuvwxyz";
        this._upperCaseLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    }

    rotate(text, shift) {
        let encoded = [];

        for (let i = 0; i < text.length; i++) {
            if (this._isLetter(text[i])) {
                const currentIndex = this._lowerCaseLetters.indexOf(text[i].toLowerCase());
                const newIndex = (currentIndex + shift) % this._lowerCaseLetters.length;

                encoded.push(this._isUpperCase(text[i]) ? this._upperCaseLetters[newIndex] : this._lowerCaseLetters[newIndex]);
            }
            else {
                encoded.push(text[i]);
            }
        }

        return encoded.join('');
    }

    _isLetter(c) {
        return c.toLowerCase() !== c.toUpperCase();
    }

    _isUpperCase(c) {
        return c === c.toUpperCase();
    }
}

module.exports = new RotationalCipher();
