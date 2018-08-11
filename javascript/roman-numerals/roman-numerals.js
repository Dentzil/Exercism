var toRoman = function(number) {
    const thousand = [ "", "M", "MM", "MMM" ];
    const hundred = [ "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" ];
    const ten = [ "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" ];
    const one = [ "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" ];

    let roman = [];
    
    roman.push(thousand[Math.floor(number / 1000) % 10]);
    roman.push(hundred[Math.floor(number / 100) % 10]);
    roman.push(ten[Math.floor(number / 10) % 10]);
    roman.push(one[number % 10]);
    
    return roman.join('');
};

module.exports = toRoman;
