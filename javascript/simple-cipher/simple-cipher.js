class Cipher {
    constructor(key) {
        this._alphabet = "abcdefghijklmnopqrstuvwxyz";
        this._keyLengthMin = 100;
        this._keyLengthMax = 500;

        if (key === undefined) {
            this.key = this._generateKey();
        }
        else {
            this._verifyKey(key);
            this.key = key;
        }
     }

     encode(text, reverse = false) {
        let encoded = new Array(text.length);

        for (let i = 0; i < text.length; i++) {
            const currentIndex = this._alphabet.indexOf(text[i]);
            if (currentIndex !== -1) {
                const shift = this._alphabet.indexOf(this.key[i % this.key.length]) * (reverse ? -1 : 1);

                let newIndex = (currentIndex + shift) % this._alphabet.length;
                newIndex += newIndex < 0 ? this._alphabet.length : 0;

                encoded[i] = this._alphabet[newIndex];
            }
            else {
                encoded[i] = text[i];
            }
        }

        return encoded.join('');
     }

     decode(text) {
        return this.encode(text, true);
     }

     _verifyKey(key) {
        if (key.length === 0 || !key.split('').every(e => this._isLowerCase(e))) {
            throw new Error("Bad key");
        }
     }

     _isLowerCase(c) {
        const lowerCase = c.toLowerCase();

        return lowerCase !== c.toUpperCase() && lowerCase === c;
     }

     _generateKey() {
        const keyLength = this._getRandomInt(this._keyLengthMin, this._keyLengthMax + 1);
        const key = Array.apply(null, Array(keyLength)).map(e => this._getRandomAlphabetSymbol()).join('');

        return key;
     }

     _getRandomInt(min, max) {
        min = Math.ceil(min);
        max = Math.floor(max);

        return Math.floor(Math.random() * (max - min) + min);
     }

     _getRandomAlphabetSymbol() {
        const index = this._getRandomInt(0, this._alphabet.length);

        return this._alphabet[index];
     }
};

module.exports = Cipher;
