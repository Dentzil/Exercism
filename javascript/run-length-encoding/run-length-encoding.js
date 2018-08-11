class RLE {
    constructor() { }

    encode(str) {
        let encoded = [];
        let count = 1;

        for (let i = 0; i < str.length; i++) {
            if (str[i] !== str[i + 1]) {
                encoded.push(`${count === 1 ? '' : count}${str[i]}`);
                count = 1;
            }
            else {
                count++;
            }
        }

        return encoded.join('');
    }

    decode(encodedStr) {
        const decoded = [];
        const regex = /(\d*)([a-z]|[A-Z]|\s)/g;
        let match;

        do {
            match = regex.exec(encodedStr);
            if (match) {
                let count = match[1] === '' ? 1 : +match[1];
                let symbol = match[2];
                
                decoded.push(symbol.repeat(count));
            }
        } while (match);

        return decoded.join('');
    }
}

module.exports = new RLE();
