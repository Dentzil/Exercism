var score = require('./scrabble-score');

describe('Scrabble', function () {
  it('scores an empty word as zero', function () {
    expect(score('')).toEqual(0);
  });

  ('scores a null as zero', function () {
    expect(score(null)).toEqual(0);
  });

  ('scores a very short word', function () {
    expect(score('a')).toEqual(1);
  });

  ('scores the word by the number of letters', function () {
    expect(score('street')).toEqual(6);
  });

  ('scores more complicated words with more', function () {
    expect(score('quirky')).toEqual(22);
  });

  ('scores case insensitive words', function () {
    expect(score('OXYPHENBUTAZONE')).toEqual(41);
  });
});
