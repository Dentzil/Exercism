class ETL {
    constructor() {}

    transform(oldData) {
        let newData = {};

        for (let key in oldData) {
            oldData[key].forEach(e => newData[e.toLowerCase()] = +key);
        }
        
        return newData;
    }
};

module.exports = ETL;
