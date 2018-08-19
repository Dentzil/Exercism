const allergies = [ "eggs", "peanuts", "shellfish", "strawberries", "tomatoes", "chocolate", "pollen", "cats" ];

class Allergies {
    constructor(score) {
        this.personAllergies = [];

        for (let i = 0; i < allergies.length; i++) {
            if ((score & 1) === 1) {
                this.personAllergies.push(allergies[i]);
            }

            score >>= 1;
        }
    }

    list() {
        return this.personAllergies.slice();
    }

    allergicTo(allergie) {
        return this.personAllergies.indexOf(allergie) >= 0;
    }
}

module.exports = Allergies;
