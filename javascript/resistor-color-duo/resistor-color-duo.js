const colorValueMap = {
  'black': 0, 'brown': 1, 'red': 2, 'orange': 3, 'yellow': 4,
  'green': 5, 'blue': 6, 'violet': 7, 'grey': 8, 'white': 9
};

function value(colors) {
  if (colors.length < 2) {
    throw new Error("Count of colors less than 2.");
  }

  return convertColorToValue(colors[0]) * 10 + convertColorToValue(colors[1]);
};

function convertColorToValue(color) {
  if (colorValueMap[color] === undefined) {
    throw new Error(`Unknown color: ${color}.`);
  }

  return colorValueMap[color];
}

export { colorValueMap, value, convertColorToValue };
