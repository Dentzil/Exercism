export default class Anagram {
    constructor(word) {
        this._word = word.toLowerCase();
        this._normalizedWord = this._normalizeWord(word);
    }

    matches(candidates) {
        return candidates.filter(e => this._isAnagram(e));
    }

    _normalizeWord(word) {
        let letterValues = Array(26).fill(0);

        for (let i = 0; i < word.length; i++) {
            const index = word[i].toLowerCase().charCodeAt(0) - 97;

            letterValues[index]++;
        }

        return letterValues.join('');
    }

    _isAnagram(word) {
        return this._isDifferentWord(word) && this._hasSameLetters(word);
    }

    _isDifferentWord(word) {
        return this._word !== word.toLowerCase();
    }

    _hasSameLetters(word) {
        return this._normalizedWord === this._normalizeWord(word);
    }
}
