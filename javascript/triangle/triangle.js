class Triangle {
    constructor(a, b, c) {
        this.a = a;
        this.b = b;
        this.c = c;
     }

    kind() {
        if (this._isIllegal()) {
            throw new Error();
        }
        
        if (this._isDegenerate()) {
            return "degenerate";
        }

        if (this._isEquilateral()) {
            return "equilateral";
        }
        
        if (this._isIsosceles()) {
            return "isosceles";
        }
        
        return "scalene";
    }

    _isIllegal() {
        return (this.a + this.b < this.c) 
            || (this.a + this.c < this.b) 
            || (this.b + this.c < this.a)
            || (this.a + this.b + this.c === 0);
    }

    _isDegenerate() {
        return (this.a + this.b === this.c) 
            || (this.a + this.c === this.b)
            || (this.b + this.c === this.a);
    }

    _isEquilateral() {
        return (this.a === this.b) && (this.b === this.c);
    }

    _isIsosceles() {
        return (this.a === this.b) || (this.b === this.c) || (this.a === this.c);
    }
}

module.exports = Triangle;
