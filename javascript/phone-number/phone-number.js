export default class PhoneNumber {
    constructor(phoneNumber) {
        this._nanpRegexp = /^1?([2-9]\d{2})([2-9]\d{2})(\d{4})$/;

        this._phoneNumber = this._getNumber(phoneNumber);
    }

    number() {
        return this._phoneNumber;
    }

    _getNumber(phoneNumber) {
        const match = phoneNumber.replace(/[\(\)\-\s\.]/g, '').match(this._nanpRegexp);
        
        return match !== null
            ? `${match[1]}${match[2]}${match[3]}`
            : null;
    }
}
