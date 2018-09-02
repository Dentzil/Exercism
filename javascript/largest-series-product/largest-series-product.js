export default class Series {
    constructor(series) {
        this._digits = this._toDigitArray(series);
    }

    largestProduct(span) {
        this._checSpan(span);

        let largestProduct = 0;

        for (let i = 0; i + span <= this._digits.length; i++) {
            const product = this._digits
                                .slice(i, i + span)
                                .reduce((acc, curr) => acc *= curr, 1);

            if (product > largestProduct) {
                largestProduct = product;
            }
        }

        return largestProduct;
    }

    _toDigitArray(series) {
        const elements = series.split('');

        if (!this._hasOnlyDigits(elements))
        {
            throw new Error("Invalid input.");
        }

        return elements.map(e => +e);
    }

    _hasOnlyDigits(series) {
        return series.every(e => this._isDigit(e));
    }

    _isDigit(c) {
        const charCode = c.charCodeAt(0);

        return charCode >= 48 && charCode <= 57;
    }

    _checSpan(span) {
        if (span < 0) {
            throw new Error("Invalid input.");
        }

        if (span > this._digits.length) {
            throw new Error("Slice size is too big.");
        }
    }
}
