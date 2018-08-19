class atbash {
    constructor() {
        this.cipherMap = {
            'a': 'z', 'b': 'y', 'c': 'x', 'd': 'w', 'e': 'v', 'f': 'u', 'g': 't', 'h': 's', 'i': 'r',
            'j': 'q', 'k': 'p', 'l': 'o', 'm': 'n', 'n': 'm', 'o': 'l', 'p': 'k', 'q': 'j', 'r': 'i',
            's': 'h', 't': 'g', 'u': 'f', 'v': 'e', 'w': 'd', 'x': 'c', 'y': 'b', 'z': 'a',
            '1': '1', '2': '2', '3': '3', '4': '4', '5': '5', '6': '6', '7': '7', '8': '8', '9': '9', '0': '0', 
        }

        this.groupSize = 5;
    }

    encode(text) {
        let encoded = [];
        let currentGroupSize = 0;

        for (let i = 0; i < text.length; i++) {
            let symbol = text[i].toLowerCase();

            if (this.cipherMap[symbol] !== undefined) {
                if (++currentGroupSize > this.groupSize) {
                    encoded.push(' ');
                    currentGroupSize = 1;
                }

                encoded.push(this.cipherMap[symbol]);
            }
        }

        return encoded.join('');
    }
}

module.exports = new atbash();
