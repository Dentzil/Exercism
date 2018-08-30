const openBrackets = new Set(['{', '[', '(']);
const closeBrackets = new Set(['}', ']', ')']);
const bracketsMap = {
    '}': '{',
    ']': '[',
    ')': '('
}

export function bracketPush(input) {
    let stack = [];

    for (let i = 0; i < input.length; i++) {
        if (isOpenBracket(input[i])) {
            stack.unshift(input[i]);
        }
        else if (isCloseBracket(input[i])) {
            if (bracketsMap[input[i]] !== stack.shift()) {
                return false;
            }
        }
        else {
            return false;
        }
    }
    
    return stack.length === 0;
}

function isOpenBracket(bracket) {
    return openBrackets.has(bracket);
}

function isCloseBracket(bracket) {
    return closeBrackets.has(bracket);
}
