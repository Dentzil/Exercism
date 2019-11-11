class ArmstrongNumbers {

	boolean isArmstrongNumber(int numberToCheck) {
		int countOfDigits = (int) (Math.log10(numberToCheck) + 1);
		int tmp = numberToCheck;
		int sum = 0;

		while (tmp != 0) {
			sum += Math.pow(tmp % 10, countOfDigits);
			tmp /= 10;
		}

		return sum == numberToCheck;
	}

}
