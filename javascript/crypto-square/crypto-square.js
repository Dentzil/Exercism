export default class Crypto {
    constructor(text) {
        this._normalizedPlaintext = this._normalizedPlaintext(text);
        this._size = this._getSize();
        this._plaintextSegments = this._getPlaintextSegments();
        this._ciphertext = this._getCyphertext();
    }

    normalizePlaintext() {
        return this._normalizedPlaintext;
    }

    size() {
        return this._size;
    }

    plaintextSegments() {
        return this._plaintextSegments;
    }

    ciphertext() {
        return this._ciphertext;
    }

    _normalizedPlaintext(text) {
        return text.split('')
                   .filter(e => this._isNotSpaceOrPunctuation(e))
                   .map(e => e.toLowerCase())
                   .join('');
    }

    _isNotSpaceOrPunctuation(c) {
        return /[a-zA-Z0-9]/.test(c);
    }

    _getSize() {
        return Math.ceil(Math.sqrt(this._normalizedPlaintext.length));
    }

    _getPlaintextSegments() {
        let segments = [];

        for (let i = 0; i < this._normalizedPlaintext.length; i += this._size) {
            segments.push(this._normalizedPlaintext.slice(i, i + this._size));
        }

        return segments;
    }

    _getCyphertext() {
        let cyphertext = [];

        for (let i = 0; i < this._size; i++) {
            cyphertext.push(this._plaintextSegments.map(e => e[i] || '').join(''));
        }

        return cyphertext.join('');
    }
}
