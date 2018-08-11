class Queen {
    constructor(positioning) {
        this._boardRows = 8;
        this._boardColumns = 8;
        this._defaultWhitePosition = [ 0, 3 ];
        this._defaultBlackPosition = [ 7, 3 ];

        if (positioning) {
            if (positioning.white[0] === positioning.black[0]
                && positioning.white[1] === positioning.black[1]) {
                throw "Queens cannot share the same space";
            }

            this.white = [ positioning.white[0], positioning.white[1] ];
            this.black = [ positioning.black[0], positioning.black[1] ];
        }
        else {
            this.white = this._defaultWhitePosition;
            this.black = this._defaultBlackPosition;
        }
     }

     canAttack() {
        if (this.white[0] !== this.black[0] 
            && this.white[1] != this.black[1]
            && Math.abs(this.white[0] - this.black[0]) !== Math.abs(this.white[1] - this.black[1]))
        {
            return false;
        }

        return true;
     }

     toString() {
        let board = [];

        for (let i = 0; i < this._boardRows; i++) {
            let boardRow = [];

            for (let j = 0; j < this._boardColumns; j++) {
                let boardSymbol = '_';

                if (this.white[0] === i && this.white[1] === j) {
                    boardSymbol = 'W';
                }
                else if (this.black[0] === i && this.black[1] === j) {
                    boardSymbol = 'B';
                }

                boardRow.push(boardSymbol);
            }

            board.push(boardRow.join(' '));
            board.push('\n');
        }

        return board.join('');
     }
};

module.exports = Queen;
