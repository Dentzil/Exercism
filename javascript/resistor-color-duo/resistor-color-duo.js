export const colorValueMap = {
  'black': 0, 'brown': 1, 'red': 2, 'orange': 3, 'yellow': 4, 'green': 5, 'blue': 6, 'violet': 7, 'grey': 8, 'white': 9
};


export const value = (colors) => {
  let numbers = [];

  for ( let i = 0; i < 2; i++) {
    if (colorValueMap[colors[i]] === undefined) {
      throw new Error(`Unknown color: ${colors[i]}`);
    }

    numbers.push(colorValueMap[colors[i]]);
  }

  let result = +numbers.join('');

  return result;
};
