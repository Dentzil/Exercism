export default class Series {
    constructor(series) {
        this.digits = series.split('').map(this._getNumericValue);
    }

    slices(sliceLength) {
        this._checkSliceLength(sliceLength);

        let series = [];

        for (let i = 0; i + sliceLength <= this.digits.length; i++) {
            series.push(this.digits.slice(i, i + sliceLength));
        }
        
        return series;
    }

    _getNumericValue(c) {
        const charCode = c.charCodeAt(0);
        if (charCode < 48 || charCode > 57) {
            throw new Error(`Invalid input: ${c}`);
        }

        return c.charCodeAt(0) - 48;
    }

    _checkSliceLength(sliceLength) {
        if (sliceLength <= 0) {
            throw new Error("Slice size is too small.");
        }

        if (sliceLength > this.digits.length) {
            throw new Error("Slice size is too big.");
        }
    }
}
