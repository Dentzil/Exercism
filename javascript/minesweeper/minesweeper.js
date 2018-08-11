class Minesweeper {
    constructor() {
        this._mineSymbol = '*';
        this._emptySymbol = ' ';
     }

    annotate(board) {
        let annotatedBoard = [];

        for (let i = 0; i < board.length; i++) {
            let row = [];

            for (let j = 0; j < board[i].length; j++) {
                row.push(this._getBoardSymbol(board, i, j));
            }

            annotatedBoard.push(row.join(''));
        }

        return annotatedBoard;
    }

    _getBoardSymbol(board, i, j) {
        if (board[i][j] === this._mineSymbol) {
            return this._mineSymbol;
        }
        else {
            let mines = 0;

            mines += (board[i][j - 1] === this._mineSymbol) + (board[i][j + 1] === this._mineSymbol);

            if (board[i - 1]) {
                mines += (board[i - 1][j - 1] === this._mineSymbol) + (board[i - 1][j] === this._mineSymbol) + (board[i - 1][j + 1] === this._mineSymbol);
            }

            if (board[i + 1]) {
                mines += (board[i + 1][j - 1] === this._mineSymbol) + (board[i + 1][j] === this._mineSymbol) + (board[i + 1][j + 1] === this._mineSymbol);
            }

            return mines === 0 ? this._emptySymbol : mines + '';
        }
    }
};

module.exports = Minesweeper;
