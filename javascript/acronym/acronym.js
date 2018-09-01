class Acronyms {
    constructor() {}

    parse(phrase) {
        let words = phrase.split(/[^a-zA-Z]/g)
                          .filter(e => e.length > 0)
                          .map(e =>
                            {
                                return e.match(/^[A-Z]+$/)
                                    ? e[0]
                                    : e[0].toUpperCase() + e.slice(1).replace(/[^A-Z]/g, '');
                            })
                          .join('');

        return words;
    }
}

module.exports = new Acronyms();
